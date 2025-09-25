Public Interface IFeelings
    Public Shared Sub Group(Optional stores)
    Stores = New StringComparison()
    Public Property StoresGroups as StringComparison
    Public property StarBucks as News 
End Interface

Public Class News
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class