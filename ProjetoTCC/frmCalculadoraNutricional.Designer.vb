<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastroNutricional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastroNutricional))
        Me.txtGramas = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtQtde = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtKcal = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.TextBoxNumberWithLabel1 = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.TextBoxNumberWithLabel2 = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.TextBoxNumberWithLabel3 = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtAlimento = New MvtWindowsForms.TextBoxStringWithLabel()
        Me.btnSalvar = New MvtWindowsForms.ButtonSave()
        Me.txtVitC = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtFerro = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.txtCa = New MvtWindowsForms.TextBoxNumberWithLabel()
        Me.SuspendLayout()
        '
        'txtGramas
        '
        Me.txtGramas.Conexao = Nothing
        Me.txtGramas.ConnectionString = Nothing
        Me.txtGramas.FieldFilter = Nothing
        Me.txtGramas.FieldFind = Nothing
        Me.txtGramas.FieldReturn = Nothing
        Me.txtGramas.FormatCustom = Nothing
        Me.txtGramas.KeepValue = False
        Me.txtGramas.Location = New System.Drawing.Point(12, 70)
        Me.txtGramas.Name = "txtGramas"
        Me.txtGramas.NameExibition = "Gramas:"
        Me.txtGramas.OrderManual = Nothing
        Me.txtGramas.OthersFilters = Nothing
        Me.txtGramas.Size = New System.Drawing.Size(200, 21)
        Me.txtGramas.SizeTextBox = 0
        Me.txtGramas.SQLSelectFind = Nothing
        Me.txtGramas.TabIndex = 1
        Me.txtGramas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtGramas.ToolTipHelp = Nothing
        Me.txtGramas.UseF3 = False
        Me.txtGramas.ValueReturn = Nothing
        Me.txtGramas.ZIniciar = True
        '
        'txtQtde
        '
        Me.txtQtde.Conexao = Nothing
        Me.txtQtde.ConnectionString = Nothing
        Me.txtQtde.FieldFilter = Nothing
        Me.txtQtde.FieldFind = Nothing
        Me.txtQtde.FieldReturn = Nothing
        Me.txtQtde.FormatCustom = Nothing
        Me.txtQtde.KeepValue = False
        Me.txtQtde.Location = New System.Drawing.Point(12, 97)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.NameExibition = "Quantidade:"
        Me.txtQtde.OrderManual = Nothing
        Me.txtQtde.OthersFilters = Nothing
        Me.txtQtde.Size = New System.Drawing.Size(200, 21)
        Me.txtQtde.SizeTextBox = 0
        Me.txtQtde.SQLSelectFind = Nothing
        Me.txtQtde.TabIndex = 3
        Me.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtQtde.ToolTipHelp = Nothing
        Me.txtQtde.UseF3 = False
        Me.txtQtde.ValueReturn = Nothing
        Me.txtQtde.ZIniciar = True
        '
        'txtKcal
        '
        Me.txtKcal.Conexao = Nothing
        Me.txtKcal.ConnectionString = Nothing
        Me.txtKcal.FieldFilter = Nothing
        Me.txtKcal.FieldFind = Nothing
        Me.txtKcal.FieldReturn = Nothing
        Me.txtKcal.FormatCustom = Nothing
        Me.txtKcal.KeepValue = False
        Me.txtKcal.Location = New System.Drawing.Point(12, 124)
        Me.txtKcal.Name = "txtKcal"
        Me.txtKcal.NameExibition = "Kcal:"
        Me.txtKcal.OrderManual = Nothing
        Me.txtKcal.OthersFilters = Nothing
        Me.txtKcal.Size = New System.Drawing.Size(200, 21)
        Me.txtKcal.SizeTextBox = 0
        Me.txtKcal.SQLSelectFind = Nothing
        Me.txtKcal.TabIndex = 4
        Me.txtKcal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtKcal.ToolTipHelp = Nothing
        Me.txtKcal.UseF3 = False
        Me.txtKcal.ValueReturn = Nothing
        Me.txtKcal.ZIniciar = True
        '
        'TextBoxNumberWithLabel1
        '
        Me.TextBoxNumberWithLabel1.Conexao = Nothing
        Me.TextBoxNumberWithLabel1.ConnectionString = Nothing
        Me.TextBoxNumberWithLabel1.FieldFilter = Nothing
        Me.TextBoxNumberWithLabel1.FieldFind = Nothing
        Me.TextBoxNumberWithLabel1.FieldReturn = Nothing
        Me.TextBoxNumberWithLabel1.FormatCustom = Nothing
        Me.TextBoxNumberWithLabel1.KeepValue = False
        Me.TextBoxNumberWithLabel1.Location = New System.Drawing.Point(242, 92)
        Me.TextBoxNumberWithLabel1.Name = "TextBoxNumberWithLabel1"
        Me.TextBoxNumberWithLabel1.NameExibition = "Lipídio (g):"
        Me.TextBoxNumberWithLabel1.OrderManual = Nothing
        Me.TextBoxNumberWithLabel1.OthersFilters = Nothing
        Me.TextBoxNumberWithLabel1.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxNumberWithLabel1.SizeTextBox = 0
        Me.TextBoxNumberWithLabel1.SQLSelectFind = Nothing
        Me.TextBoxNumberWithLabel1.TabIndex = 7
        Me.TextBoxNumberWithLabel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxNumberWithLabel1.ToolTipHelp = Nothing
        Me.TextBoxNumberWithLabel1.UseF3 = False
        Me.TextBoxNumberWithLabel1.ValueReturn = Nothing
        Me.TextBoxNumberWithLabel1.ZIniciar = True
        '
        'TextBoxNumberWithLabel2
        '
        Me.TextBoxNumberWithLabel2.Conexao = Nothing
        Me.TextBoxNumberWithLabel2.ConnectionString = Nothing
        Me.TextBoxNumberWithLabel2.FieldFilter = Nothing
        Me.TextBoxNumberWithLabel2.FieldFind = Nothing
        Me.TextBoxNumberWithLabel2.FieldReturn = Nothing
        Me.TextBoxNumberWithLabel2.FormatCustom = Nothing
        Me.TextBoxNumberWithLabel2.KeepValue = False
        Me.TextBoxNumberWithLabel2.Location = New System.Drawing.Point(242, 65)
        Me.TextBoxNumberWithLabel2.Name = "TextBoxNumberWithLabel2"
        Me.TextBoxNumberWithLabel2.NameExibition = "Carboidrato (g):"
        Me.TextBoxNumberWithLabel2.OrderManual = Nothing
        Me.TextBoxNumberWithLabel2.OthersFilters = Nothing
        Me.TextBoxNumberWithLabel2.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxNumberWithLabel2.SizeTextBox = 0
        Me.TextBoxNumberWithLabel2.SQLSelectFind = Nothing
        Me.TextBoxNumberWithLabel2.TabIndex = 6
        Me.TextBoxNumberWithLabel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxNumberWithLabel2.ToolTipHelp = Nothing
        Me.TextBoxNumberWithLabel2.UseF3 = False
        Me.TextBoxNumberWithLabel2.ValueReturn = Nothing
        Me.TextBoxNumberWithLabel2.ZIniciar = True
        '
        'TextBoxNumberWithLabel3
        '
        Me.TextBoxNumberWithLabel3.Conexao = Nothing
        Me.TextBoxNumberWithLabel3.ConnectionString = Nothing
        Me.TextBoxNumberWithLabel3.FieldFilter = Nothing
        Me.TextBoxNumberWithLabel3.FieldFind = Nothing
        Me.TextBoxNumberWithLabel3.FieldReturn = Nothing
        Me.TextBoxNumberWithLabel3.FormatCustom = Nothing
        Me.TextBoxNumberWithLabel3.KeepValue = False
        Me.TextBoxNumberWithLabel3.Location = New System.Drawing.Point(242, 38)
        Me.TextBoxNumberWithLabel3.Name = "TextBoxNumberWithLabel3"
        Me.TextBoxNumberWithLabel3.NameExibition = "Proteína (g):"
        Me.TextBoxNumberWithLabel3.OrderManual = Nothing
        Me.TextBoxNumberWithLabel3.OthersFilters = Nothing
        Me.TextBoxNumberWithLabel3.Size = New System.Drawing.Size(200, 21)
        Me.TextBoxNumberWithLabel3.SizeTextBox = 0
        Me.TextBoxNumberWithLabel3.SQLSelectFind = Nothing
        Me.TextBoxNumberWithLabel3.TabIndex = 5
        Me.TextBoxNumberWithLabel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBoxNumberWithLabel3.ToolTipHelp = Nothing
        Me.TextBoxNumberWithLabel3.UseF3 = False
        Me.TextBoxNumberWithLabel3.ValueReturn = Nothing
        Me.TextBoxNumberWithLabel3.ZIniciar = True
        '
        'txtAlimento
        '
        Me.txtAlimento.Conexao = Nothing
        Me.txtAlimento.ConnectionString = Nothing
        Me.txtAlimento.FieldFilter = Nothing
        Me.txtAlimento.FieldFind = Nothing
        Me.txtAlimento.FieldReturn = Nothing
        Me.txtAlimento.KeepValue = False
        Me.txtAlimento.LCaseText = False
        Me.txtAlimento.Location = New System.Drawing.Point(12, 12)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.NameExibition = "Alimento:"
        Me.txtAlimento.OrderManual = Nothing
        Me.txtAlimento.OthersFilters = Nothing
        Me.txtAlimento.Size = New System.Drawing.Size(213, 21)
        Me.txtAlimento.SizeTextBox = 0
        Me.txtAlimento.SQLSelectFind = Nothing
        Me.txtAlimento.TabIndex = 8
        Me.txtAlimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAlimento.ToolTipHelp = Nothing
        Me.txtAlimento.UCaseFirstCharText = False
        Me.txtAlimento.UCaseText = False
        Me.txtAlimento.UseF3 = False
        Me.txtAlimento.ValueReturn = Nothing
        Me.txtAlimento.ZIniciar = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.Location = New System.Drawing.Point(370, 206)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(100, 31)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.ToolTipHelp = Nothing
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtVitC
        '
        Me.txtVitC.Conexao = Nothing
        Me.txtVitC.ConnectionString = Nothing
        Me.txtVitC.FieldFilter = Nothing
        Me.txtVitC.FieldFind = Nothing
        Me.txtVitC.FieldReturn = Nothing
        Me.txtVitC.FormatCustom = Nothing
        Me.txtVitC.KeepValue = False
        Me.txtVitC.Location = New System.Drawing.Point(242, 173)
        Me.txtVitC.Name = "txtVitC"
        Me.txtVitC.NameExibition = "Vit. C (mg):"
        Me.txtVitC.OrderManual = Nothing
        Me.txtVitC.OthersFilters = Nothing
        Me.txtVitC.Size = New System.Drawing.Size(200, 21)
        Me.txtVitC.SizeTextBox = 0
        Me.txtVitC.SQLSelectFind = Nothing
        Me.txtVitC.TabIndex = 10
        Me.txtVitC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtVitC.ToolTipHelp = Nothing
        Me.txtVitC.UseF3 = False
        Me.txtVitC.ValueReturn = Nothing
        Me.txtVitC.ZIniciar = True
        '
        'txtFerro
        '
        Me.txtFerro.Conexao = Nothing
        Me.txtFerro.ConnectionString = Nothing
        Me.txtFerro.FieldFilter = Nothing
        Me.txtFerro.FieldFind = Nothing
        Me.txtFerro.FieldReturn = Nothing
        Me.txtFerro.FormatCustom = Nothing
        Me.txtFerro.KeepValue = False
        Me.txtFerro.Location = New System.Drawing.Point(242, 146)
        Me.txtFerro.Name = "txtFerro"
        Me.txtFerro.NameExibition = "Ferro (mg):"
        Me.txtFerro.OrderManual = Nothing
        Me.txtFerro.OthersFilters = Nothing
        Me.txtFerro.Size = New System.Drawing.Size(200, 21)
        Me.txtFerro.SizeTextBox = 0
        Me.txtFerro.SQLSelectFind = Nothing
        Me.txtFerro.TabIndex = 9
        Me.txtFerro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtFerro.ToolTipHelp = Nothing
        Me.txtFerro.UseF3 = False
        Me.txtFerro.ValueReturn = Nothing
        Me.txtFerro.ZIniciar = True
        '
        'txtCa
        '
        Me.txtCa.Conexao = Nothing
        Me.txtCa.ConnectionString = Nothing
        Me.txtCa.FieldFilter = Nothing
        Me.txtCa.FieldFind = Nothing
        Me.txtCa.FieldReturn = Nothing
        Me.txtCa.FormatCustom = Nothing
        Me.txtCa.KeepValue = False
        Me.txtCa.Location = New System.Drawing.Point(242, 119)
        Me.txtCa.Name = "txtCa"
        Me.txtCa.NameExibition = "Cálcio (mg):"
        Me.txtCa.OrderManual = Nothing
        Me.txtCa.OthersFilters = Nothing
        Me.txtCa.Size = New System.Drawing.Size(200, 21)
        Me.txtCa.SizeTextBox = 0
        Me.txtCa.SQLSelectFind = Nothing
        Me.txtCa.TabIndex = 8
        Me.txtCa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCa.ToolTipHelp = Nothing
        Me.txtCa.UseF3 = False
        Me.txtCa.ValueReturn = Nothing
        Me.txtCa.ZIniciar = True
        '
        'frmCadastroNutricional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(482, 249)
        Me.Controls.Add(Me.txtVitC)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtFerro)
        Me.Controls.Add(Me.txtCa)
        Me.Controls.Add(Me.txtAlimento)
        Me.Controls.Add(Me.TextBoxNumberWithLabel1)
        Me.Controls.Add(Me.TextBoxNumberWithLabel2)
        Me.Controls.Add(Me.txtKcal)
        Me.Controls.Add(Me.TextBoxNumberWithLabel3)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtGramas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastroNutricional"
        Me.Text = "Cadastro Nutricional"
        Me.Controls.SetChildIndex(Me.txtGramas, 0)
        Me.Controls.SetChildIndex(Me.txtQtde, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNumberWithLabel3, 0)
        Me.Controls.SetChildIndex(Me.txtKcal, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNumberWithLabel2, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNumberWithLabel1, 0)
        Me.Controls.SetChildIndex(Me.txtAlimento, 0)
        Me.Controls.SetChildIndex(Me.txtCa, 0)
        Me.Controls.SetChildIndex(Me.txtFerro, 0)
        Me.Controls.SetChildIndex(Me.btnSalvar, 0)
        Me.Controls.SetChildIndex(Me.txtVitC, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtGramas As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtQtde As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtKcal As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents TextBoxNumberWithLabel1 As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents TextBoxNumberWithLabel2 As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents TextBoxNumberWithLabel3 As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtAlimento As MvtWindowsForms.TextBoxStringWithLabel
    Friend WithEvents btnSalvar As MvtWindowsForms.ButtonSave
    Friend WithEvents txtVitC As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtFerro As MvtWindowsForms.TextBoxNumberWithLabel
    Friend WithEvents txtCa As MvtWindowsForms.TextBoxNumberWithLabel
End Class
