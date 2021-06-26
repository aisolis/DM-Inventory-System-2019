Imports System.Data.SqlClient

Public Class Antiguedad_de_saldos
    Dim CONEXION As New SqlConnection(My.Settings.conexionglobal)
    Dim mensaje, sentencia As String

    Sub ejecutarSQL(sql As String, msg As String)
        Try
            Dim cmd As New SqlCommand(sql, CONEXION)
            CONEXION.Open()
            cmd.ExecuteNonQuery()
            CONEXION.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Antiguedad_de_saldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class