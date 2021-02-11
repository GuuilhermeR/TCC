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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblCPF = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblDataNascimento = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.lblCEP = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.lblUF = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(170, 45)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(85, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome Completo:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 149)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(281, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(281, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'lblCPF
        '
        Me.lblCPF.AutoSize = True
        Me.lblCPF.Location = New System.Drawing.Point(170, 81)
        Me.lblCPF.Name = "lblCPF"
        Me.lblCPF.Size = New System.Drawing.Size(30, 13)
        Me.lblCPF.TabIndex = 3
        Me.lblCPF.Text = "CPF:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(281, 114)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'lblDataNascimento
        '
        Me.lblDataNascimento.AutoSize = True
        Me.lblDataNascimento.Location = New System.Drawing.Point(170, 117)
        Me.lblDataNascimento.Name = "lblDataNascimento"
        Me.lblDataNascimento.Size = New System.Drawing.Size(105, 13)
        Me.lblDataNascimento.TabIndex = 5
        Me.lblDataNascimento.Text = "Data de nascimento:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(266, 187)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(460, 20)
        Me.TextBox4.TabIndex = 8
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(204, 190)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 7
        Me.lblEndereco.Text = "Endereço:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(52, 237)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(265, 20)
        Me.TextBox5.TabIndex = 10
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(9, 240)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(37, 13)
        Me.lblBairro.TabIndex = 9
        Me.lblBairro.Text = "Bairro:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(52, 187)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(124, 20)
        Me.TextBox6.TabIndex = 12
        '
        'lblCEP
        '
        Me.lblCEP.AutoSize = True
        Me.lblCEP.Location = New System.Drawing.Point(9, 190)
        Me.lblCEP.Name = "lblCEP"
        Me.lblCEP.Size = New System.Drawing.Size(31, 13)
        Me.lblCEP.TabIndex = 11
        Me.lblCEP.Text = "CEP:"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(398, 237)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(180, 20)
        Me.TextBox7.TabIndex = 14
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(335, 240)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(57, 13)
        Me.lblMunicipio.TabIndex = 13
        Me.lblMunicipio.Text = "Município:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(67, 289)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(180, 20)
        Me.TextBox8.TabIndex = 16
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(9, 292)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefone.TabIndex = 15
        Me.lblTelefone.Text = "Telefone:"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(323, 292)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(180, 20)
        Me.TextBox9.TabIndex = 18
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(275, 295)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(42, 13)
        Me.lblCelular.TabIndex = 17
        Me.lblCelular.Text = "Celular:"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(666, 240)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(60, 20)
        Me.TextBox10.TabIndex = 20
        '
        'lblUF
        '
        Me.lblUF.AutoSize = True
        Me.lblUF.Location = New System.Drawing.Point(636, 243)
        Me.lblUF.Name = "lblUF"
        Me.lblUF.Size = New System.Drawing.Size(24, 13)
        Me.lblUF.TabIndex = 19
        Me.lblUF.Text = "UF:"
        '
        'frmCadPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 568)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.lblUF)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.lblCelular)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.lblCEP)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.lblDataNascimento)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lblCPF)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblCPF As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents lblDataNascimento As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents lblEndereco As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents lblCEP As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents lblTelefone As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents lblUF As Label
End Class
