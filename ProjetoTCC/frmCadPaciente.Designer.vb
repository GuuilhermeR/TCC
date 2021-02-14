<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadPaciente))
        Me.lblNome = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtDtNasc = New System.Windows.Forms.TextBox()
        Me.lblDataNascimento = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(204, 67)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(85, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome Completo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 201)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(315, 64)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(328, 20)
        Me.txtNome.TabIndex = 2
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(315, 100)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(100, 20)
        Me.txtCPF.TabIndex = 4
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(204, 103)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 3
        Me.lblCPF.Text = "CPF:"
        '
        'txtDtNasc
        '
        Me.txtDtNasc.Location = New System.Drawing.Point(315, 136)
        Me.txtDtNasc.Name = "txtDtNasc"
        Me.txtDtNasc.Size = New System.Drawing.Size(100, 20)
        Me.txtDtNasc.TabIndex = 6
        '
        'lblDataNascimento
        '
        Me.lblDataNascimento.AutoSize = True
        Me.lblDataNascimento.Location = New System.Drawing.Point(204, 139)
        Me.lblDataNascimento.Name = "lblDataNascimento"
        Me.lblDataNascimento.Size = New System.Drawing.Size(105, 13)
        Me.lblDataNascimento.TabIndex = 5
        Me.lblDataNascimento.Text = "Data de nascimento:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(266, 239)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(460, 20)
        Me.txtEndereco.TabIndex = 8
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(204, 242)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 7
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(52, 289)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(315, 20)
        Me.txtBairro.TabIndex = 10
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(9, 292)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 9
        Me.lblBairro.Text = "Bairro:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(52, 239)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(124, 20)
        Me.txtCEP.TabIndex = 12
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(9, 242)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 11
        Me.lblCEP.Text = "CEP:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(438, 289)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(180, 20)
        Me.txtMunicipio.TabIndex = 14
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(375, 292)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(57, 13)
        Me.lblMunicipio.TabIndex = 13
        Me.lblMunicipio.Text = "Município:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(67, 375)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(180, 20)
        Me.TextBox8.TabIndex = 16
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(9, 378)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 15
        Me.lblTelefone.Text = "Telefone:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(323, 375)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(180, 20)
        Me.TextBox9.TabIndex = 18
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(275, 378)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 17
        Me.lblCelular.Text = "Celular:"
        '
        'txtUF
        '
        Me.txtUF.Location = New System.Drawing.Point(666, 289)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(60, 20)
        Me.txtUF.TabIndex = 20
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(636, 292)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 13)
        Me.lblUF.TabIndex = 19
        Me.lblUF.Text = "UF:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(92, 337)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(634, 20)
        Me.txtComplemento.TabIndex = 22
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(9, 340)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 13)
        Me.lblComplemento.TabIndex = 21
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(315, 171)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "E-mail:"
        '
        'frmCadPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 568)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.lblComplemento)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.lblUF)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.lblCEP)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.txtDtNasc)
        Me.Controls.Add(Me.lblDataNascimento)
        Me.Controls.Add(Me.txtCPF)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblNome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadPaciente"
        Me.Text = "Cadastro de Paciente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents txtDtNasc As TextBox
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents txtUF As TextBox
    Friend WithEvents lblUF As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
End Class
