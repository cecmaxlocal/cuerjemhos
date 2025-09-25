Public Interface IHome
    
    Public Shared Sub Matrix(ParamArray connect)

    Public Property MatrixStream as Object()
    
    Sub Stream(ByRef home As CallType)
    
    Sub SendMessages(ParamArray files)
    

End Interface