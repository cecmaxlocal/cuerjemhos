Imports System.Runtime.CompilerServices

Public Class Values
    Public Shared Sub Track(ByRef debates As CallerMemberNameAttribute)
        debates = New CallerMemberNameAttribute()
    End Sub
End Class