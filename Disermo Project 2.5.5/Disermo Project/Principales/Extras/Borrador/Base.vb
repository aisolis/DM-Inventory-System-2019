Public Class Base
    Dim vForm As New vForm '' se instancia a la clase
    Private Sub Base_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vForm.ventana = Me '' se indica el formulario que usara el efecto
        vForm.redondear() '' se redondean los bordes del formulario

    End Sub

    'Private m_hOriginalParent As Integer
    'Private Const GWL_HWNDPARENT As Integer = -8

    'Private Declare Function GetClassLong Lib "user32" Alias "GetClassLongA" (lngHandler As IntPtr, lngIndex As Integer) As Integer
    'Private Declare Function GetDesktopWindow Lib "user32" () As Integer
    'Private Declare Function SetClassLong Lib "user32" Alias "SetClassLongA" (lngHandler As IntPtr, lngIndex As Integer, lngNewClassLong As Integer) As Integer
    'Private Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer

    'Public Sub New()

    ' Esta llamada es exigida por el diseñador.
    'InitializeComponent()

    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '
    'Me.SuspendLayout()

    ' NO EJECUTAR LO SIGUIENTE EN EL EVENTO LOAD DEL FORMULARIO
    'Me.FormBorderStyle = FormBorderStyle.None

    'Const CS_DROPSHADOW As Integer = &H20000
    'Const GCL_STYLE As Integer = -26

    '   m_hOriginalParent = SetWindowLong(Me.Handle, GWL_HWNDPARENT, GetDesktopWindow())
    '  SetClassLong(Me.Handle, GCL_STYLE, GetClassLong(Me.Handle, GCL_STYLE) Or CS_DROPSHADOW)

    'Me.ResumeLayout(False)

    'End Sub

    Private Sub Base_MouseHover(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            vForm.moverForm() '' se llama la función que da el efecto
        End If
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        Me.WindowState = WindowState.Maximized

        If btnMax.Image Is My.Resources.BarRestaurar Then
            btnMax.Image = My.Resources.BarMaxmizar
        Else
            btnMax.Image = My.Resources.BarRestaurar
        End If

        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size

        'Me.Size = My.Computer.Screen.WorkingArea.Size
        'Me.Location = New System.Drawing.Point(0, 0)
        'Me.Location = New Point(0, 0)
        'Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = WindowState.Minimized
    End Sub
End Class