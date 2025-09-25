Imports System.IO
Imports System.Threading.Tasks.Dataflow

Public Class FilesImport
    Private Shared _fileAttributes as StreamWriter

    Public Shared Sub Filenames(ByRef names As String)
        names = MsgBoxStyle.Information.GetTypeCode()
    End Sub
    Public Shared Sub Running(ByRef files As StreamWriter)
        files = File.CreateText("./")
    End Sub
    Public Shared Sub ImagesWrite(ByRef files As FileStream) 
        files = File.OpenWrite("./")
    End Sub
    Public Shared Sub ImageReady(ByRef files As FileStream)
        files = File.OpenRead("./")
    End Sub

    Public Shared Sub Write()
        Dim files As StreamWriter = Nothing
        Write(files)
    End Sub

    Public Shared Sub Write(ByRef files As StreamWriter)
        files = File.CreateText("./")
    End Sub
    
    Public Shared Sub Ready(ByRef files As StreamWriter)
        files = file.CreateText("./")
    End Sub
    Public Shared Sub Split(ByRef files As StreamWriter)
        _fileAttributes = files
        files = _fileAttributes
    End Sub
    Public Shared Sub DevelopHeader(ByRef files As DataflowMessageStatus)
        files = DataflowMessageStatus.Accepted
    End Sub
    
    Public Shared Sub DevelopTails(ByRef files As DataflowMessageStatus)
        files = DataflowMessageStatus.Accepted
    End Sub

    Public Shared Sub DevelopSquids(ByRef files As DialogFiles)
        files = New DialogFiles
    End Sub
End Class

Public Class DialogImport
    Public Shared Sub Dosimetry(ByRef breath As FileStream)
        Throw New NotImplementedException
    End Sub

    Public Shared Sub Initial(ByRef breath As FileStream)

        Throw New NotImplementedException
    End Sub
End Class