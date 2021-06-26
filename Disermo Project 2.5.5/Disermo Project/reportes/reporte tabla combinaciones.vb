Imports CrystalDecisions.CrystalReports.Engine.ReportDocument
Imports System.Data.SqlClient
Public Class reporte_tabla_combinaciones
    Dim con As New SqlClient.SqlConnection
    Dim dt As New DataTable
    Dim cmd As New SqlClient.SqlCommand
    Dim da As New SqlClient.SqlDataAdapter
    Dim ds As New clientesdataset
    Dim rpt As New Combinaciones
    Private Sub Reporte_tabla_combinaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ds.Clear()
            con.ConnectionString = My.Settings.conexionglobal
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select * from combinaciones"
            cmd.CommandType = CommandType.Text
            da.SelectCommand = cmd
            da.Fill(ds, "combinaciones")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
        Catch ex As Exception
            MsgBox("algo ah salido mal " & ex.Message)
        End Try
    End Sub
End Class