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
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lblUsuário = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLoginErrado = New System.Windows.Forms.Label()
        Me.pbxLogoGrande = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLogoGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(60, 230)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(243, 20)
        Me.txtLogin.TabIndex = 0
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(60, 292)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(243, 20)
        Me.txtSenha.TabIndex = 1
        '
        'lblUsuário
        '
        Me.lblUsuário.AutoSize = True
        Me.lblUsuário.Location = New System.Drawing.Point(154, 214)
        Me.lblUsuário.Name = "lblUsuário"
        Me.lblUsuário.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuário.TabIndex = 6
        Me.lblUsuário.Text = "Usuário"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(154, 276)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(38, 13)
        Me.lblSenha.TabIndex = 5
        Me.lblSenha.Text = "Senha"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(120, 358)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(108, 13)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Esqueci minha senha"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(123, 395)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(105, 32)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Entrar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblLoginErrado
        '
        Me.lblLoginErrado.AutoSize = True
        Me.lblLoginErrado.ForeColor = System.Drawing.Color.Red
        Me.lblLoginErrado.Location = New System.Drawing.Point(120, 339)
        Me.lblLoginErrado.Name = "lblLoginErrado"
        Me.lblLoginErrado.Size = New System.Drawing.Size(123, 13)
        Me.lblLoginErrado.TabIndex = 4
        Me.lblLoginErrado.Text = "Usuário/Senha incorreto"
        Me.lblLoginErrado.Visible = False
        '
        'pbxLogoGrande
        '
        Me.pbxLogoGrande.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.pbxLogoGrande.Location = New System.Drawing.Point(12, 12)
        Me.pbxLogoGrande.Name = "pbxLogoGrande"
        Me.pbxLogoGrande.Size = New System.Drawing.Size(343, 167)
        Me.pbxLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogoGrande.TabIndex = 7
        Me.pbxLogoGrande.TabStop = False
        '
        'frmTelaLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 439)
        Me.Controls.Add(Me.lblLoginErrado)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblUsuário)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.pbxLogoGrande)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelaLogin"
        Me.Text = "Login"
        CType(Me.pbxLogoGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxLogoGrande As PictureBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents lblUsuário As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblLoginErrado As Label
End Class
