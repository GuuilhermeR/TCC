<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlimento))
        Me.tbAlimento = New System.Windows.Forms.TabControl()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtCalcio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVitC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFerro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtProteina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLipidio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCarboidrato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtKCal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMedidaCaseira = New System.Windows.Forms.TextBox()
        Me.lblMedidaCaseira = New System.Windows.Forms.Label()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.lblAlimento = New System.Windows.Forms.Label()
        Me.btnProcurarAlimento = New System.Windows.Forms.Button()
        Me.txtCodAlimento = New System.Windows.Forms.TextBox()
        Me.lblCodAlimento = New System.Windows.Forms.Label()
        Me.tbConsulta = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAlimentoFiltro = New System.Windows.Forms.TextBox()
        Me.dtgConAlimento = New System.Windows.Forms.DataGridView()
        Me.tbImportarPlanilha = New System.Windows.Forms.TabPage()
        Me.cbxNomePlanilha = New System.Windows.Forms.ComboBox()
        Me.btnImportar = New System.Windows.Forms.Button()
        Me.dtgDados = New System.Windows.Forms.DataGridView()
        Me.btnBuscarPlanilha = New System.Windows.Forms.Button()
        Me.txtCaminhoArquivoExcel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCaminho = New System.Windows.Forms.Label()
        Me.ofd1 = New System.Windows.Forms.OpenFileDialog()
        Me.tbAlimento.SuspendLayout()
        Me.tbCadastro.SuspendLayout()
        Me.tbConsulta.SuspendLayout()
        CType(Me.dtgConAlimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbImportarPlanilha.SuspendLayout()
        CType(Me.dtgDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbAlimento
        '
        Me.tbAlimento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbAlimento.Controls.Add(Me.tbCadastro)
        Me.tbAlimento.Controls.Add(Me.tbConsulta)
        Me.tbAlimento.Controls.Add(Me.tbImportarPlanilha)
        Me.tbAlimento.Location = New System.Drawing.Point(3, 3)
        Me.tbAlimento.Name = "tbAlimento"
        Me.tbAlimento.SelectedIndex = 0
        Me.tbAlimento.Size = New System.Drawing.Size(795, 524)
        Me.tbAlimento.TabIndex = 0
        '
        'tbCadastro
        '
        Me.tbCadastro.Controls.Add(Me.btnExcluir)
        Me.tbCadastro.Controls.Add(Me.btnSalvar)
        Me.tbCadastro.Controls.Add(Me.txtCalcio)
        Me.tbCadastro.Controls.Add(Me.Label7)
        Me.tbCadastro.Controls.Add(Me.txtVitC)
        Me.tbCadastro.Controls.Add(Me.Label8)
        Me.tbCadastro.Controls.Add(Me.txtFerro)
        Me.tbCadastro.Controls.Add(Me.Label9)
        Me.tbCadastro.Controls.Add(Me.txtProteina)
        Me.tbCadastro.Controls.Add(Me.Label4)
        Me.tbCadastro.Controls.Add(Me.txtLipidio)
        Me.tbCadastro.Controls.Add(Me.Label5)
        Me.tbCadastro.Controls.Add(Me.txtCarboidrato)
        Me.tbCadastro.Controls.Add(Me.Label6)
        Me.tbCadastro.Controls.Add(Me.txtQtde)
        Me.tbCadastro.Controls.Add(Me.lblQuantidade)
        Me.tbCadastro.Controls.Add(Me.txtKCal)
        Me.tbCadastro.Controls.Add(Me.Label2)
        Me.tbCadastro.Controls.Add(Me.txtMedidaCaseira)
        Me.tbCadastro.Controls.Add(Me.lblMedidaCaseira)
        Me.tbCadastro.Controls.Add(Me.txtAlimento)
        Me.tbCadastro.Controls.Add(Me.lblAlimento)
        Me.tbCadastro.Controls.Add(Me.btnProcurarAlimento)
        Me.tbCadastro.Controls.Add(Me.txtCodAlimento)
        Me.tbCadastro.Controls.Add(Me.lblCodAlimento)
        Me.tbCadastro.Location = New System.Drawing.Point(4, 22)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(787, 498)
        Me.tbCadastro.TabIndex = 0
        Me.tbCadastro.Text = "Cadastro"
        Me.tbCadastro.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.ProjetoTCC.My.Resources.Resources.DeleteRed
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(692, 462)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(89, 30)
        Me.btnExcluir.TabIndex = 49
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(597, 462)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(89, 30)
        Me.btnSalvar.TabIndex = 48
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtCalcio
        '
        Me.txtCalcio.Location = New System.Drawing.Point(546, 246)
        Me.txtCalcio.Name = "txtCalcio"
        Me.txtCalcio.Size = New System.Drawing.Size(79, 20)
        Me.txtCalcio.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(450, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Cálcio (mg):"
        '
        'txtVitC
        '
        Me.txtVitC.Location = New System.Drawing.Point(546, 317)
        Me.txtVitC.Name = "txtVitC"
        Me.txtVitC.Size = New System.Drawing.Size(79, 20)
        Me.txtVitC.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(450, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Vitamina C:"
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(546, 281)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.Size = New System.Drawing.Size(79, 20)
        Me.txtFerro.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(450, 284)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Ferro (mg):"
        '
        'txtProteina
        '
        Me.txtProteina.Location = New System.Drawing.Point(546, 143)
        Me.txtProteina.Name = "txtProteina"
        Me.txtProteina.Size = New System.Drawing.Size(79, 20)
        Me.txtProteina.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Proteína (g):"
        '
        'txtLipidio
        '
        Me.txtLipidio.Location = New System.Drawing.Point(546, 214)
        Me.txtLipidio.Name = "txtLipidio"
        Me.txtLipidio.Size = New System.Drawing.Size(79, 20)
        Me.txtLipidio.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(450, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Lipídio (g):"
        '
        'txtCarboidrato
        '
        Me.txtCarboidrato.Location = New System.Drawing.Point(546, 178)
        Me.txtCarboidrato.Name = "txtCarboidrato"
        Me.txtCarboidrato.Size = New System.Drawing.Size(79, 20)
        Me.txtCarboidrato.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(450, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Carboidrato (g):"
        '
        'txtQtde
        '
        Me.txtQtde.Location = New System.Drawing.Point(139, 175)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(79, 20)
        Me.txtQtde.TabIndex = 35
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(43, 178)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 34
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtKCal
        '
        Me.txtKCal.Location = New System.Drawing.Point(139, 246)
        Me.txtKCal.Name = "txtKCal"
        Me.txtKCal.Size = New System.Drawing.Size(79, 20)
        Me.txtKCal.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 249)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "KCal:"
        '
        'txtMedidaCaseira
        '
        Me.txtMedidaCaseira.Location = New System.Drawing.Point(139, 210)
        Me.txtMedidaCaseira.Name = "txtMedidaCaseira"
        Me.txtMedidaCaseira.Size = New System.Drawing.Size(79, 20)
        Me.txtMedidaCaseira.TabIndex = 31
        '
        'lblMedidaCaseira
        '
        Me.lblMedidaCaseira.AutoSize = True
        Me.lblMedidaCaseira.Location = New System.Drawing.Point(43, 213)
        Me.lblMedidaCaseira.Name = "lblMedidaCaseira"
        Me.lblMedidaCaseira.Size = New System.Drawing.Size(83, 13)
        Me.lblMedidaCaseira.TabIndex = 30
        Me.lblMedidaCaseira.Text = "Medida Caseira:"
        '
        'txtAlimento
        '
        Me.txtAlimento.Location = New System.Drawing.Point(106, 72)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.Size = New System.Drawing.Size(242, 20)
        Me.txtAlimento.TabIndex = 29
        '
        'lblAlimento
        '
        Me.lblAlimento.AutoSize = True
        Me.lblAlimento.Location = New System.Drawing.Point(26, 75)
        Me.lblAlimento.Name = "lblAlimento"
        Me.lblAlimento.Size = New System.Drawing.Size(50, 13)
        Me.lblAlimento.TabIndex = 28
        Me.lblAlimento.Text = "Alimento:"
        '
        'btnProcurarAlimento
        '
        Me.btnProcurarAlimento.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarAlimento.Location = New System.Drawing.Point(192, 25)
        Me.btnProcurarAlimento.Name = "btnProcurarAlimento"
        Me.btnProcurarAlimento.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarAlimento.TabIndex = 27
        Me.btnProcurarAlimento.UseVisualStyleBackColor = True
        '
        'txtCodAlimento
        '
        Me.txtCodAlimento.Location = New System.Drawing.Point(107, 27)
        Me.txtCodAlimento.Name = "txtCodAlimento"
        Me.txtCodAlimento.Size = New System.Drawing.Size(79, 20)
        Me.txtCodAlimento.TabIndex = 26
        '
        'lblCodAlimento
        '
        Me.lblCodAlimento.AutoSize = True
        Me.lblCodAlimento.Location = New System.Drawing.Point(26, 30)
        Me.lblCodAlimento.Name = "lblCodAlimento"
        Me.lblCodAlimento.Size = New System.Drawing.Size(75, 13)
        Me.lblCodAlimento.TabIndex = 25
        Me.lblCodAlimento.Text = "Cód. Alimento:"
        '
        'tbConsulta
        '
        Me.tbConsulta.Controls.Add(Me.Label1)
        Me.tbConsulta.Controls.Add(Me.txtAlimentoFiltro)
        Me.tbConsulta.Controls.Add(Me.dtgConAlimento)
        Me.tbConsulta.Location = New System.Drawing.Point(4, 22)
        Me.tbConsulta.Name = "tbConsulta"
        Me.tbConsulta.Padding = New System.Windows.Forms.Padding(3)
        Me.tbConsulta.Size = New System.Drawing.Size(787, 498)
        Me.tbConsulta.TabIndex = 1
        Me.tbConsulta.Text = "Consulta"
        Me.tbConsulta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alimento:"
        '
        'txtAlimentoFiltro
        '
        Me.txtAlimentoFiltro.Location = New System.Drawing.Point(64, 6)
        Me.txtAlimentoFiltro.Name = "txtAlimentoFiltro"
        Me.txtAlimentoFiltro.Size = New System.Drawing.Size(717, 20)
        Me.txtAlimentoFiltro.TabIndex = 1
        '
        'dtgConAlimento
        '
        Me.dtgConAlimento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgConAlimento.BackgroundColor = System.Drawing.Color.White
        Me.dtgConAlimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConAlimento.Location = New System.Drawing.Point(6, 32)
        Me.dtgConAlimento.Name = "dtgConAlimento"
        Me.dtgConAlimento.Size = New System.Drawing.Size(775, 460)
        Me.dtgConAlimento.TabIndex = 0
        '
        'tbImportarPlanilha
        '
        Me.tbImportarPlanilha.Controls.Add(Me.cbxNomePlanilha)
        Me.tbImportarPlanilha.Controls.Add(Me.btnImportar)
        Me.tbImportarPlanilha.Controls.Add(Me.dtgDados)
        Me.tbImportarPlanilha.Controls.Add(Me.btnBuscarPlanilha)
        Me.tbImportarPlanilha.Controls.Add(Me.txtCaminhoArquivoExcel)
        Me.tbImportarPlanilha.Controls.Add(Me.Label10)
        Me.tbImportarPlanilha.Controls.Add(Me.lblCaminho)
        Me.tbImportarPlanilha.Location = New System.Drawing.Point(4, 22)
        Me.tbImportarPlanilha.Name = "tbImportarPlanilha"
        Me.tbImportarPlanilha.Padding = New System.Windows.Forms.Padding(3)
        Me.tbImportarPlanilha.Size = New System.Drawing.Size(787, 498)
        Me.tbImportarPlanilha.TabIndex = 2
        Me.tbImportarPlanilha.Text = "Importar"
        Me.tbImportarPlanilha.UseVisualStyleBackColor = True
        '
        'cbxNomePlanilha
        '
        Me.cbxNomePlanilha.FormattingEnabled = True
        Me.cbxNomePlanilha.Location = New System.Drawing.Point(116, 427)
        Me.cbxNomePlanilha.Name = "cbxNomePlanilha"
        Me.cbxNomePlanilha.Size = New System.Drawing.Size(315, 21)
        Me.cbxNomePlanilha.TabIndex = 270
        '
        'btnImportar
        '
        Me.btnImportar.Location = New System.Drawing.Point(658, 462)
        Me.btnImportar.Name = "btnImportar"
        Me.btnImportar.Size = New System.Drawing.Size(123, 30)
        Me.btnImportar.TabIndex = 269
        Me.btnImportar.Text = "Importar"
        Me.btnImportar.UseVisualStyleBackColor = True
        '
        'dtgDados
        '
        Me.dtgDados.AllowUserToAddRows = False
        Me.dtgDados.BackgroundColor = System.Drawing.Color.White
        Me.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDados.Location = New System.Drawing.Point(9, 6)
        Me.dtgDados.Name = "dtgDados"
        Me.dtgDados.Size = New System.Drawing.Size(772, 377)
        Me.dtgDados.TabIndex = 268
        '
        'btnBuscarPlanilha
        '
        Me.btnBuscarPlanilha.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnBuscarPlanilha.Location = New System.Drawing.Point(751, 389)
        Me.btnBuscarPlanilha.Name = "btnBuscarPlanilha"
        Me.btnBuscarPlanilha.Size = New System.Drawing.Size(30, 23)
        Me.btnBuscarPlanilha.TabIndex = 266
        Me.btnBuscarPlanilha.UseVisualStyleBackColor = True
        '
        'txtCaminhoArquivoExcel
        '
        Me.txtCaminhoArquivoExcel.Location = New System.Drawing.Point(116, 391)
        Me.txtCaminhoArquivoExcel.Name = "txtCaminhoArquivoExcel"
        Me.txtCaminhoArquivoExcel.Size = New System.Drawing.Size(629, 20)
        Me.txtCaminhoArquivoExcel.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 427)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Nome da planilha:"
        '
        'lblCaminho
        '
        Me.lblCaminho.AutoSize = True
        Me.lblCaminho.Location = New System.Drawing.Point(6, 393)
        Me.lblCaminho.Name = "lblCaminho"
        Me.lblCaminho.Size = New System.Drawing.Size(104, 13)
        Me.lblCaminho.TabIndex = 0
        Me.lblCaminho.Text = "Caminho do arquivo:"
        '
        'ofd1
        '
        Me.ofd1.FileName = "ofd1"
        '
        'frmAlimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 530)
        Me.Controls.Add(Me.tbAlimento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlimento"
        Me.Text = "Alimento"
        Me.tbAlimento.ResumeLayout(False)
        Me.tbCadastro.ResumeLayout(False)
        Me.tbCadastro.PerformLayout()
        Me.tbConsulta.ResumeLayout(False)
        Me.tbConsulta.PerformLayout()
        CType(Me.dtgConAlimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbImportarPlanilha.ResumeLayout(False)
        Me.tbImportarPlanilha.PerformLayout()
        CType(Me.dtgDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbAlimento As TabControl
    Friend WithEvents tbCadastro As TabPage
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents txtCalcio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVitC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFerro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtProteina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLipidio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCarboidrato As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtde As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtKCal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMedidaCaseira As TextBox
    Friend WithEvents lblMedidaCaseira As Label
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents lblAlimento As Label
    Friend WithEvents btnProcurarAlimento As Button
    Friend WithEvents txtCodAlimento As TextBox
    Friend WithEvents lblCodAlimento As Label
    Friend WithEvents tbConsulta As TabPage
    Friend WithEvents dtgConAlimento As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlimentoFiltro As TextBox
    Friend WithEvents tbImportarPlanilha As TabPage
    Friend WithEvents txtCaminhoArquivoExcel As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCaminho As Label
    Friend WithEvents btnBuscarPlanilha As Button
    Friend WithEvents ofd1 As OpenFileDialog
    Friend WithEvents dtgDados As DataGridView
    Friend WithEvents btnImportar As Button
    Friend WithEvents cbxNomePlanilha As ComboBox
End Class
