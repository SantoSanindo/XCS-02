Module modGeneral
    Public Sub GetLastConfig()
        Dim Filenum As Integer
        Filenum = FreeFile()
        Dim tempcode As String
        Dim pos1, pos2, pos3, pos4, pos5 As Integer

        Console.WriteLine(INISTATUSPATH)
        FileOpen(Filenum, INISTATUSPATH, OpenMode.Input)

        tempcode = LineInput(Filenum)
        FileClose(Filenum)

        pos1 = InStr(1, tempcode, ",")
        pos2 = InStr(pos1 + 1, tempcode, ",")
        pos3 = InStr(pos2 + 1, tempcode, ",")
        pos4 = InStr(pos3 + 1, tempcode, ",")

        LoadWOfrRFID.JobProductMaterial = Mid(tempcode, 1, pos1 - 1)
        LoadWOfrRFID.JobQTy = Mid(tempcode, pos1 + 1, (pos2 - pos1) - 1)
        LoadWOfrRFID.JobHeadCount = Mid(tempcode, pos2 + 1, (pos3 - pos2) - 1)
        LoadWOfrRFID.JobUnitaryCount = Mid(tempcode, pos3 + 1)

        Console.WriteLine()
    End Sub
    Public Function UpdateStnStatus() As Boolean
        Dim Filenum1 As Integer
        Filenum1 = FreeFile()
        FileOpen(Filenum1, INISTATUSPATH, OpenMode.Output)
        PrintLine(Filenum1, LoadWOfrRFID.JobProductMaterial & "," & LoadWOfrRFID.JobQTy & "," & LoadWOfrRFID.JobHeadCount & "," & LoadWOfrRFID.JobUnitaryCount) 'check ini
        FileClose(Filenum1)
        Return True
    End Function
End Module
