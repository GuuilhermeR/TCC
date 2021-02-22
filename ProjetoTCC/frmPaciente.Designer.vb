<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaciente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaciente))
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.txtCEP = New System.Windows.Forms.TextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.txtDtNasc = New System.Windows.Forms.TextBox()
        Me.lblDataNascimento = New System.Windows.Forms.Label()
        Me.txtCPF = New System.Windows.Forms.TextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProcurarPaciente = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(258, 207)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(60, 20)
        Me.txtPeso.TabIndex = 146
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(476, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "cm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Kg"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(410, 207)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(60, 20)
        Me.txtAltura.TabIndex = 143
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Altura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 141
        Me.Label2.Text = "Peso:"
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(680, 263)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(60, 20)
        Me.txtNumero.TabIndex = 138
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(650, 266)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(22, 13)
        Me.lblNum.TabIndex = 137
        Me.lblNum.Text = "Nº:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(329, 170)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 136
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "E-mail:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(106, 361)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(634, 20)
        Me.txtComplemento.TabIndex = 134
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(23, 364)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 13)
        Me.lblComplemento.TabIndex = 133
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(680, 313)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(60, 20)
        Me.txtUF.TabIndex = 132
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(650, 316)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 13)
        Me.lblUF.TabIndex = 131
        Me.lblUF.Text = "UF:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(337, 410)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(180, 20)
        Me.TextBox9.TabIndex = 130
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(289, 413)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 129
        Me.lblCelular.Text = "Celular:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(81, 410)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(180, 20)
        Me.TextBox8.TabIndex = 128
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(23, 413)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 127
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Enabled = False
        Me.txtMunicipio.Location = New System.Drawing.Point(452, 313)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(180, 20)
        Me.txtMunicipio.TabIndex = 126
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(389, 316)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(57, 13)
        Me.lblMunicipio.TabIndex = 125
        Me.lblMunicipio.Text = "Município:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(66, 263)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(124, 20)
        Me.txtCEP.TabIndex = 124
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(23, 266)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 123
        Me.lblCEP.Text = "CEP:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(66, 313)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(315, 20)
        Me.txtBairro.TabIndex = 122
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(23, 316)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 121
        Me.lblBairro.Text = "Bairro:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(280, 263)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(352, 20)
        Me.txtEndereco.TabIndex = 120
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(218, 266)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 119
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtDtNasc
        '
        Me.txtDtNasc.Location = New System.Drawing.Point(329, 135)
        Me.txtDtNasc.Name = "txtDtNasc"
        Me.txtDtNasc.Size = New System.Drawing.Size(100, 20)
        Me.txtDtNasc.TabIndex = 118
        '
        'lblDataNascimento
        '
        Me.lblDataNascimento.AutoSize = True
        Me.lblDataNascimento.Location = New System.Drawing.Point(218, 138)
        Me.lblDataNascimento.Name = "lblDataNascimento"
        Me.lblDataNascimento.Size = New System.Drawing.Size(105, 13)
        Me.lblDataNascimento.TabIndex = 117
        Me.lblDataNascimento.Text = "Data de nascimento:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(329, 99)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(100, 20)
        Me.txtCPF.TabIndex = 116
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(218, 102)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 115
        Me.lblCPF.Text = "CPF:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(329, 63)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(328, 20)
        Me.txtNome.TabIndex = 114
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(218, 66)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(85, 13)
        Me.lblNome.TabIndex = 112
        Me.lblNome.Text = "Nome Completo:"
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(329, 32)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(58, 20)
        Me.txtCodPaciente.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "Código Paciente:"
        '
        'btnProcurarPaciente
        '
        Me.btnProcurarPaciente.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarPaciente.Location = New System.Drawing.Point(393, 30)
        Me.btnProcurarPaciente.Name = "btnProcurarPaciente"
        Me.btnProcurarPaciente.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarPaciente.TabIndex = 151
        Me.btnProcurarPaciente.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.ProjetoTCC.My.Resources.Resources.DeleteRed
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(700, 481)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(89, 30)
        Me.btnExcluir.TabIndex = 140
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(605, 481)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(89, 30)
        Me.btnSalvar.TabIndex = 139
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoTCC.My.Resources.Resources.default_user
        Me.PictureBox1.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 523)
        Me.Controls.Add(Me.btnProcurarPaciente)
        Me.Controls.Add(Me.txtCodPaciente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNum)
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
        Me.Name = "frmPaciente"
        Me.Text = "Pacientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNum As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtUF As TextBox
    Friend WithEvents lblUF As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents txtDtNasc As TextBox
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNome As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnProcurarPaciente As Button
    Friend WithEvents txtCodPaciente As TextBox
    Friend WithEvents Label6 As Label
End Class
