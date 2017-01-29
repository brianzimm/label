Imports System.Text
Imports System.IO
Imports System.Net

Public Class Form1
    Dim varitemcol As Integer = 1 'assume that we have a normal pog till we find Row in the 2nd field
    Dim varpogname As String
    Dim bay1 As New List(Of String)
    Dim bay2 As New List(Of String)
    Dim bay3 As New List(Of String)
    Dim bay4 As New List(Of String)
    Dim bay5 As New List(Of String)
    Dim bay6 As New List(Of String)
    Dim bay7 As New List(Of String)
    Dim bay8 As New List(Of String)
    Dim bay9 As New List(Of String)
    Dim bay10 As New List(Of String)
    Dim bay11 As New List(Of String)
    Dim bay12 As New List(Of String)
    Private Sub btnlocatepog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlocatepog.Click
        'Button Bin Locate POG
        txtstop.Text = "STOP"
        If txtAisle.Text = "" Or txtBay.Text = "" Then 'test if aisle or bay is empty
            Dim varmsgbox As MsgBoxResult 'var for msg box
            varmsgbox = MsgBox("Remove bin locations?", MsgBoxStyle.YesNo, "Bin Locate") 'ask to remove location
            If varmsgbox = MsgBoxResult.Yes Then
                UNBinLocate()
            End If
        Else
            txtstop.Focus()
            BinLocate(cbitemsnof.Checked) 'we have good data lets do this
        End If
        txtstop.Text = "STOP"
    End Sub
    Private Sub UNBinLocate()
        Dim vardone 'vardone is used to read raw pog data
        Dim i As Long 'i is for array usage
        Dim strvar As String 'strvar hold data before it is typed
        Dim vardelay As Integer
        If Integer.TryParse(txtlbltime.Text, vardelay) = False Then
            vardelay = 500
        End If
        lbltime.Text = "Time Estimate: 6sec to move your mouse and about " + Str(Math.Round((UBound(txtdone.Lines) * 600) + (Math.Round((UBound(txtdone.Lines) / 14)) * 2000)) / 1000) + "sec to bin locate."
        Me.Refresh() 'refresh the time extimate
        Threading.Thread.Sleep(6000) 'delay 6sec to move your mouse to the screen
        For i = 1 To UBound(txtdone.Lines) 'start reading the array one by one

            vardone = Split(txtdone.Lines(i), " ") 'split the array by spaces
            strvar = vardone(1) + "{TAB}*{F9}          {F9}" 'set data to send
            SendKeys.Send(strvar) 'send the data
            Threading.Thread.Sleep((vardelay / 5)) 'delay for 100ms

        Next
        lbltime.Text = "Time Estimate:"
        Me.Activate() 'puts window in front
        MsgBox("Items are now unlocated.", MsgBoxStyle.Information, "Done") 'display done message
    End Sub
    Private Sub BinLocate(ByVal varnof As Boolean)
        Dim vardone 'vardone is used to read raw pog data
        Dim i As Long 'i is for array usage
        Dim strvar As String 'strvar hold data before it is typed
        Dim strvartab As String 'strvartab has the tab key in it till varnum goes over 100
        Dim strvartab2 As String 'strvartab is tab till txtBay.text is more than 1 char
        Dim strvartab3 As String 'strvartab is tab till txtAisle.text is more than 2 char
        Dim varnum As Integer 'varnum count the odd numbers
        Dim varnum2 As Integer 'varnum2 count 1 to 14 for the max number of items that can go on screen
        Dim vardelay As Integer
        If Integer.TryParse(txtlbltime.Text, vardelay) = False Then
            vardelay = 500
        End If

        If Integer.TryParse(txtStartLoc.Text, varnum) = False Then
            varnum = 1 'start odd counting at 1
        End If
        varnum2 = 0 'start screen count at 0
        strvartab = "{TAB}" 'is tab till varnum is over 1000
        If txtBay.TextLength > 1 Then 'check lenght of bay
            strvartab2 = "" 'set to empty
        Else
            strvartab2 = "{TAB}" 'set to tab
        End If
        'check for 3 char Aisles
        If txtAisle.TextLength > 2 Then 'check lenght of aisle
            strvartab3 = "" 'set to empty
        Else
            strvartab3 = "{TAB}" 'set to tab
        End If
        'end check for 3 char Aisles
        lbltime.Text = "Time Estimate: 6sec to move your mouse and about " + Str(Math.Round((UBound(txtdone.Lines) * 600) + (Math.Round((UBound(txtdone.Lines) / 14)) * 2000)) / 1000) + "sec to bin locate."
        Me.Refresh() 'refresh the time extimate
        Threading.Thread.Sleep(6000) 'delay 6sec to move your mouse to the screen
        For i = 1 To UBound(txtdone.Lines) 'start reading the array one by one
            If varnum > 1000 Then 'if varnum is over 1000
                strvartab = "" 'set strvartab to nothing
            End If
            vardone = Split(txtdone.Lines(i), " ") 'split the array by spaces
            varnum2 += 1 'add one to screen count
            strvar = vardone(1) + "{TAB}B" + txtAisle.Text + strvartab3 + txtBay.Text + strvartab2 + Trim(Str(varnum)) + strvartab 'set data to send
            SendKeys.Send(strvar) 'send the data
            Threading.Thread.Sleep((vardelay / 5)) 'delay for 100ms
            varnum += 2 'add to the odd count
            Dim varnofnum As Integer 'nof var 1
            Dim varnofnum2 As Integer 'nof var 2
            If varnof Then 'if varnof is true we will bin locate one item at a time
                varnofnum = 1
                varnofnum2 = (vardelay / 2)
            Else 'if varnof is false we will bin locate as normal
                varnofnum = 14
                varnofnum2 = (vardelay * 3)
            End If

            If varnum2 = varnofnum Then 'if screen count is 14 need new screen
                varnum2 = 0 'set to 0
                SendKeys.Send("{F9}") 'clear screen and submit data
                Threading.Thread.Sleep(varnofnum2) 'wait 2sec for data to submit
            End If
            lblcount.Text = (UBound(txtdone.Lines) - i).ToString + " Left"
            Application.DoEvents() 'refresh the time estimate
            If (txtstop.Text = "STOP") = False Then
                i = UBound(txtdone.Lines)
            End If
        Next
        SendKeys.Send("{F9}") 'clear screen and submit any leftover data
        lbltime.Text = "Time Estimate:"
        Me.Activate() 'puts window in front
        MsgBox("Items are now located.", MsgBoxStyle.Information, "Done") 'display done message
    End Sub

    Private Sub MakeLabel(ByVal varnof As Boolean, ByVal varlabeloption As Boolean, ByVal vardefaults As Boolean)
        Dim vardone 'vardone is used to read raw pog data
        Dim vardone2 As String
        Dim i As Long 'i is for array usage
        Dim strvar As String 'strvar hold data before it is typed
        Dim varnum2 As Integer 'varnum2 count 1 to 14 for the max number of items that can go on screen
        Dim varstrlen As Integer 'see how many number are item number is
        Dim varitemnum
        Dim vardelay As Integer
        If Integer.TryParse(txtlbltime.Text, vardelay) = False Then
            vardelay = 500
        End If

        varnum2 = 0 'start screen count at 0
        lbltime.Text = "Time Estimate: 6sec to move your mouse and about " + Str(Math.Round((UBound(txtdone.Lines) * 900) + (Math.Round((UBound(txtdone.Lines) / 6)) * 2000)) / 1000) + "sec to make labels."
        Me.Refresh() 'refresh the time estimate
        Threading.Thread.Sleep(6000) 'delay 6sec to move your mouse to the screen
        For i = 1 To UBound(txtdone.Lines) 'start reading the array one by one
            vardone = Split(txtdone.Lines(i), " ") 'split the array by spaces
            vardone = Split(txtdone.Lines(i), " ") 'split the array by spaces
            vardone2 = vardone(1) 'woho do more comments later
            vardone2 = Trim(Str(vardone2))
            varitemnum = Trim(Str(vardone2))
            varnum2 += 1 'add one to screen count
            varstrlen = vardone2.Length 'find out the lenght of the item number and add 0 to the front of it till we have 9 digits
            If varstrlen = 1 Then
                vardone2 = "00000000" + vardone2
            ElseIf varstrlen = 2 Then
                vardone2 = "0000000" + vardone2
            ElseIf varstrlen = 3 Then
                vardone2 = "000000" + vardone2
            ElseIf varstrlen = 4 Then
                vardone2 = "00000" + vardone2
            ElseIf varstrlen = 5 Then
                vardone2 = "0000" + vardone2
            ElseIf varstrlen = 6 Then
                vardone2 = "000" + vardone2
            ElseIf varstrlen = 7 Then
                vardone2 = "00" + vardone2
            ElseIf varstrlen = 8 Then
                vardone2 = "0" + vardone2
            End If
            SendKeys.Send(vardone2) 'set data to send
            Threading.Thread.Sleep(vardelay) 'delay 500ms
            If varlabeloption = True Then 'if varlabeloption is yes then we will use the pog default for labels
                If vardone(UBound(vardone)) = "BIN" Then
                    strvar = itemprint(varitemnum, "01", "00")
                    'strvar = "0100"
                Else
                    'default beam
                    strvar = itemprint(varitemnum, "00", "01")
                    'strvar = "0001"
                End If
            Else
                'this is user input
                strvar = itemprint(varitemnum, txtbin.Text, txtBeam.Text)
                'strvar = txtbin.Text + txtBeam.Text  'set data to send
            End If
            SendKeys.Send(strvar) 'send keys
            Threading.Thread.Sleep((vardelay / 5)) 'delay 100ms
            SendKeys.Send("{DOWN}") 'press down key
            Threading.Thread.Sleep((vardelay / 5)) 'delay 100ms

            Dim varnofnum As Integer 'nof var 1
            Dim varnofnum2 As Integer 'nof var 2
            If varnof Then 'if varnof is true we will make labels one item at a time
                varnofnum = 1
                varnofnum2 = (vardelay / 2)
            Else 'if varnof is false we will make labels as normal
                varnofnum = 6
                varnofnum2 = (vardelay * 3)
            End If

            If varnum2 = varnofnum Then 'if screen count is 6 need new screen
                varnum2 = 0 'set to 0
                If vardefaults = True Then
                    SendKeys.Send("{F4}{F9}") 'clear screen and submit data
                Else
                    SendKeys.Send("{F9}") 'clear screen and submit data
                End If
                Threading.Thread.Sleep(varnofnum2) 'delay 2sec
            End If
            lblcount.Text = (UBound(txtdone.Lines) - i).ToString + " Left"
            Application.DoEvents() 'refresh the time estimate
            If (txtstop.Text = "STOP") = False Then
                i = UBound(txtdone.Lines)
            End If
        Next
        If vardefaults = True Then
            SendKeys.Send("{F4}{F9}") 'clear screen and submit data
        Else
            SendKeys.Send("{F9}") 'clear screen and submit data
        End If
        lbltime.Text = "Time Estimate:"
        Me.Activate() 'puts window in front
        MsgBox("Labels are done and ready to print.", MsgBoxStyle.Information, "Done") 'display done message
    End Sub

    Private Sub btnlabelpog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlabelpog.Click
        'Button Make Labels POG
        Dim varmsgbox As Boolean 'var for msg box
        Dim varmsgbox2 As Boolean 'var for msg box
        Dim varbin As Integer 'vars for test
        Dim varbeam As Integer 'vars for test
        Dim test As Boolean 'vars for test
        Dim test1 As Boolean 'vars for test
        Dim test2 As Boolean 'vars for test
        Dim test3 As Boolean 'vars for test
        txtstop.Text = "STOP"
        test = (Integer.TryParse(txtbin.Text, varbin) = False Or Integer.TryParse(txtBeam.Text, varbeam) = False) 'test for valid numbers
        test1 = (txtbin.Text = "00" And txtBeam.Text = "00") 'check for no labels
        test2 = (txtbin.Text.ToString.Length < 2 Or txtBeam.Text.ToString.Length < 2) 'check for less than 2 char in fields
        test3 = (varbin > 10 Or varbeam > 10) 'make sure the number is less than 10
        If cbpogdefault.CheckState = CheckState.Checked Then
            varmsgbox = True
        Else
            varmsgbox = False
        End If
        If cbdefault.CheckState = CheckState.Checked Then
            varmsgbox2 = True
        Else
            varmsgbox2 = False
        End If
        If cbpogdefault.CheckState = CheckState.Unchecked And (test Or test1 Or test2 Or test3) Then 'test for bad data
            MsgBox("Error to many or no labels requested." + vbNewLine + "Not making labels", MsgBoxStyle.Critical, "Error") 'we have bad data stop
        Else
            txtstop.Focus()
            MakeLabel(cbitemsnof.Checked, varmsgbox, varmsgbox2) 'we have good data lets do this
            txtItem.Text = ""
        End If
        txtstop.Text = "STOP"
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Me.Text = "Label Maker - Version " + Application.ProductVersion
        'If MsgBox("By: BZ" + vbNewLine + vbNewLine + "Label Maker is a proof of concept that there is an easier way to bin locate and queue labels from a raw planogram or list of items." + vbNewLine + vbNewLine + vbNewLine + "Run " + Me.Text + "?", MsgBoxStyle.YesNo, "About") = MsgBoxResult.No Then
        'End
        'End If

        If System.IO.File.Exists(Application.StartupPath + "\error-bug report.pdf") Then
            gbpricing.Visible = True
        End If
    End Sub

    Private Sub btndatacheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndatacheck.Click
        datacheck()
        If txtdone.Text = "Data Check" Then
            'no data
            MsgBox("Error no valid data entered or found." + vbNewLine + "Did you pick the correct option?", MsgBoxStyle.Critical, "ERROR")
        Else
            If MsgBox("Do you want to enter another page (same bay only)?", MsgBoxStyle.YesNo, "Data Check") = MsgBoxResult.Yes Then
                txtItem.Text = ""
            Else
                'data ya
                lblcount.Text = (UBound(txtdone.Lines)).ToString + " Left"
                'txtItem.Text = ""
                btnclear.Enabled = True

                'btnlabelpog.Enabled = True
                'btnlocatepog.Enabled = True

                btndatacheck.Enabled = False

                cbitemsnof.Enabled = True

                txtItem.Enabled = False

                'txtAisle.Enabled = True
                'txtBay.Enabled = True
                'txtbin.Enabled = True
                'txtBeam.Enabled = True
                'cbpogdefault.Enabled = True
                'cbdefault.Enabled = True
                gblocate.Enabled = True
                gblabels.Enabled = True
            End If
        End If

    End Sub

    Public Function samecheck(ByVal varitem) As Boolean
        Dim varreturn As Boolean
        Dim vardone
        Dim vartest
        varreturn = False
        For i = 1 To UBound(txtdone.Lines)
            vardone = Split(txtdone.Lines(i), " ")
            vartest = vardone(1)
            If varitem = vartest Then
                'we have the same item send True
                varreturn = True
            End If
        Next
        Return varreturn
    End Function

    Public Function itemprint(ByVal varitem As String, ByVal binnumcount As String, ByVal beamnumcount As String) As String
        Dim varreturn As String
        Dim vardone
        Dim vartest
        Dim varcount As Integer

        If txtextras.Text = "Data Check - Duplicate Items" Then
            'skip
        Else
            'check
            For i = 1 To UBound(txtextras.Lines)
                vardone = Split(txtextras.Lines(i), " ")
                vartest = vardone(1)
                If varitem = vartest Then
                    'we have the same item send True
                    varcount += 1
                End If
            Next
        End If

        If Int(binnumcount) >= 1 Then
            binnumcount = Trim(Str(Int(binnumcount) + varcount))
        End If
        If binnumcount.Length < 2 Then
            binnumcount = "0" + Trim(Str(Int(binnumcount)))
        End If

        If Int(beamnumcount) >= 1 Then
            beamnumcount = Trim(Str(Int(beamnumcount) + varcount))
        End If
        If beamnumcount.Length < 2 Then
            beamnumcount = "0" + Trim(Str(Int(beamnumcount)))
        End If

        varreturn = binnumcount + beamnumcount
        Return varreturn
    End Function

    Private Sub datacheck()
        Dim vardone 'vardone is used to read raw pog data
        Dim i As Long 'i is for array usage
        Dim varnum As Integer 'varnum count the odd numbers
        Dim vartest 'vartest is looking at the 1st field for stuff
        Dim vartest2
        Dim vartest3 As Integer 'vartest3 contains the first field if it not junk
        Dim vardefault
        Dim vartmp As Integer 'temp var for checking for bad data
        'Dim varitemcol As Integer
        Dim vart As Boolean
        vardefault = " BEAM" 'is default just in case item is missing label field
        varnum = 0 'start odd counting at 1
        vart = False 'assume item list till we test for it
        For i = 0 To UBound(txtItem.Lines) 'test for raw pog data
            If UBound(Split(txtItem.Lines(i), " ")) > 1 Then
                'we have pog data ya auto detection
                vart = True
            End If
        Next

        For i = 0 To UBound(txtItem.Lines) 'start reading the array one by one
            If vart Then 'if vart is False we are reading in raw pog data
                vardone = Split(txtItem.Lines(i), " ") 'split the data

                If Integer.TryParse(vardone(0), vartest3) And vartest3 < 10000 And UBound(vardone) > 1 Then 'see if there be junk in there
                    'test
                    If Integer.TryParse(vardone(1), vartmp) Then
                        'If Integer.TryParse(vartest, vartest3) And vartest3 < 10000 And UBound(vardone) > 1 And Integer.TryParse(vartest2, vartmp) Then 'see if there be junk in there
                        'test

                        vartest = vardone(0).ToString.PadLeft(3, "0"c) 'vardone(0) 'hold the 1st field


                        vartest2 = vardone(1) '2nd field
                        'test
                        If UCase(vardone(UBound(vardone))) = "BIN" Or UCase(vardone(UBound(vardone))) = "BEAM" Then 'check for bin or beam on raw pog data (ignore displays)
                            vardefault = UCase(vardone(UBound(vardone))) 'what type of label we have
                            'check for same item numbers
                            varnum += 1 'add one to screen count

                            If samecheck(vardone(varitemcol)) = False Then 'check for the same item
                                'not found add to normal list
                                txtdone.Text = txtdone.Text + vbNewLine + vartest + " " + vardone(varitemcol) + " " + vardefault 'set data to send
                            Else
                                'found add to extras
                                txtextras.Text = txtextras.Text + vbNewLine + vartest + " " + vardone(varitemcol) + " " + vardefault 'set data to send
                            End If
                        ElseIf cbmiadefault.CheckState = CheckState.Checked Then 'default Beam Label
                            vardefault = "BEAM"
                            'check for same item numbers
                            varnum += 1 'add one to screen count
                            If samecheck(vardone(varitemcol)) = False Then 'check for the same item
                                'not found add to normal list
                                txtdone.Text = txtdone.Text + vbNewLine + vartest + " " + vardone(varitemcol) + " " + vardefault 'set data to send
                            Else
                                'found add to extras
                                txtextras.Text = txtextras.Text + vbNewLine + vartest + " " + vardone(varitemcol) + " " + vardefault 'set data to send
                            End If
                        End If
                        'test
                    End If
                    'test
                End If

                For x = 0 To UBound(vardone) 'look for the Page:
                    Dim vartestend
                    vartestend = Split(vardone(x), "-")
                    If String.Equals(vartestend(0), "700") Then 'found the page end reading in
                        i = UBound(txtItem.Lines)
                    End If
                    If String.Equals(vardone(x), "Row") And x < 3 Then 'test for row and if found we have pegs
                        'test for pegs
                        varitemcol = 3
                    End If
                Next


            Else 'if vart is True we are reading in list data
                If txtItem.Lines(i).Length < 8 And Integer.TryParse(txtItem.Lines(i), vartmp) Then
                    'check for same item numbers
                    varnum += 1 'add one to screen count
                    If samecheck(txtItem.Lines(i)) = False Then 'check for the same item
                        'not found add to normal list
                        txtdone.Text = txtdone.Text + vbNewLine + Trim(Str(varnum)) + " " + txtItem.Lines(i) + vardefault 'set data to send
                    Else
                        'found add to extras
                        txtextras.Text = txtextras.Text + vbNewLine + Trim(Str(varnum)) + " " + txtItem.Lines(i) + vardefault 'set data to send
                    End If
                End If
            End If
        Next

        If cbsort.CheckState = CheckState.Unchecked Then
            Dim varsort As Array
            varsort = txtdone.Lines
            Array.Sort(Of String)(varsort)
            txtdone.Lines = varsort
        End If
    End Sub

    Private Sub datacheck_index()
        Dim varitems
        Dim varbay
        Dim varlocation
        Dim labeltype As String
        Dim varitemsx
        varitemsx = 0
        For i = 0 To UBound(txtItem.Lines)
            varlocation = "No"
            varbay = "No"
            varitems = Split(txtItem.Lines(i), " ")
            For x = 0 To UBound(varitems)
                If varitems(x) = "Bay:" Then
                    varbay = varitems(x + 1)
                ElseIf varitems(x) = "Location:" Then
                    varlocation = varitems(x + 1)
                    If varlocation = "" Then
                        varlocation = varitems(x + 2)
                    End If
                End If

            Next
            If varlocation = "No" Then
                'no data
                If varitems(0) = "Row" Then
                    varitemsx = 2
                End If
            Else
                If (varitems(UBound(varitems)).ToString = "BEAM") Or (varitems(UBound(varitems)).ToString = "BIN") Then
                    'ok
                    labeltype = varitems(UBound(varitems)).ToString
                Else
                    labeltype = " "
                End If
                'ya data
                If varbay = "1" Then
                    'bay 1
                    bay1.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "2" Then
                    bay2.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "3" Then
                    bay3.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "4" Then
                    bay4.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "5" Then
                    bay5.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "6" Then
                    bay6.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "7" Then
                    bay7.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "8" Then
                    bay8.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "9" Then
                    bay9.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "10" Then
                    bay10.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "11" Then
                    bay11.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                ElseIf varbay = "12" Then
                    bay12.Add(varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(varitemsx).ToString + " " + labeltype)
                End If
                'txtdone.Text = txtdone.Text + varlocation.ToString.PadLeft(3, "0"c) + " " + varitems(0).ToString + " " + varitems(UBound(varitems)).ToString + vbNewLine
            End If
        Next
        'sort bays
        bay1.Sort()
        bay2.Sort()
        bay3.Sort()
        bay4.Sort()
        bay5.Sort()
        bay6.Sort()
        bay7.Sort()
        bay8.Sort()
        bay9.Sort()
        bay10.Sort()
        bay11.Sort()
        bay12.Sort()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        If MsgBox("Ready for next POG?", MsgBoxStyle.YesNo, "Ready for next POG?") = MsgBoxResult.Yes Then
            bay1.Clear()
            bay2.Clear()
            bay3.Clear()
            bay4.Clear()
            bay5.Clear()
            bay6.Clear()
            bay7.Clear()
            bay8.Clear()
            bay9.Clear()
            bay10.Clear()
            bay11.Clear()
            bay12.Clear()
            lblcount.Text = "0 Left"
            txtItem.Text = ""
            txtdone.Text = "000 Data Check"
            txtextras.Text = "Data Check - Duplicate Items"
            txtBay.Text = ""
            txtAisle.Text = ""

            gblocate.Enabled = False
            gblabels.Enabled = False

            btnclear.Enabled = False
            'btnlabelpog.Enabled = False
            'btnlocatepog.Enabled = False
            btndatacheck.Enabled = True
            cbitemsnof.Enabled = False
            txtItem.Enabled = True
            'txtAisle.Enabled = False
            'txtBay.Enabled = False
            'txtbin.Enabled = False
            'txtBeam.Enabled = False
            'cbpogdefault.Enabled = False
            'cbdefault.Enabled = False

            cboxbay.Enabled = False
            btnindexload.Enabled = False
            btnpdfread.Enabled = True
            cboxbay.Items.Clear()
            cboxbay.Text = ""
            cbsort.Checked = False
            btnallpog.Enabled = False
            lblpog.Text = "POG: "
            varitemcol = 1 'assume that we have a normal pog till we find Row in the 2nd field
            txtItem.Focus()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("By: " + My.Application.Info.Copyright + vbNewLine + vbNewLine + "Label Maker is a proof of concept that there is an easier way to bin locate and queue labels from a raw planogram or list of items." + vbNewLine + vbNewLine + vbNewLine + Me.Text, MsgBoxStyle.Information, "About")
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        HideAdvancedOptionsToolStripMenuItem.Enabled = True
        OptionsToolStripMenuItem.Enabled = False
        Me.Width = 719
    End Sub

    Private Sub HideAdvancedOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideAdvancedOptionsToolStripMenuItem.Click
        OptionsToolStripMenuItem.Enabled = True
        HideAdvancedOptionsToolStripMenuItem.Enabled = False
        Me.Width = 364
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewHelpToolStripMenuItem.Click
        If System.IO.File.Exists(Application.StartupPath + "\Label Maker Help v" + Application.ProductVersion + ".pdf") Then
            Dim p As New Process
            Dim pi As New ProcessStartInfo
            pi.FileName = Application.StartupPath + "\Label Maker Help v" + Application.ProductVersion + ".pdf"
            pi.UseShellExecute = True
            p.StartInfo = pi
            p.Start()
        Else
            MsgBox("Error finding help file" + vbNewLine + Application.StartupPath + "\Label Maker Help v" + Application.ProductVersion + ".pdf", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub btnactivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnactivate.Click
        txtstop.Text = "STOP"
        txtstop.Focus()
        act() 'we have good data lets do this
        txtstop.Text = "STOP"
    End Sub

    Private Sub act()
        Dim vardone 'vardone is used to read raw pog data
        Dim i As Long 'i is for array usage
        Dim strvar As String 'strvar hold data before it is typed
        Dim vardelay As Integer
        If Integer.TryParse(txtlbltime.Text, vardelay) = False Then
            vardelay = 500
        End If
        lbltime.Text = "Time Estimate: 6sec to move your mouse"
        Me.Refresh() 'refresh the time extimate
        Threading.Thread.Sleep(6000) 'delay 6sec to move your mouse to the screen
        For i = 1 To UBound(txtdone.Lines) 'start reading the array one by one
            vardone = Split(txtdone.Lines(i), " ") 'split the array by spaces
            strvar = vardone(1) 'set data to send
            SendKeys.Send(strvar) 'send the data
            Threading.Thread.Sleep((vardelay / 5)) 'delay for 100ms

            SendKeys.Send("{F9}{F9}{F9}") 'clear screen and submit data
            Threading.Thread.Sleep((vardelay / 2)) 'wait 2sec for data to submit

            lblcount.Text = (UBound(txtdone.Lines) - i).ToString + " Left"
            Application.DoEvents() 'refresh the time estimate
            If (txtstop.Text = "STOP") = False Then
                i = UBound(txtdone.Lines)
            End If
        Next
        lbltime.Text = "Time Estimate:"
        Me.Activate() 'puts window in front
        MsgBox("Items are now active.", MsgBoxStyle.Information, "Done") 'display done message
    End Sub

    Private Sub tupdate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tupdate.Tick
        tupdate.Enabled = False
    End Sub
  
    Private Sub cbpogdefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbpogdefault.CheckedChanged
        If cbpogdefault.CheckState = CheckState.Checked Then
            Label4.Visible = False
            Label5.Visible = False
            txtbin.Visible = False
            txtBeam.Visible = False
        Else
            Label4.Visible = True
            Label5.Visible = True
            txtbin.Visible = True
            txtBeam.Visible = True
        End If


    End Sub

    Private Sub btnindexload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnindexload.Click
        If cboxbay.SelectedIndex = "0" Then
            txtItem.Lines = bay1.ToArray()
        ElseIf cboxbay.SelectedIndex = "1" Then
            txtItem.Lines = bay2.ToArray()
        ElseIf cboxbay.SelectedIndex = "2" Then
            txtItem.Lines = bay3.ToArray()
        ElseIf cboxbay.SelectedIndex = "3" Then
            txtItem.Lines = bay4.ToArray()
        ElseIf cboxbay.SelectedIndex = "4" Then
            txtItem.Lines = bay5.ToArray()
        ElseIf cboxbay.SelectedIndex = "5" Then
            txtItem.Lines = bay6.ToArray()
        ElseIf cboxbay.SelectedIndex = "6" Then
            txtItem.Lines = bay7.ToArray()
        ElseIf cboxbay.SelectedIndex = "7" Then
            txtItem.Lines = bay8.ToArray()
        ElseIf cboxbay.SelectedIndex = "8" Then
            txtItem.Lines = bay9.ToArray()
        ElseIf cboxbay.SelectedIndex = "9" Then
            txtItem.Lines = bay10.ToArray()
        ElseIf cboxbay.SelectedIndex = "10" Then
            txtItem.Lines = bay11.ToArray()
        ElseIf cboxbay.SelectedIndex = "11" Then
            txtItem.Lines = bay12.ToArray()
        End If
        txtdone.Text = "000 Data Check"
        txtextras.Text = "Data Check - Duplicate Items"
        datacheck()
        lblcount.Text = (UBound(txtdone.Lines)).ToString + " Left"
        gblocate.Enabled = True
        gblabels.Enabled = True
        MsgBox("Bay " + (cboxbay.SelectedIndex + 1).ToString + " for " + varpogname + " POG Loaded" + vbNewLine + vbNewLine + "Ready for 'Bin Locate' or 'Make Labels'.", MsgBoxStyle.Information, "Bay Loaded")
    End Sub

    Private Sub btnpdfread_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpdfread.Click
        Dim varpdfpath

        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) = False Then
            'error
            MsgBox("Error no file selected", MsgBoxStyle.Critical, "Error")
        Else
            'have a file
            varpdfpath = OpenFileDialog1.FileName
            txtItem.Lines = GetTextFromPDF(varpdfpath).ToArray
            varpogname = txtItem.Lines(UBound(txtItem.Lines))

            'data check index
            datacheck_index()
            'lock stuff
            'txtItem.Text = ""
            btnclear.Enabled = True

            'btnlabelpog.Enabled = True
            'btnlocatepog.Enabled = True
            'btndatacheck.Enabled = False
            cbitemsnof.Enabled = True
            txtItem.Enabled = False
            'txtAisle.Enabled = True
            'txtBay.Enabled = True
            'txtbin.Enabled = True
            'txtBeam.Enabled = True
            'cbpogdefault.Enabled = True
            'cbdefault.Enabled = True

            cboxbay.Enabled = True
            btnindexload.Enabled = True
            btnpdfread.Enabled = False
            btnallpog.Enabled = True
            If (bay1.Count = 0) = False Then
                cboxbay.Items.Add("1")
                bay1.Add(varpogname + " Bay 1")
            End If
            If (bay2.Count = 0) = False Then
                cboxbay.Items.Add("2")
                bay2.Add(varpogname + " Bay 2")
            End If
            If (bay3.Count = 0) = False Then
                cboxbay.Items.Add("3")
                bay3.Add(varpogname + " Bay 3")
            End If
            If (bay4.Count = 0) = False Then
                cboxbay.Items.Add("4")
                bay4.Add(varpogname + " Bay 4")
            End If
            If (bay5.Count = 0) = False Then
                cboxbay.Items.Add("5")
                bay5.Add(varpogname + " Bay 5")
            End If
            If (bay6.Count = 0) = False Then
                cboxbay.Items.Add("6")
                bay6.Add(varpogname + " Bay 6")
            End If
            If (bay7.Count = 0) = False Then
                cboxbay.Items.Add("7")
                bay7.Add(varpogname + " Bay 7")
            End If
            If (bay8.Count = 0) = False Then
                cboxbay.Items.Add("8")
                bay8.Add(varpogname + " Bay 8")
            End If
            If (bay9.Count = 0) = False Then
                cboxbay.Items.Add("9")
                bay9.Add(varpogname + " Bay 9")
            End If
            If (bay10.Count = 0) = False Then
                cboxbay.Items.Add("10")
                bay10.Add(varpogname + " Bay 10")
            End If
            If (bay11.Count = 0) = False Then
                cboxbay.Items.Add("11")
                bay11.Add(varpogname + " Bay 11")
            End If
            If (bay12.Count = 0) = False Then
                cboxbay.Items.Add("12")
                bay12.Add(varpogname + " Bay 12")
            End If
            If cboxbay.Items.Count = 0 Then
                'no pog index found
                MsgBox("No valid POG data found!" + vbNewLine + vbNewLine + "Please e-mail bz with the pog index #", MsgBoxStyle.Critical, "ERROR")
            Else
                MsgBox("Found " + cboxbay.Items(cboxbay.Items.Count - 1) + " bay(s) for " + varpogname + " POG", MsgBoxStyle.Information, "POG Index Information Found")
                lblpog.Text = "POG: " + varpogname
                cboxbay.SelectedIndex = 0
                'hide stuff
            End If

        End If


    End Sub

    Public Shared Function GetTextFromPDF(ByVal PdfFileName As String) As List(Of String)
        Dim oReader As New iTextSharp.text.pdf.PdfReader(PdfFileName)
        Dim varreader
        Dim varreadersplit
        Dim varfound As Boolean
        Dim vartitlefind
        Dim vartitle As String
        vartitle = "N/A"
        Dim vartemp As Integer
        varfound = False
        Dim sOut As New List(Of String)


        For i = 1 To oReader.NumberOfPages
            Dim its As New iTextSharp.text.pdf.parser.SimpleTextExtractionStrategy

            varreader = Split(iTextSharp.text.pdf.parser.PdfTextExtractor.GetTextFromPage(oReader, i, its), vbLf)

            For x = 0 To UBound(varreader)

                varreadersplit = Split(varreader(x), " ")

                varfound = False
                'Look for index
                For y = 0 To UBound(varreadersplit)
                    If varreadersplit(y) = "Location:" Then
                        'We Have Found The Index Page's WOOT
                        varfound = True
                    End If
                    If varreadersplit(y) = "Row" Then
                        'We Have Found The Index Page's WOOT
                        varfound = True
                    End If
                    vartitlefind = Split(varreadersplit(y), "v")
                    If vartitlefind(UBound(vartitlefind)).ToString.Length = "3" And Integer.TryParse(vartitlefind(UBound(vartitlefind)).ToString, vartemp) Then
                        vartitle = varreader(x)
                    End If
                Next

                If varfound = True Then
                    'found it read in data
                    sOut.Add(varreader(x))
                End If

            Next

        Next
        sOut.Add(vartitle)

        Return sOut
    End Function

    Private Sub btnallpog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallpog.Click
        cbsort.Checked = True
        txtdone.Text = "000 Data Check"
        txtextras.Text = "Data Check - Duplicate Items"
        If cboxbay.Items.Count >= 0 Then
            txtItem.Lines = bay1.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 1 Then
            txtItem.Lines = bay2.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 2 Then
            txtItem.Lines = bay3.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 3 Then
            txtItem.Lines = bay4.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 4 Then
            txtItem.Lines = bay5.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 5 Then
            txtItem.Lines = bay6.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 6 Then
            txtItem.Lines = bay7.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 7 Then
            txtItem.Lines = bay8.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 8 Then
            txtItem.Lines = bay9.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 9 Then
            txtItem.Lines = bay10.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 10 Then
            txtItem.Lines = bay11.ToArray()
            datacheck()
        End If
        If cboxbay.Items.Count >= 11 Then
            txtItem.Lines = bay12.ToArray()
            datacheck()
        End If
        'set the pog name
        txtItem.Text = varpogname + " All"
        lblcount.Text = (UBound(txtdone.Lines)).ToString + " Left"

        If MsgBox("Are you sure you want to print labels for " + (UBound(txtdone.Lines)).ToString + " item(s)?" + vbNewLine + vbNewLine + "You may want to click Items Not On File.", MsgBoxStyle.YesNo, "Question?") = MsgBoxResult.Yes Then
            'MAKE LABELS
            'Button Make Labels POG
            Dim varmsgbox As Boolean 'var for msg box
            Dim varmsgbox2 As Boolean 'var for msg box
            Dim varbin As Integer 'vars for test
            Dim varbeam As Integer 'vars for test
            Dim test As Boolean 'vars for test
            Dim test1 As Boolean 'vars for test
            Dim test2 As Boolean 'vars for test
            Dim test3 As Boolean 'vars for test
            txtstop.Text = "STOP"
            test = (Integer.TryParse(txtbin.Text, varbin) = False Or Integer.TryParse(txtBeam.Text, varbeam) = False) 'test for valid numbers
            test1 = (txtbin.Text = "00" And txtBeam.Text = "00") 'check for no labels
            test2 = (txtbin.Text.ToString.Length < 2 Or txtBeam.Text.ToString.Length < 2) 'check for less than 2 char in fields
            test3 = (varbin > 10 Or varbeam > 10) 'make sure the number is less than 10
            If cbpogdefault.CheckState = CheckState.Checked Then
                varmsgbox = True
            Else
                varmsgbox = False
            End If
            If cbdefault.CheckState = CheckState.Checked Then
                varmsgbox2 = True
            Else
                varmsgbox2 = False
            End If
            If cbpogdefault.CheckState = CheckState.Unchecked And (test Or test1 Or test2 Or test3) Then 'test for bad data
                MsgBox("Error to many or no labels requested." + vbNewLine + "Not making labels", MsgBoxStyle.Critical, "Error") 'we have bad data stop
            Else
                txtstop.Focus()
                MakeLabel(cbitemsnof.Checked, varmsgbox, varmsgbox2) 'we have good data lets do this
                txtItem.Text = ""
            End If
            txtstop.Text = "STOP"
            'MAKE LABELS
        End If

    End Sub

    Private Sub SubmitSuggestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubmitSuggestionToolStripMenuItem.Click
        Dim webAddress As String = "https://lcssrv.myloweslife.com/wikis/home?lang=en_US#/wiki/W46a2bcf1b2df_402d_b674_913fe74903d2/page/Label%20Maker%20Program"
        Process.Start(webAddress)
    End Sub
End Class
