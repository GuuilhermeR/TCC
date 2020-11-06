<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaLogin))
        Me.txtRecuperarSenha = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAvisoLoginIncorreto = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRecuperarSenha
        '
        Me.txtRecuperarSenha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecuperarSenha.AutoSize = True
        Me.txtRecuperarSenha.Location = New System.Drawing.Point(112, 335)
        Me.txtRecuperarSenha.Name = "txtRecuperarSenha"
        Me.txtRecuperarSenha.Size = New System.Drawing.Size(106, 13)
        Me.txtRecuperarSenha.TabIndex = 4
        Me.txtRecuperarSenha.TabStop = True
        Me.txtRecuperarSenha.Text = "Esqueci minha senha"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 207)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'lblAvisoLoginIncorreto
        '
        Me.lblAvisoLoginIncorreto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvisoLoginIncorreto.AutoSize = True
        Me.lblAvisoLoginIncorreto.ForeColor = System.Drawing.Color.Red
        Me.lblAvisoLoginIncorreto.Location = New System.Drawing.Point(112, 305)
        Me.lblAvisoLoginIncorreto.Name = "lblAvisoLoginIncorreto"
        Me.lblAvisoLoginIncorreto.Size = New System.Drawing.Size(123, 13)
        Me.lblAvisoLoginIncorreto.TabIndex = 2
        Me.lblAvisoLoginIncorreto.Text = "Usuário/Senha incorreto"
        Me.lblAvisoLoginIncorreto.Visible = False
        '
        'frmTelaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(357, 430)
        Me.Controls.Add(Me.lblAvisoLoginIncorreto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtRecuperarSenha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelaLogin"
        Me.Text = "Tela de Login"
        Me.Controls.SetChildIndex(Me.txtRecuperarSenha, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.lblAvisoLoginIncorreto, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRecuperarSenha As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblAvisoLoginIncorreto As Label
End Class
