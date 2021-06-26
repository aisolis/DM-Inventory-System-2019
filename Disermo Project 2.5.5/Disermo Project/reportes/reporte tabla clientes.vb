
Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports System.Data.SqlClient
Public Class reporte_tabla_clientes
    Dim con As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim cmd As New SqlClient.SqlCommand
    Dim da As New SqlClient.SqlDataAdapter
    Dim ds As New clientesdataset
    Dim rpt As New clientesreporte
    Private Sub Reporte_tabla_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ds.Clear()
            con.ConnectionString = My.Settings.conexionglobal
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from tabla_clientes"
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds, "tabla_clientes")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("algo ah salido mal " & ex.Message)
        End Try
    End Sub
End Class