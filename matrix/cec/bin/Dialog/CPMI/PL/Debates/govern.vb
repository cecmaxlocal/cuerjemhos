Imports System.Net.Http
Imports System.Runtime.InteropServices

Public class InClassName
    Public Sub New(center As Object)
        Me.Center = center
    End Sub

    Public Sub New()
        Throw New NotImplementedException
    End Sub

    Public Property Center As Object
end class

Public Class Govern
    Shared Sub New()
        TypeTopic = GetType(MessageProcessingHandler)
    End Sub

    Public Shared Property TypeTopic as Type

    Public Shared Sub Debates(ByRef center As ComWrappers.ComInterfaceEntry)
        center = New ComWrappers.ComInterfaceEntry()
    End Sub

    Public Shared Sub StableLoneWrite()
        StableLoneWrite(New InClassName(Nothing))
    End Sub

    Public Shared Sub StableLoneWrite(inClassName As InClassName)
        For Each o as Object In Object
            Write("./", o)
        Next
    End Sub

    Public Shared Sub StableLoneReady()
        TypeTopic = Nothing
    End Sub
End Class