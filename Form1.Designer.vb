<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblMensaje = New Label()
        txtNumero = New TextBox()
        cmdIniciar = New Button()
        rtfSalida = New RichTextBox()
        cmdLimp = New Button()
        cmdCerrar = New Button()
        SuspendLayout()
        ' 
        ' lblMensaje
        ' 
        lblMensaje.AutoSize = True
        lblMensaje.Font = New Font("Dubai Medium", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblMensaje.Location = New Point(53, 77)
        lblMensaje.Name = "lblMensaje"
        lblMensaje.Size = New Size(157, 27)
        lblMensaje.TabIndex = 0
        lblMensaje.Text = "Escriba un numero:"
        ' 
        ' txtNumero
        ' 
        txtNumero.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtNumero.Location = New Point(217, 77)
        txtNumero.Name = "txtNumero"
        txtNumero.Size = New Size(100, 25)
        txtNumero.TabIndex = 1
        ' 
        ' cmdIniciar
        ' 
        cmdIniciar.BackColor = Color.PaleGreen
        cmdIniciar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        cmdIniciar.Location = New Point(235, 113)
        cmdIniciar.Name = "cmdIniciar"
        cmdIniciar.Size = New Size(72, 36)
        cmdIniciar.TabIndex = 2
        cmdIniciar.Text = "Iniciar"
        cmdIniciar.UseVisualStyleBackColor = False
        ' 
        ' rtfSalida
        ' 
        rtfSalida.Location = New Point(192, 155)
        rtfSalida.Name = "rtfSalida"
        rtfSalida.Size = New Size(152, 164)
        rtfSalida.TabIndex = 3
        rtfSalida.Text = ""
        ' 
        ' cmdLimp
        ' 
        cmdLimp.BackColor = Color.Red
        cmdLimp.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmdLimp.ForeColor = SystemColors.ButtonFace
        cmdLimp.Location = New Point(77, 290)
        cmdLimp.Name = "cmdLimp"
        cmdLimp.Size = New Size(80, 29)
        cmdLimp.TabIndex = 4
        cmdLimp.Text = "Limpiar"
        cmdLimp.UseVisualStyleBackColor = False
        ' 
        ' cmdCerrar
        ' 
        cmdCerrar.BackColor = Color.Red
        cmdCerrar.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        cmdCerrar.ForeColor = SystemColors.ButtonFace
        cmdCerrar.Location = New Point(264, 345)
        cmdCerrar.Name = "cmdCerrar"
        cmdCerrar.Size = New Size(80, 29)
        cmdCerrar.TabIndex = 5
        cmdCerrar.Text = "Salir"
        cmdCerrar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(503, 450)
        Controls.Add(cmdCerrar)
        Controls.Add(cmdLimp)
        Controls.Add(rtfSalida)
        Controls.Add(cmdIniciar)
        Controls.Add(txtNumero)
        Controls.Add(lblMensaje)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMensaje As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents cmdIniciar As Button
    Friend WithEvents rtfSalida As RichTextBox
    Friend WithEvents cmdLimp As Button
    Friend WithEvents cmdCerrar As Button
End Class
