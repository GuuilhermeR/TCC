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
        Me.tbPaciente = New System.Windows.Forms.TabControl()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.tbConsulta = New System.Windows.Forms.TabPage()
        Me.btnProcurarPaciente = New System.Windows.Forms.Button()
        Me.txtCodPaciente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.dtgConsultaPacientes = New System.Windows.Forms.DataGridView()
        Me.lblNomePaciente = New System.Windows.Forms.Label()
        Me.txtNomePaciente = New System.Windows.Forms.TextBox()
        Me.tbPaciente.SuspendLayout()
        Me.tbCadastro.SuspendLayout()
        Me.tbConsulta.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgConsultaPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPaciente
        '
        Me.tbPaciente.Controls.Add(Me.tbCadastro)
        Me.tbPaciente.Controls.Add(Me.tbConsulta)
        Me.tbPaciente.Location = New System.Drawing.Point(2, 3)
        Me.tbPaciente.Name = "tbPaciente"
        Me.tbPaciente.SelectedIndex = 0
        Me.tbPaciente.Size = New System.Drawing.Size(798, 517)
        Me.tbPaciente.TabIndex = 0
        '
        'tbCadastro
        '
        Me.tbCadastro.Controls.Add(Me.btnProcurarPaciente)
        Me.tbCadastro.Controls.Add(Me.txtCodPaciente)
        Me.tbCadastro.Controls.Add(Me.Label6)
        Me.tbCadastro.Controls.Add(Me.txtPeso)
        Me.tbCadastro.Controls.Add(Me.Label5)
        Me.tbCadastro.Controls.Add(Me.Label4)
        Me.tbCadastro.Controls.Add(Me.txtAltura)
        Me.tbCadastro.Controls.Add(Me.Label3)
        Me.tbCadastro.Controls.Add(Me.Label2)
        Me.tbCadastro.Controls.Add(Me.btnExcluir)
        Me.tbCadastro.Controls.Add(Me.btnSalvar)
        Me.tbCadastro.Controls.Add(Me.txtNumero)
        Me.tbCadastro.Controls.Add(Me.lblNum)
        Me.tbCadastro.Controls.Add(Me.txtEmail)
        Me.tbCadastro.Controls.Add(Me.Label1)
        Me.tbCadastro.Controls.Add(Me.txtComplemento)
        Me.tbCadastro.Controls.Add(Me.lblComplemento)
        Me.tbCadastro.Controls.Add(Me.txtUF)
        Me.tbCadastro.Controls.Add(Me.lblUF)
        Me.tbCadastro.Controls.Add(Me.txtCelular)
        Me.tbCadastro.Controls.Add(Me.lblCelular)
        Me.tbCadastro.Controls.Add(Me.txtTelefone)
        Me.tbCadastro.Controls.Add(Me.lblTelefone)
        Me.tbCadastro.Controls.Add(Me.txtMunicipio)
        Me.tbCadastro.Controls.Add(Me.lblMunicipio)
        Me.tbCadastro.Controls.Add(Me.txtCEP)
        Me.tbCadastro.Controls.Add(Me.lblCEP)
        Me.tbCadastro.Controls.Add(Me.txtBairro)
        Me.tbCadastro.Controls.Add(Me.lblBairro)
        Me.tbCadastro.Controls.Add(Me.txtEndereco)
        Me.tbCadastro.Controls.Add(Me.lblEndereco)
        Me.tbCadastro.Controls.Add(Me.txtDtNasc)
        Me.tbCadastro.Controls.Add(Me.lblDataNascimento)
        Me.tbCadastro.Controls.Add(Me.txtCPF)
        Me.tbCadastro.Controls.Add(Me.lblCPF)
        Me.tbCadastro.Controls.Add(Me.txtNome)
        Me.tbCadastro.Controls.Add(Me.PictureBox1)
        Me.tbCadastro.Controls.Add(Me.lblNome)
        Me.tbCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(790, 491)
        Me.tbCadastro.TabIndex = 0
        Me.tbCadastro.Text = "Cadastro"
        Me.tbCadastro.UseVisualStyleBackColor = True
        '
        'tbConsulta
        '
        Me.tbConsulta.Controls.Add(Me.txtNomePaciente)
        Me.tbConsulta.Controls.Add(Me.lblNomePaciente)
        Me.tbConsulta.Controls.Add(Me.dtgConsultaPacientes)
        Me.tbConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbConsulta.Size = New System.Drawing.Size(790, 491)
        Me.tbConsulta.TabIndex = 1
        Me.tbConsulta.Text = "Consulta"
        Me.tbConsulta.UseVisualStyleBackColor = True
        '
        'btnProcurarPaciente
        '
        Me.btnProcurarPaciente.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarPaciente.Location = New System.Drawing.Point(388, 13)
        Me.btnProcurarPaciente.Name = "btnProcurarPaciente"
        Me.btnProcurarPaciente.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarPaciente.TabIndex = 262
        Me.btnProcurarPaciente.UseVisualStyleBackColor = True
        '
        'txtCodPaciente
        '
        Me.txtCodPaciente.Enabled = False
        Me.txtCodPaciente.Location = New System.Drawing.Point(324, 15)
        Me.txtCodPaciente.Name = "txtCodPaciente"
        Me.txtCodPaciente.Size = New System.Drawing.Size(58, 20)
        Me.txtCodPaciente.TabIndex = 225
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(213, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 261
        Me.Label6.Text = "Código Paciente:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(253, 190)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(60, 20)
        Me.txtPeso.TabIndex = 230
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(471, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 260
        Me.Label5.Text = "cm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(319, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 259
        Me.Label4.Text = "Kg"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(405, 190)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(60, 20)
        Me.txtAltura.TabIndex = 231
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 258
        Me.Label3.Text = "Altura:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Peso:"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.ProjetoTCC.My.Resources.Resources.DeleteRed
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(695, 459)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(89, 30)
        Me.btnExcluir.TabIndex = 242
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(600, 459)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(89, 30)
        Me.btnSalvar.TabIndex = 241
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(675, 246)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(60, 20)
        Me.txtNumero.TabIndex = 234
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(645, 249)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(22, 13)
        Me.lblNum.TabIndex = 256
        Me.lblNum.Text = "Nº:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(324, 153)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 229
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "E-mail:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(101, 344)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(634, 20)
        Me.txtComplemento.TabIndex = 238
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Location = New System.Drawing.Point(18, 347)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(74, 13)
        Me.lblComplemento.TabIndex = 254
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(675, 296)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(60, 20)
        Me.txtUF.TabIndex = 237
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(645, 299)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 13)
        Me.lblUF.TabIndex = 253
        Me.lblUF.Text = "UF:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(332, 393)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(180, 20)
        Me.txtCelular.TabIndex = 240
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(284, 396)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 252
        Me.lblCelular.Text = "Celular:"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(76, 393)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(180, 20)
        Me.txtTelefone.TabIndex = 239
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(18, 396)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 251
        Me.lblTelefone.Text = "Telefone:"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Enabled = False
        Me.txtMunicipio.Location = New System.Drawing.Point(447, 296)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(180, 20)
        Me.txtMunicipio.TabIndex = 236
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(384, 299)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(57, 13)
        Me.lblMunicipio.TabIndex = 250
        Me.lblMunicipio.Text = "Município:"
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(61, 246)
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(124, 20)
        Me.txtCEP.TabIndex = 232
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(18, 249)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 249
        Me.lblCEP.Text = "CEP:"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(61, 296)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(315, 20)
        Me.txtBairro.TabIndex = 235
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(18, 299)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 248
        Me.lblBairro.Text = "Bairro:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(275, 246)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(352, 20)
        Me.txtEndereco.TabIndex = 233
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(213, 249)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 247
        Me.lblEndereco.Text = "Endereço:"
        '
        'txtDtNasc
        '
        Me.txtDtNasc.Location = New System.Drawing.Point(324, 118)
        Me.txtDtNasc.Name = "txtDtNasc"
        Me.txtDtNasc.Size = New System.Drawing.Size(100, 20)
        Me.txtDtNasc.TabIndex = 228
        '
        'lblDataNascimento
        '
        Me.lblDataNascimento.AutoSize = True
        Me.lblDataNascimento.Location = New System.Drawing.Point(213, 121)
        Me.lblDataNascimento.Name = "lblDataNascimento"
        Me.lblDataNascimento.Size = New System.Drawing.Size(105, 13)
        Me.lblDataNascimento.TabIndex = 246
        Me.lblDataNascimento.Text = "Data de nascimento:"
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(324, 82)
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(100, 20)
        Me.txtCPF.TabIndex = 227
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(213, 85)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 245
        Me.lblCPF.Text = "CPF:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(324, 46)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(328, 20)
        Me.txtNome.TabIndex = 226
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjetoTCC.My.Resources.Resources.default_user
        Me.PictureBox1.Location = New System.Drawing.Point(7, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(195, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 244
        Me.PictureBox1.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(213, 49)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(85, 13)
        Me.lblNome.TabIndex = 243
        Me.lblNome.Text = "Nome Completo:"
        '
        'dtgConsultaPacientes
        '
        Me.dtgConsultaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultaPacientes.Location = New System.Drawing.Point(6, 38)
        Me.dtgConsultaPacientes.Name = "dtgConsultaPacientes"
        Me.dtgConsultaPacientes.Size = New System.Drawing.Size(777, 452)
        Me.dtgConsultaPacientes.TabIndex = 0
        '
        'lblNomePaciente
        '
        Me.lblNomePaciente.AutoSize = True
        Me.lblNomePaciente.Location = New System.Drawing.Point(6, 15)
        Me.lblNomePaciente.Name = "lblNomePaciente"
        Me.lblNomePaciente.Size = New System.Drawing.Size(38, 13)
        Me.lblNomePaciente.TabIndex = 1
        Me.lblNomePaciente.Text = "Nome:"
        '
        'txtNomePaciente
        '
        Me.txtNomePaciente.Location = New System.Drawing.Point(50, 12)
        Me.txtNomePaciente.Name = "txtNomePaciente"
        Me.txtNomePaciente.Size = New System.Drawing.Size(734, 20)
        Me.txtNomePaciente.TabIndex = 2
        '
        'frmPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 523)
        Me.Controls.Add(Me.tbPaciente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPaciente"
        Me.Text = "Pacientes"
        Me.tbPaciente.ResumeLayout(False)
        Me.tbCadastro.ResumeLayout(False)
        Me.tbCadastro.PerformLayout()
        Me.tbConsulta.ResumeLayout(False)
        Me.tbConsulta.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgConsultaPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbPaciente As TabControl
    Friend WithEvents tbCadastro As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents btnProcurarPaciente As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents txtCodPaciente As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExcluir As Button
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents lblNum As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtUF As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents lblUF As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCEP As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDtNasc As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCPF As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNome As Label
    Friend WithEvents tbConsulta As TabPage
    Friend WithEvents dtgConsultaPacientes As DataGridView
    Friend WithEvents txtNomePaciente As TextBox
    Friend WithEvents lblNomePaciente As Label
End Class
