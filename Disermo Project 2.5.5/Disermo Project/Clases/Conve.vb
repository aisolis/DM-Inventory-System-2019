Public Class Conve
    Public Property Cantidad As Double
    Public Function ConverDolares() As Double
        Return Cantidad * My.Settings.ConfigValorQuetzal
    End Function
End Class
