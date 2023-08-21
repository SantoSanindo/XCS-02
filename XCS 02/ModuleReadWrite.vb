Option Explicit On
Module ModuleReadWrite
    Public INISTATUSPATH As String 'PATH TO SERVER\FRIDGE .
    Public INIPSNFOLDERPATH As String 'Path to the PSN.Txt .
    Public INITEMPPATH As String '.
    Public INISLIDEPATH As String '.

    Dim Fnum As Integer
    Dim LineStr As String
    Public Sub ReadINI(Filename As String)
        Dim ItemStr As String
        Dim SectionHeading As String
        Dim pos As Integer

        Fnum = FreeFile()

        FileOpen(Fnum, My.Application.Info.DirectoryPath & "\Config.ini", OpenMode.Input)

        Do While Not EOF(Fnum)
            LineStr = LineInput(Fnum)
            If Left(LineStr, 1) = "[" Then
                SectionHeading = Mid(LineStr, 2, Len(LineStr) - 2)
            Else
                If InStr(LineStr, "=") > 0 Then
                    pos = InStr(LineStr, "=")
                    ItemStr = Left$(LineStr, pos - 1)

                    Select Case UCase(SectionHeading)
                        Case "PSN FOLDER PATH" 'Share FILE
                            Select Case UCase(ItemStr)
                                Case "PATH" : INIPSNFOLDERPATH = Mid$(LineStr, pos + 1)
                            End Select

                        Case "TEMP PATH" 'LOCAL DIR
                            Select Case UCase(ItemStr)
                                Case "PATH" : INITEMPPATH = Mid$(LineStr, pos + 1)
                            End Select

                        Case "SLIDE PATH"
                            Select Case UCase(ItemStr)
                                Case "PATH" : INISLIDEPATH = Mid$(LineStr, pos + 1)
                            End Select

                        Case "STATUS PATH"
                            Select Case UCase(ItemStr)
                                Case "PATH" : INISTATUSPATH = Mid$(LineStr, pos + 1)
                            End Select
                    End Select
                End If
            End If
        Loop
        FileClose(Fnum)
    End Sub
    Public Function LOADPSNFILE(ProductPSN As String) As Boolean
        Dim ItemStr As String
        Dim SectionHeading As String
        Dim pos1, pos2, pos3 As Integer

        Fnum = FreeFile()

        If Dir(INIPSNFOLDERPATH & ProductPSN & ".Txt") = "" Then
            'SetDefaultINIValues
            'WriteINI
            Return False
            Exit Function
        End If

        FileOpen(Fnum, INIPSNFOLDERPATH & ProductPSN & ".txt", OpenMode.Input)
        Do While Not EOF(Fnum)
            LineStr = LineInput(Fnum)
            'Check for Section heading
            If InStr(LineStr, "[") > 0 And InStr(LineStr, "]") > 0 Then
                pos1 = InStr(LineStr, "[")
                pos2 = InStr(LineStr, "]")
                pos3 = InStr(LineStr, ":")

                SectionHeading = Mid(LineStr, pos1 + 1, pos2 - pos1 - 1)

                Select Case UCase(SectionHeading)
                    Case "MODEL"
                        PSNFileInfo.ModelName = Trim(Mid(LineStr, pos3 + 1))

                    Case "DATE CREATED"
                        PSNFileInfo.DateCreated = Trim(Mid(LineStr, pos3 + 1))

                    Case "DATE COMPLETED"
                        PSNFileInfo.DateCompleted = Trim(Mid(LineStr, pos3 + 1))

                    Case "OPERATOR ID"
                        PSNFileInfo.OperatorID = Trim(Mid(LineStr, pos3 + 1))

                    Case "WORK ORDER NO"
                        PSNFileInfo.WONos = Trim(Mid(LineStr, pos3 + 1))

                    Case "MAIN PCBA S/N"
                        PSNFileInfo.MainPCBA = Trim(Mid(LineStr, pos3 + 1))

                    Case "SECONDARY PCBA S/N"
                        PSNFileInfo.SecondaryPCBA = Trim(Mid(LineStr, pos3 + 1))

                    Case "ELECTROMAGNET S/N"
                        PSNFileInfo.ElectroMagnet = Trim(Mid(LineStr, pos3 + 1))

                    Case "PSN"
                        PSNFileInfo.PSN = Trim(Mid(LineStr, pos3 + 1))

                    Case "SCREWING STATION CHECK IN DATE"
                        PSNFileInfo.ScrewStnCheckIn = Trim(Mid(LineStr, pos3 + 1))

                    Case "SCREWING STATION CHECK OUT DATE"
                        PSNFileInfo.ScrewStnCheckOut = Trim(Mid(LineStr, pos3 + 1))

                    Case "SCREWING STATION STATUS"
                        PSNFileInfo.ScrewStnStatus = Trim(Mid(LineStr, pos3 + 1))

                    Case "FINAL TEST CHECK IN DATE"
                        PSNFileInfo.FTCheckIn = Trim(Mid(LineStr, pos3 + 1))

                    Case "FINAL TEST CHECK OUT DATE"
                        PSNFileInfo.FTCheckOut = Trim(Mid(LineStr, pos3 + 1))

                    Case "FINAL TEST STATUS"
                        PSNFileInfo.FTStatus = Trim(Mid(LineStr, pos3 + 1))

                    Case "STATION 5 CHECK IN DATE"
                        PSNFileInfo.Stn5CheckIn = Trim(Mid(LineStr, pos3 + 1))

                    Case "STATION 5 CHECK OUT DATE"
                        PSNFileInfo.Stn5CheckOut = Trim(Mid(LineStr, pos3 + 1))

                    Case "STATION 5 STATUS"
                        PSNFileInfo.Stn5Status = Trim(Mid(LineStr, pos3 + 1))

                    Case "PACKAGING CHECK IN DATE"
                        PSNFileInfo.PackagingCheckIn = Trim(Mid(LineStr, pos3 + 1))

                    Case "PACKAGING CHECK OUT DATE"
                        PSNFileInfo.PackagingCheckOut = Trim(Mid(LineStr, pos3 + 1))

                    Case "PACKAGING STATUS"
                        PSNFileInfo.PackagingStatus = Trim(Mid(LineStr, pos3 + 1))

                    Case "DEBUG STATION #10 STATUS"
                        PSNFileInfo.DebugStatus = Trim(Mid(LineStr, pos3 + 1))

                    Case "DEBUG COMMENTS"
                        PSNFileInfo.DebugComment = Trim(Mid(LineStr, pos3 + 1))

                    Case "DEBUG TECHNICIANS ID"
                        PSNFileInfo.DebugTechnican = Trim(Mid(LineStr, pos3 + 1))

                    Case "DEBUG DATE REPAIRED"
                        PSNFileInfo.RepairDate = Trim(Mid(LineStr, pos3 + 1))

                End Select
            End If
        Loop
        FileClose(Fnum)
    End Function
    'Write data to PSN file
    Public Function WRITEPSNFILE(ProductPSN As String) As Boolean
        On Error GoTo ErrorHandler
        Fnum = FreeFile()
        FileOpen(Fnum, INIPSNFOLDERPATH & ProductPSN & ".txt", OpenMode.Output)

        PrintLine(Fnum)
        PrintLine(Fnum, "[MODEL] : " & PSNFileInfo.ModelName)
        PrintLine(Fnum)
        PrintLine(Fnum, "[DATE CREATED] : " & PSNFileInfo.DateCreated)
        PrintLine(Fnum)
        PrintLine(Fnum, "[DATE COMPLETED] : " & PSNFileInfo.DateCompleted)
        PrintLine(Fnum)
        PrintLine(Fnum, "[OPERATOR ID] : " & PSNFileInfo.OperatorID)
        PrintLine(Fnum)
        PrintLine(Fnum, "[WORK ORDER NO] : " & PSNFileInfo.WONos)
        PrintLine(Fnum)
        PrintLine(Fnum, "[MAIN PCBA S/N] : " & PSNFileInfo.MainPCBA)
        PrintLine(Fnum)
        PrintLine(Fnum, "[SECONDARY PCBA S/N] : " & PSNFileInfo.SecondaryPCBA)
        PrintLine(Fnum)
        PrintLine(Fnum, "[ELECTROMAGNET S/N] : " & PSNFileInfo.ElectroMagnet)
        PrintLine(Fnum)
        PrintLine(Fnum, "[PSN] : " & PSNFileInfo.PSN)
        PrintLine(Fnum)
        PrintLine(Fnum, "[SCREWING STATION CHECK IN DATE] : " & PSNFileInfo.ScrewStnCheckIn)
        PrintLine(Fnum)
        PrintLine(Fnum, "[SCREWING STATION CHECK OUT DATE] : " & PSNFileInfo.ScrewStnCheckOut)
        PrintLine(Fnum)
        PrintLine(Fnum, "[SCREWING STATION STATUS] : " & PSNFileInfo.ScrewStnStatus)
        PrintLine(Fnum)
        PrintLine(Fnum, "[FINAL TEST CHECK IN DATE] : " & PSNFileInfo.FTCheckIn)
        PrintLine(Fnum)
        PrintLine(Fnum, "[FINAL TEST CHECK OUT DATE] : " & PSNFileInfo.FTCheckOut)
        PrintLine(Fnum)
        PrintLine(Fnum, "[FINAL TEST STATUS] : " & PSNFileInfo.FTStatus)
        PrintLine(Fnum)
        PrintLine(Fnum, "[STATION 5 CHECK IN DATE] : " & PSNFileInfo.Stn5CheckIn)
        PrintLine(Fnum)
        PrintLine(Fnum, "[STATION 5 CHECK OUT DATE] : " & PSNFileInfo.Stn5CheckOut)
        PrintLine(Fnum)
        PrintLine(Fnum, "[STATION 5 STATUS] : " & PSNFileInfo.Stn5Status)
        PrintLine(Fnum)
        PrintLine(Fnum, "[PACKAGING CHECK IN DATE] : " & PSNFileInfo.PackagingCheckIn)
        PrintLine(Fnum)
        PrintLine(Fnum, "[PACKAGING CHECK OUT DATE] : " & PSNFileInfo.PackagingCheckOut)
        PrintLine(Fnum)
        PrintLine(Fnum, "[PACKAGING STATUS] : " & PSNFileInfo.PackagingStatus)
        PrintLine(Fnum)
        PrintLine(Fnum, "[DEBUG STATION #10 STATUS] : " & PSNFileInfo.DebugStatus)
        PrintLine(Fnum)
        PrintLine(Fnum, "[DEBUG COMMENTS] : " & PSNFileInfo.DebugComment)
        PrintLine(Fnum)
        PrintLine(Fnum, "[DEBUG TECHNICIANS ID] : " & PSNFileInfo.DebugTechnican)
        PrintLine(Fnum)
        PrintLine(Fnum, "[DEBUG DATE REPAIRED] : " & PSNFileInfo.RepairDate)
        FileClose(Fnum)
        Return True
ErrorHandler:
    End Function
End Module
