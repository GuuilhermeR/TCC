<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroAlimento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroAlimento))
        Me.lblCodAlimento = New System.Windows.Forms.Label()
        Me.txtCodAlimento = New System.Windows.Forms.TextBox()
        Me.txtAlimento = New System.Windows.Forms.TextBox()
        Me.lblAlimento = New System.Windows.Forms.Label()
        Me.txtMedidaCaseira = New System.Windows.Forms.TextBox()
        Me.lblMedidaCaseira = New System.Windows.Forms.Label()
        Me.txtKCal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQtde = New System.Windows.Forms.TextBox()
        Me.lblQuantidade = New System.Windows.Forms.Label()
        Me.txtProteina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLipidio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCarboidrato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCalcio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVitC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFerro = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnProcurarAlimento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCodAlimento
        '
        Me.lblCodAlimento.AutoSize = True
        Me.lblCodAlimento.Location = New System.Drawing.Point(12, 29)
        Me.lblCodAlimento.Name = "lblCodAlimento"
        Me.lblCodAlimento.Size = New System.Drawing.Size(75, 13)
        Me.lblCodAlimento.TabIndex = 0
        Me.lblCodAlimento.Text = "Cód. Alimento:"
        '
        'txtCodAlimento
        '
        Me.txtCodAlimento.Location = New System.Drawing.Point(93, 26)
        Me.txtCodAlimento.Name = "txtCodAlimento"
        Me.txtCodAlimento.Size = New System.Drawing.Size(79, 20)
        Me.txtCodAlimento.TabIndex = 1
        '
        'txtAlimento
        '
        Me.txtAlimento.Location = New System.Drawing.Point(93, 63)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.Size = New System.Drawing.Size(242, 20)
        Me.txtAlimento.TabIndex = 4
        '
        'lblAlimento
        '
        Me.lblAlimento.AutoSize = True
        Me.lblAlimento.Location = New System.Drawing.Point(12, 66)
        Me.lblAlimento.Name = "lblAlimento"
        Me.lblAlimento.Size = New System.Drawing.Size(50, 13)
        Me.lblAlimento.TabIndex = 3
        Me.lblAlimento.Text = "Alimento:"
        '
        'txtMedidaCaseira
        '
        Me.txtMedidaCaseira.Location = New System.Drawing.Point(108, 196)
        Me.txtMedidaCaseira.Name = "txtMedidaCaseira"
        Me.txtMedidaCaseira.Size = New System.Drawing.Size(79, 20)
        Me.txtMedidaCaseira.TabIndex = 6
        '
        'lblMedidaCaseira
        '
        Me.lblMedidaCaseira.AutoSize = True
        Me.lblMedidaCaseira.Location = New System.Drawing.Point(12, 199)
        Me.lblMedidaCaseira.Name = "lblMedidaCaseira"
        Me.lblMedidaCaseira.Size = New System.Drawing.Size(83, 13)
        Me.lblMedidaCaseira.TabIndex = 5
        Me.lblMedidaCaseira.Text = "Medida Caseira:"
        '
        'txtKCal
        '
        Me.txtKCal.Location = New System.Drawing.Point(108, 232)
        Me.txtKCal.Name = "txtKCal"
        Me.txtKCal.Size = New System.Drawing.Size(79, 20)
        Me.txtKCal.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "KCal:"
        '
        'txtQtde
        '
        Me.txtQtde.Location = New System.Drawing.Point(108, 161)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(79, 20)
        Me.txtQtde.TabIndex = 10
        '
        'lblQuantidade
        '
        Me.lblQuantidade.AutoSize = True
        Me.lblQuantidade.Location = New System.Drawing.Point(12, 164)
        Me.lblQuantidade.Name = "lblQuantidade"
        Me.lblQuantidade.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidade.TabIndex = 9
        Me.lblQuantidade.Text = "Quantidade"
        '
        'txtProteina
        '
        Me.txtProteina.Location = New System.Drawing.Point(424, 116)
        Me.txtProteina.Name = "txtProteina"
        Me.txtProteina.Size = New System.Drawing.Size(79, 20)
        Me.txtProteina.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(328, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Proteína (g):"
        '
        'txtLipidio
        '
        Me.txtLipidio.Location = New System.Drawing.Point(424, 187)
        Me.txtLipidio.Name = "txtLipidio"
        Me.txtLipidio.Size = New System.Drawing.Size(79, 20)
        Me.txtLipidio.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Lipídio (g):"
        '
        'txtCarboidrato
        '
        Me.txtCarboidrato.Location = New System.Drawing.Point(424, 151)
        Me.txtCarboidrato.Name = "txtCarboidrato"
        Me.txtCarboidrato.Size = New System.Drawing.Size(79, 20)
        Me.txtCarboidrato.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Carboidrato (g):"
        '
        'txtCalcio
        '
        Me.txtCalcio.Location = New System.Drawing.Point(424, 219)
        Me.txtCalcio.Name = "txtCalcio"
        Me.txtCalcio.Size = New System.Drawing.Size(79, 20)
        Me.txtCalcio.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(328, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Cálcio (mg):"
        '
        'txtVitC
        '
        Me.txtVitC.Location = New System.Drawing.Point(424, 290)
        Me.txtVitC.Name = "txtVitC"
        Me.txtVitC.Size = New System.Drawing.Size(79, 20)
        Me.txtVitC.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Vitamina C:"
        '
        'txtFerro
        '
        Me.txtFerro.Location = New System.Drawing.Point(424, 254)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.Size = New System.Drawing.Size(79, 20)
        Me.txtFerro.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(328, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Ferro (mg):"
        '
        'btnExcluir
        '
        Me.btnExcluir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcluir.Image = Global.ProjetoTCC.My.Resources.Resources.DeleteRed
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(485, 351)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(89, 30)
        Me.btnExcluir.TabIndex = 24
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.ProjetoTCC.My.Resources.Resources.mvtSaveGreen_16
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(390, 351)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(89, 30)
        Me.btnSalvar.TabIndex = 23
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnProcurarAlimento
        '
        Me.btnProcurarAlimento.Image = Global.ProjetoTCC.My.Resources.Resources.consultar
        Me.btnProcurarAlimento.Location = New System.Drawing.Point(178, 24)
        Me.btnProcurarAlimento.Name = "btnProcurarAlimento"
        Me.btnProcurarAlimento.Size = New System.Drawing.Size(30, 23)
        Me.btnProcurarAlimento.TabIndex = 2
        Me.btnProcurarAlimento.UseVisualStyleBackColor = True
        '
        'frmCadastroAlimento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 393)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtCalcio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVitC)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFerro)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtProteina)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLipidio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCarboidrato)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.lblQuantidade)
        Me.Controls.Add(Me.txtKCal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMedidaCaseira)
        Me.Controls.Add(Me.lblMedidaCaseira)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.lblAlimento)
        Me.Controls.Add(Me.btnProcurarAlimento)
        Me.Controls.Add(Me.txtCodAlimento)
        Me.Controls.Add(Me.lblCodAlimento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastroAlimento"
        Me.Text = "Cadastro de Alimento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodAlimento As Label
    Friend WithEvents txtCodAlimento As TextBox
    Friend WithEvents btnProcurarAlimento As Button
    Friend WithEvents txtAlimento As TextBox
    Friend WithEvents lblAlimento As Label
    Friend WithEvents txtMedidaCaseira As TextBox
    Friend WithEvents lblMedidaCaseira As Label
    Friend WithEvents txtKCal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQtde As TextBox
    Friend WithEvents lblQuantidade As Label
    Friend WithEvents txtProteina As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLipidio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCarboidrato As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCalcio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVitC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFerro As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
End Class
