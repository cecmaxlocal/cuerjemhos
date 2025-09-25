Public Class TaxRates
    Private Shared _market as StringComparison

    Public Shared Sub Rates ()
        Rates()
    End Sub

    Public Shared Sub RatesPlans ()
        _market = StringComparison.CurrentCulture

        _market = New StringComparison()
    End Sub
End Class