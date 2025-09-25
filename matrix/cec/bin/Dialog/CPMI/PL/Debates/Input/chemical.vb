Imports System.IO
Imports System.Runtime.InteropServices

Public Class Chemical
    Private Shared _fileStream as FileStream

    Public Shared Sub CakeNetGaza (fileStream1 As FileStream, fileStream As FileStream)
        CakeNetGaza(fileStream, Nothing)
    End Sub

    Public Shared Sub CakeNetGazaSystem (fileStream As FileStream, <Out> ByRef onu As FileStream)
        _fileStream = fileStream
        onu = _fileStream
    End Sub
End Class