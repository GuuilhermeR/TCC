<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaLogin
    Inherits MvtWindowsForms.MvtForm

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
        Me.txtUsuario = New MvtWindowsForms.TextBoxStringWithLabel()
        Me.txtSenha = New MvtWindowsForms.TextBoxStringWithLabel()
        Me.txtRecuperarSenha = New System.Windows.Forms.LinkLabel()
        Me.btnLogar = New MvtWindowsForms.ButtonSave()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = True
        Me.txtUsuario.Conexao = Nothing
        Me.txtUsuario.ConnectionString = Nothing
        Me.txtUsuario.FieldFilter = Nothing
        Me.txtUsuario.FieldFind = Nothing
        Me.txtUsuario.FieldReturn = Nothing
        Me.txtUsuario.KeepValue = False
        Me.txtUsuario.LCaseText = False
        Me.txtUsuario.Location = New System.Drawing.Point(22, 242)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.NameExibition = "Usuário:"
        Me.txtUsuario.OrderManual = Nothing
        Me.txtUsuario.OthersFilters = Nothing
        Me.txtUsuario.Size = New System.Drawing.Size(308, 24)
        Me.txtUsuario.SizeTextBox = 200
        Me.txtUsuario.SQLSelectFind = Nothing
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUsuario.ToolTipHelp = Nothing
        Me.txtUsuario.UCaseFirstCharText = False
        Me.txtUsuario.UCaseText = False
        Me.txtUsuario.UseF3 = False
        Me.txtUsuario.ValueReturn = Nothing
        Me.txtUsuario.ZIniciar = True
        '
        'txtSenha
        '
        Me.txtSenha.AutoSize = True
        Me.txtSenha.Conexao = Nothing
        Me.txtSenha.ConnectionString = Nothing
        Me.txtSenha.FieldFilter = Nothing
        Me.txtSenha.FieldFind = Nothing
        Me.txtSenha.FieldReturn = Nothing
        Me.txtSenha.KeepValue = False
        Me.txtSenha.LCaseText = False
        Me.txtSenha.Location = New System.Drawing.Point(22, 278)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.NameExibition = "Senha:"
        Me.txtSenha.OrderManual = Nothing
        Me.txtSenha.OthersFilters = Nothing
        Me.txtSenha.Size = New System.Drawing.Size(308, 24)
        Me.txtSenha.SizeTextBox = 200
        Me.txtSenha.SQLSelectFind = Nothing
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSenha.ToolTipHelp = Nothing
        Me.txtSenha.UCaseFirstCharText = False
        Me.txtSenha.UCaseText = False
        Me.txtSenha.UseF3 = False
        Me.txtSenha.ValueReturn = Nothing
        Me.txtSenha.ZIniciar = True
        '
        'txtRecuperarSenha
        '
        Me.txtRecuperarSenha.AutoSize = True
        Me.txtRecuperarSenha.Location = New System.Drawing.Point(109, 318)
        Me.txtRecuperarSenha.Name = "txtRecuperarSenha"
        Me.txtRecuperarSenha.Size = New System.Drawing.Size(106, 13)
        Me.txtRecuperarSenha.TabIndex = 4
        Me.txtRecuperarSenha.TabStop = True
        Me.txtRecuperarSenha.Text = "Esqueci minha senha"
        '
        'btnLogar
        '
        Me.btnLogar.Image = CType(resources.GetObject("btnLogar.Image"), System.Drawing.Image)
        Me.btnLogar.Location = New System.Drawing.Point(112, 366)
        Me.btnLogar.Name = "btnLogar"
        Me.btnLogar.Size = New System.Drawing.Size(100, 31)
        Me.btnLogar.TabIndex = 5
        Me.btnLogar.Text = "Entrar"
        Me.btnLogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogar.ToolTipHelp = Nothing
        Me.btnLogar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(22, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 224)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmTelaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(358, 447)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogar)
        Me.Controls.Add(Me.txtRecuperarSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelaLogin"
        Me.Text = "Tela de Login"
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtSenha, 0)
        Me.Controls.SetChildIndex(Me.txtRecuperarSenha, 0)
        Me.Controls.SetChildIndex(Me.btnLogar, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As MvtWindowsForms.TextBoxStringWithLabel
    Friend WithEvents txtSenha As MvtWindowsForms.TextBoxStringWithLabel
    Friend WithEvents txtRecuperarSenha As LinkLabel
    Friend WithEvents btnLogar As MvtWindowsForms.ButtonSave
    Friend WithEvents PictureBox1 As PictureBox
End Class
