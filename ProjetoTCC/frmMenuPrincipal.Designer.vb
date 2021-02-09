<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.pnlBotoes = New System.Windows.Forms.Panel()
        Me.btnDeslogar = New System.Windows.Forms.Button()
        Me.btnFinanceiro = New System.Windows.Forms.Button()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnOcultar = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnCadastrarPaciente = New System.Windows.Forms.Button()
        Me.btnConsultarAlimentos = New System.Windows.Forms.Button()
        Me.btnCadastrarAlimento = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.btnCadastroCardapio = New System.Windows.Forms.Button()
        Me.pnlLogo = New System.Windows.Forms.PictureBox()
        Me.pbxLogoGrande = New System.Windows.Forms.PictureBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.lblNomeApp = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.pnlBotoes.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxLogoGrande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlBotoes
        '
        Me.pnlBotoes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlBotoes.BackColor = System.Drawing.Color.SpringGreen
        Me.pnlBotoes.Controls.Add(Me.btnDeslogar)
        Me.pnlBotoes.Controls.Add(Me.btnFinanceiro)
        Me.pnlBotoes.Controls.Add(Me.btnAgenda)
        Me.pnlBotoes.Controls.Add(Me.btnOcultar)
        Me.pnlBotoes.Controls.Add(Me.btnConfig)
        Me.pnlBotoes.Controls.Add(Me.btnCadastrarPaciente)
        Me.pnlBotoes.Controls.Add(Me.btnConsultarAlimentos)
        Me.pnlBotoes.Controls.Add(Me.btnCadastrarAlimento)
        Me.pnlBotoes.Controls.Add(Me.pbLogo)
        Me.pnlBotoes.Controls.Add(Me.btnCadastroCardapio)
        Me.pnlBotoes.Controls.Add(Me.pnlLogo)
        Me.pnlBotoes.Location = New System.Drawing.Point(6, 5)
        Me.pnlBotoes.Name = "pnlBotoes"
        Me.pnlBotoes.Size = New System.Drawing.Size(234, 616)
        Me.pnlBotoes.TabIndex = 5
        '
        'btnDeslogar
        '
        Me.btnDeslogar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnDeslogar.FlatAppearance.BorderSize = 0
        Me.btnDeslogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeslogar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeslogar.ForeColor = System.Drawing.Color.Black
        Me.btnDeslogar.Location = New System.Drawing.Point(12, 566)
        Me.btnDeslogar.Name = "btnDeslogar"
        Me.btnDeslogar.Size = New System.Drawing.Size(208, 41)
        Me.btnDeslogar.TabIndex = 10
        Me.btnDeslogar.Text = "Sair e fechar"
        Me.btnDeslogar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeslogar.UseVisualStyleBackColor = False
        '
        'btnFinanceiro
        '
        Me.btnFinanceiro.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnFinanceiro.FlatAppearance.BorderSize = 0
        Me.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinanceiro.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinanceiro.ForeColor = System.Drawing.Color.Black
        Me.btnFinanceiro.Location = New System.Drawing.Point(12, 377)
        Me.btnFinanceiro.Name = "btnFinanceiro"
        Me.btnFinanceiro.Size = New System.Drawing.Size(208, 41)
        Me.btnFinanceiro.TabIndex = 9
        Me.btnFinanceiro.Text = "Financeiro"
        Me.btnFinanceiro.UseVisualStyleBackColor = False
        '
        'btnAgenda
        '
        Me.btnAgenda.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnAgenda.FlatAppearance.BorderSize = 0
        Me.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgenda.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenda.ForeColor = System.Drawing.Color.Black
        Me.btnAgenda.Location = New System.Drawing.Point(12, 330)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(208, 41)
        Me.btnAgenda.TabIndex = 8
        Me.btnAgenda.Text = "Agenda"
        Me.btnAgenda.UseVisualStyleBackColor = False
        '
        'btnOcultar
        '
        Me.btnOcultar.BackColor = System.Drawing.Color.Transparent
        Me.btnOcultar.FlatAppearance.BorderSize = 0
        Me.btnOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOcultar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcultar.ForeColor = System.Drawing.Color.Black
        Me.btnOcultar.Image = Global.ProjetoTCC.My.Resources.Resources.baixados_removebg_preview__1_
        Me.btnOcultar.Location = New System.Drawing.Point(3, 0)
        Me.btnOcultar.Name = "btnOcultar"
        Me.btnOcultar.Size = New System.Drawing.Size(40, 40)
        Me.btnOcultar.TabIndex = 7
        Me.btnOcultar.UseVisualStyleBackColor = False
        '
        'btnConfig
        '
        Me.btnConfig.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfig.ForeColor = System.Drawing.Color.Black
        Me.btnConfig.Location = New System.Drawing.Point(12, 519)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(208, 41)
        Me.btnConfig.TabIndex = 6
        Me.btnConfig.Text = "Ajustes"
        Me.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'btnCadastrarPaciente
        '
        Me.btnCadastrarPaciente.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCadastrarPaciente.FlatAppearance.BorderSize = 0
        Me.btnCadastrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarPaciente.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarPaciente.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarPaciente.Location = New System.Drawing.Point(12, 189)
        Me.btnCadastrarPaciente.Name = "btnCadastrarPaciente"
        Me.btnCadastrarPaciente.Size = New System.Drawing.Size(208, 41)
        Me.btnCadastrarPaciente.TabIndex = 5
        Me.btnCadastrarPaciente.Text = "Cadastro de Paciente"
        Me.btnCadastrarPaciente.UseVisualStyleBackColor = False
        '
        'btnConsultarAlimentos
        '
        Me.btnConsultarAlimentos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConsultarAlimentos.FlatAppearance.BorderSize = 0
        Me.btnConsultarAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultarAlimentos.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultarAlimentos.ForeColor = System.Drawing.Color.Black
        Me.btnConsultarAlimentos.Location = New System.Drawing.Point(12, 236)
        Me.btnConsultarAlimentos.Name = "btnConsultarAlimentos"
        Me.btnConsultarAlimentos.Size = New System.Drawing.Size(208, 41)
        Me.btnConsultarAlimentos.TabIndex = 3
        Me.btnConsultarAlimentos.Text = "Consultar Alimentos"
        Me.btnConsultarAlimentos.UseVisualStyleBackColor = False
        '
        'btnCadastrarAlimento
        '
        Me.btnCadastrarAlimento.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCadastrarAlimento.FlatAppearance.BorderSize = 0
        Me.btnCadastrarAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastrarAlimento.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrarAlimento.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrarAlimento.Location = New System.Drawing.Point(12, 142)
        Me.btnCadastrarAlimento.Name = "btnCadastrarAlimento"
        Me.btnCadastrarAlimento.Size = New System.Drawing.Size(208, 41)
        Me.btnCadastrarAlimento.TabIndex = 2
        Me.btnCadastrarAlimento.Text = "Cadastrar Alimento"
        Me.btnCadastrarAlimento.UseVisualStyleBackColor = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.pbLogo.Location = New System.Drawing.Point(41, 18)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(144, 109)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'btnCadastroCardapio
        '
        Me.btnCadastroCardapio.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCadastroCardapio.FlatAppearance.BorderSize = 0
        Me.btnCadastroCardapio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCadastroCardapio.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastroCardapio.ForeColor = System.Drawing.Color.Black
        Me.btnCadastroCardapio.Location = New System.Drawing.Point(12, 283)
        Me.btnCadastroCardapio.Name = "btnCadastroCardapio"
        Me.btnCadastroCardapio.Size = New System.Drawing.Size(208, 41)
        Me.btnCadastroCardapio.TabIndex = 4
        Me.btnCadastroCardapio.Text = "Cardápio"
        Me.btnCadastroCardapio.UseVisualStyleBackColor = False
        '
        'pnlLogo
        '
        Me.pnlLogo.Location = New System.Drawing.Point(4, 4)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(228, 136)
        Me.pnlLogo.TabIndex = 0
        Me.pnlLogo.TabStop = False
        '
        'pbxLogoGrande
        '
        Me.pbxLogoGrande.Image = Global.ProjetoTCC.My.Resources.Resources.iconTCC_removebg_preview__1____Copia
        Me.pbxLogoGrande.Location = New System.Drawing.Point(385, 120)
        Me.pbxLogoGrande.Name = "pbxLogoGrande"
        Me.pbxLogoGrande.Size = New System.Drawing.Size(332, 308)
        Me.pbxLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogoGrande.TabIndex = 6
        Me.pbxLogoGrande.TabStop = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.Transparent
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.Black
        Me.btnMostrar.Image = Global.ProjetoTCC.My.Resources.Resources.baixados_removebg_preview__1_
        Me.btnMostrar.Location = New System.Drawing.Point(12, 8)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(40, 40)
        Me.btnMostrar.TabIndex = 8
        Me.btnMostrar.UseVisualStyleBackColor = False
        Me.btnMostrar.Visible = False
        '
        'lblNomeApp
        '
        Me.lblNomeApp.AutoSize = True
        Me.lblNomeApp.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblNomeApp.Location = New System.Drawing.Point(462, 470)
        Me.lblNomeApp.Name = "lblNomeApp"
        Me.lblNomeApp.Size = New System.Drawing.Size(147, 45)
        Me.lblNomeApp.TabIndex = 7
        Me.lblNomeApp.Text = "NutrApp"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblUsuario.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsuario.Location = New System.Drawing.Point(890, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(48, 19)
        Me.lblUsuario.TabIndex = 9
        Me.lblUsuario.Text = "Label1"
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(938, 624)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblNomeApp)
        Me.Controls.Add(Me.pbxLogoGrande)
        Me.Controls.Add(Me.pnlBotoes)
        Me.Controls.Add(Me.btnMostrar)
        Me.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.pnlBotoes.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxLogoGrande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlBotoes As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents btnCadastrarAlimento As Button
    Friend WithEvents btnConsultarAlimentos As Button
    Friend WithEvents btnCadastrarPaciente As Button
    Friend WithEvents btnCadastroCardapio As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents pbxLogoGrande As PictureBox
    Friend WithEvents btnOcultar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents pnlLogo As PictureBox
    Friend WithEvents btnFinanceiro As Button
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnDeslogar As Button
    Friend WithEvents lblNomeApp As Label
    Friend WithEvents lblUsuario As Label
End Class
