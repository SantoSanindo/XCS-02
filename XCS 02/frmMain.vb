Imports System.Net
Public Class frmMain
    Dim SlideCount As Integer
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        SlideCount = 47
        Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Dim projectFolder As String = fullPath.Replace("\XCS 02\bin\Debug\", "").Replace("\XCS 02\bin\Release\", "")
        If Dir(projectFolder & "\Config\Config.INI") = "" Then 'This is to initalize the program during start up
            MsgBox("Config.INI is missing")
            End
        End If

        ReadINI(projectFolder & "\Config\Config.INI")
        GetLastConfig()

        frmMsg.Show()
        frmMsg.TextBox1.Text = "Establishing connection with PLC..."

        frmModbus.Show()
        frmModbus.Hide()
        System.Threading.Thread.Sleep(10)
        Reset_PLC()

        Dim strHostName As String = Dns.GetHostName()
        Dim hostname As IPHostEntry = Dns.GetHostByName(strHostName)
        Dim ip As IPAddress() = hostname.AddressList
        lbl_localhostname.Text = "PC Name : " & strHostName
        lbl_localip.Text = "PC IP Address : " & ip(0).ToString

        frmMsg.TextBox1.Text = "Loading parameters..."

        If Not LoadParameter(LoadWOfrRFID.JobModelName) Then
            MsgBox("Unable to load parameters...")
            End
        End If

        lbl_currentref.Text = LoadWOfrRFID.JobProductMaterial
        lbl_wocounter.Text = LoadWOfrRFID.JobQTy
        Label5.Text = LoadWOfrRFID.JobHeadCount
        lbl_currcounter.Text = LoadWOfrRFID.JobUnitaryCount 'head tester output

        If Not LoadParameter2PLC() Then
            MsgBox("Unable to communication with PLC-%MW100")
            End
        End If

        If Not LoadRackMaterial() Then
            MsgBox("Unable to load Rack Materials")
            End
        End If

        If Not LoadModelMaterial(LoadWOfrRFID.JobProductMaterial) Then
            MsgBox("Unable to load Model Material")
            End
        End If

        frmMsg.TextBox1.Text = "Refreshing indicators..."

        If Not ActivateRackLED() Then
            MsgBox("Unable to communicate with PLC")
            End
        End If

        frmMsg.TextBox1.Text = "Connection to PLC established"
        frmMsg.Hide()
        Ethernet.BackColor = Color.Green

        If frmModbus.lbl_status.Text <> "Connected" Then
            Ethernet.BackColor = Color.Red
            Exit Sub
        End If

        Timer1.Enabled = True
    End Sub

    Private Sub cmd_quit_Click(sender As Object, e As EventArgs) Handles cmd_quit.Click
        Me.Close()
    End Sub

    Private Sub cmd_material_Click(sender As Object, e As EventArgs) Handles cmd_material.Click
        LoginMaterial = True
        LoginDatabase = False
        'FormLogin.Show()
        frmMaterial.Show()
    End Sub

    Private Sub cmd_database_Click(sender As Object, e As EventArgs) Handles cmd_database.Click
        LoginMaterial = False
        LoginDatabase = True
        'FormLogin.Show()
        frmDatabase.Show()
    End Sub

    Private Sub Cmd_CS_Click(sender As Object, e As EventArgs) Handles Cmd_CS.Click
        frmSelect.Show()
        If Not LoadParameter2PLC() Then
            MsgBox("Unable to communicate with PLC")
            Exit Sub
        End If
        If Not frmModbus.tulisModbus(40111, 0) Then
            MsgBox("unable to communicate with PLC - %MW111")
            Exit Sub
        End If
        If Not frmModbus.tulisModbus(40112, 0) Then
            MsgBox("unable to communicate with PLC - %MW112")
            Exit Sub
        End If

        Reset_PLC()

        'Load Model Material
        If Not LoadModelMaterial(LoadWOfrRFID.JobProductMaterial) Then
            MsgBox("Unable to load Model Material")
            Exit Sub
        End If

        'Update Rack indicator
        If Not ActivateRackLED() Then
            MsgBox("Unable to communicate with PLC")
            Exit Sub
        End If
        lbl_currcounter.Text = "0"
        LoadWOfrRFID.JobHeadCount = lbl_currcounter.Text
        Label5.Text = 0
        LoadWOfrRFID.JobUnitaryCount = Label5.Text
        lbl_currentref.Text = LoadWOfrRFID.JobProductMaterial
        lbl_wocounter.Text = LoadWOfrRFID.JobQTy
        UpdateStnStatus()
    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
        If Command1.Text = "Eye Open" Then
            Command1.Text = "Eye Close"
        ElseIf Command1.Text = "Eye Close" Then
            Command1.Text = "Eye Open"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Ethernet.BackColor = Color.
        Dim Headtest_count As Integer
        Headtest_count = frmModbus.bacaModbus(40112)
        lbl_currcounter.Text = Headtest_count 'head tester output
        If Val(lbl_currcounter.Text) >= Val(lbl_wocounter.Text) Then
            Txt_Msg.Text = "WO COMPLETED - STOP PROCESS"
            Txt_Msg.BackColor = Color.White
            Image1.Image = My.Resources.ResourceManager.GetObject("none")
        Else
            Dim Station_status As Long
            Dim Press_count As Integer

            TextBox2.Text = ""
            Station_status = frmModbus.bacaModbus(40101)
            Press_count = frmModbus.bacaModbus(40111)
            Label5.Text = Press_count

            Ethernet.BackColor = Color.Green
            TextBox2.Text = Station_status

            Select Case Station_status
                Case 0
                    Image1.Image = My.Resources.ResourceManager.GetObject("none")
                    lbl_msg.Text = "Please load the head on the cavity and push..."
                    Txt_Msg.Text = ""
                    Txt_Msg.BackColor = Color.White
                Case 1
                Case 2
                    Image1.Image = Nothing
                    lbl_msg.Text = ""
                    Txt_Msg.Text = "Testing in progress..."
                    Txt_Msg.BackColor = Color.Gray
                Case 3
                Case 4
                    Dim Test_result As Long
                    Test_result = frmModbus.bacaModbus(40102)
                    If Test_result = 1 Then
                        Image1.Image = My.Resources.ResourceManager.GetObject("PASS")
                        Image1.SizeMode = PictureBoxSizeMode.Zoom
                        LoadWOfrRFID.JobHeadCount = Label5.Text
                        LoadWOfrRFID.JobUnitaryCount = lbl_currcounter.Text
                        UpdateStnStatus()
                    Else
                        Image1.Image = My.Resources.ResourceManager.GetObject("FAIL")
                        Image1.SizeMode = PictureBoxSizeMode.Zoom
                        Dim FailType As Long
                        FailType = frmModbus.bacaModbus(40110)
                        Select Case FailType
                            Case 5
                                Txt_Msg.Text = "--> Right Key failure"
                            Case 6
                                Txt_Msg.Text = "--> Left Key failure"
                            Case 7
                                Txt_Msg.Text = "--> Full Key failure"
                            Case 8
                                Txt_Msg.Text = "--> Plunge no return failure"
                        End Select
                        Txt_Msg.BackColor = Color.Red
                    End If
                    If Not frmModbus.tulisModbus(40101, 10) Then
                        Txt_Msg.Text = "--> Unable to communicate with PLC - MW101"
                        Txt_Msg.BackColor = Color.Red
                    End If
                Case 10
                    Txt_Msg.Text = "Please unload product from cavity..."
            End Select
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim imageFileName = INISLIDEPATH & "\Slide" & SlideCount & ".JPG"
        PictureBox3.Image = Image.FromFile(imageFileName)
        SlideCount = SlideCount + 1
        If SlideCount = 52 Then SlideCount = 47
    End Sub

    Private Sub CMD_Read_Inputs_Click(sender As Object, e As EventArgs) Handles CMD_Read_Inputs.Click
        Call ZbrPrinter("123456001091100001")
    End Sub
    Private Function ZbrPrinter(SerialNos As String) As Boolean
        Dim FILENO As Integer
        Dim strCustFileName As String
        FILENO = FreeFile()
        On Error Resume Next

        '========= Zebra USB PORT ==========
        Dim lhPrinter As New System.IntPtr()
        Dim lReturn As Long
        Dim lpcWritten As Long
        Dim lDoc As Long
        Dim MyDocInfo As DOCINFO
        Dim sPrinterName As String

        sPrinterName = "Zebra TLP2844-Z"
        'lReturn = OpenPrinter(Printer.DeviceName, lhPrinter, 0)
        lReturn = ModuleZebraUSB.OpenPrinter(sPrinterName, lhPrinter, 0)
        If lReturn = 0 Then
            MsgBox("The Printer Name you typed wasn't recognised.")
            Exit Function
        End If
        MyDocInfo.pDocName = "Servo 3"
        MyDocInfo.pOutputFile = vbNullString
        MyDocInfo.pDatatype = vbNullString
        lDoc = ModuleZebraUSB.StartDocPrinter(lhPrinter, 1, MyDocInfo)
        Call ModuleZebraUSB.StartPagePrinter(lhPrinter)
        'sWrittendata = "^XA^FO370,60^A0,10,15^FD" & "1234567890" & "^FS^FO310,40^BXN,5,400^FD" & "12345" & "^FS^XZ"
        sWrittendata = "^XA^FO360,50^A0,15,15^FD" & SerialNos & "^FS^FO300,35^BXN,3,200^FD" & SerialNos & "^FS^XZ"
        'Call PrintPSN(sWrittendata)
        lReturn = ModuleZebraUSB.WritePrinter(lhPrinter, sWrittendata, Len(sWrittendata), lpcWritten)

        ' read data
        Dim sReadData As String
        Dim lpcRead As Long

        lReturn = ModuleZebraUSB.ReadPrinter(lhPrinter, sReadData, Len(sReadData), lpcRead)

        lReturn = ModuleZebraUSB.EndPagePrinter(lhPrinter)
        lReturn = ModuleZebraUSB.EndDocPrinter(lhPrinter)
        lReturn = ModuleZebraUSB.ClosePrinter(lhPrinter)
        '=======================================
    End Function
    Private Function LoadParameter(csmodel As String) As Boolean
        Dim query = "Select * FROM Parameter WHERE ModelName = '" & csmodel & "'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)
        On Error Resume Next

        LoadWOfrRFID.JobArticle = "" & dt.Rows(0).Item("ArticleNos")
        LoadWOfrRFID.JobModelFW = "" & dt.Rows(0).Item("ProductVer")
        LoadWOfrRFID.JobProductMaterial = "" & dt.Rows(0).Item("MaterialType")
        Return True
    End Function
    Private Function LoadParameter2PLC() As Boolean
        On Error GoTo ErrorHandler
        If LoadWOfrRFID.JobProductMaterial = "Zamak" Then
            If Not frmModbus.tulisModbus(40100, 1) Then
                Exit Function
            End If
        Else
            If Not frmModbus.tulisModbus(40100, 0) Then
                Exit Function
            End If
        End If
        Return True
        Exit Function
ErrorHandler:
        Return False
    End Function
    Dim Part As Rackconfig
    Private Function LoadRackMaterial() As Boolean
        Dim query = "Select * FROM RackMaterial WHERE MaterialList = 'SubAssy1'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)

        ReDim Part.PartPLCWord(30)
        ReDim Part.PartNos(30)

        For i As Integer = 1 To 30
            Part.PartNos(i) = dt.Rows(0).Item("Material" & i.ToString)
            Part.PartPLCWord(i) = 40200 + i
            'Console.WriteLine(Part.PartNos(i))
            'Console.WriteLine(Part.PartPLCWord(i))
        Next
        Return True
ErrorHandler:
        Return False
    End Function
    Dim JobModelMaterial As JobOrder
    Private Function LoadModelMaterial(Unitname As String) As Boolean
        On Error Resume Next
        Erase LoadWOfrRFID.JobModelMaterial

        ReDim JobModelMaterial.JobModelMaterial(30)
        Dim query = "Select * From Record Where MaterialType = '" & Unitname & "'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)
        Dim data As Integer
        For i As Integer = 1 To 15
            data = dt.Rows(0).Item("Flag" & i.ToString)
            'Console.WriteLine(data)
            If data = 1 Then
                JobModelMaterial.JobModelMaterial(i) = dt.Rows(0).Item("Part" & i.ToString)
            End If
        Next
        Return True
    End Function
    Private Function ActivateRackLED() As Boolean
        Dim i, N As Integer
        On Error GoTo ErrorHandler

        For i = 0 To 29
            If JobModelMaterial.JobModelMaterial(i) <> "" Then
                'Console.WriteLine(JobModelMaterial.JobModelMaterial(i))
                For N = 0 To 29
                    If JobModelMaterial.JobModelMaterial(i) = Part.PartNos(N) Then
                        'Console.WriteLine(Part.PartPLCWord(N))
                        If Not frmModbus.tulisModbus(Part.PartPLCWord(N), 1) Then
                            GoTo ErrorHandler
                        End If
                    End If
                Next
            End If
        Next
        Return True
ErrorHandler:
        Return False
    End Function
    Public Sub Reset_PLC()
        Call frmModbus.tulisModbus(40500, 1)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If Command1.Visible = False Then
            Command1.Visible = True
        Else
            Command1.Visible = False
        End If
    End Sub
End Class
