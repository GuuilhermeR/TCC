<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarAlimentos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarAlimentos))
        Me.txtAlimento = New MvtWindowsForms.TextBoxStringWithLabel()
        Me.dtgAlimentosCadastrados = New MvtWindowsForms.MvtDataGridView()
        Me.btnCadastrarAlimento = New MvtWindowsForms.ButtonSave()
        Me.btnConsultarAlimento = New MvtWindowsForms.ButtonFind()
        CType(Me.dtgAlimentosCadastrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAlimento
        '
        Me.txtAlimento.AutoSize = True
        Me.txtAlimento.Conexao = Nothing
        Me.txtAlimento.ConnectionString = Nothing
        Me.txtAlimento.FieldFilter = Nothing
        Me.txtAlimento.FieldFind = Nothing
        Me.txtAlimento.FieldReturn = Nothing
        Me.txtAlimento.KeepValue = False
        Me.txtAlimento.LCaseText = False
        Me.txtAlimento.Location = New System.Drawing.Point(12, 12)
        Me.txtAlimento.Name = "txtAlimento"
        Me.txtAlimento.NameExibition = "Alimento"
        Me.txtAlimento.OrderManual = Nothing
        Me.txtAlimento.OthersFilters = Nothing
        Me.txtAlimento.Size = New System.Drawing.Size(200, 24)
        Me.txtAlimento.SizeTextBox = 0
        Me.txtAlimento.SQLSelectFind = Nothing
        Me.txtAlimento.TabIndex = 1
        Me.txtAlimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtAlimento.ToolTipHelp = Nothing
        Me.txtAlimento.UCaseFirstCharText = False
        Me.txtAlimento.UCaseText = False
        Me.txtAlimento.UseF3 = False
        Me.txtAlimento.ValueReturn = Nothing
        Me.txtAlimento.ZIniciar = True
        '
        'dtgAlimentosCadastrados
        '
        Me.dtgAlimentosCadastrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgAlimentosCadastrados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dtgAlimentosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgAlimentosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgAlimentosCadastrados.Location = New System.Drawing.Point(12, 49)
        Me.dtgAlimentosCadastrados.Name = "dtgAlimentosCadastrados"
        Me.dtgAlimentosCadastrados.RowHeadersWidth = 20
        Me.dtgAlimentosCadastrados.Size = New System.Drawing.Size(446, 235)
        Me.dtgAlimentosCadastrados.TabIndex = 2
        Me.dtgAlimentosCadastrados.ValidateFormattedColumns = False
        '
        'btnCadastrarAlimento
        '
        Me.btnCadastrarAlimento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrarAlimento.Image = CType(resources.GetObject("btnCadastrarAlimento.Image"), System.Drawing.Image)
        Me.btnCadastrarAlimento.Location = New System.Drawing.Point(252, 12)
        Me.btnCadastrarAlimento.Name = "btnCadastrarAlimento"
        Me.btnCadastrarAlimento.Size = New System.Drawing.Size(100, 31)
        Me.btnCadastrarAlimento.TabIndex = 3
        Me.btnCadastrarAlimento.Text = "Cadastrar"
        Me.btnCadastrarAlimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCadastrarAlimento.ToolTipHelp = Nothing
        Me.btnCadastrarAlimento.UseVisualStyleBackColor = True
        '
        'btnConsultarAlimento
        '
        Me.btnConsultarAlimento.Image = CType(resources.GetObject("btnConsultarAlimento.Image"), System.Drawing.Image)
        Me.btnConsultarAlimento.Location = New System.Drawing.Point(358, 12)
        Me.btnConsultarAlimento.Name = "btnConsultarAlimento"
        Me.btnConsultarAlimento.Size = New System.Drawing.Size(100, 31)
        Me.btnConsultarAlimento.TabIndex = 4
        Me.btnConsultarAlimento.Text = "Consultar"
        Me.btnConsultarAlimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConsultarAlimento.ToolTipHelp = Nothing
        Me.btnConsultarAlimento.UseVisualStyleBackColor = True
        Me.btnConsultarAlimento.WaitText = "Aguarde... " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Carregando dados..."
        '
        'frmCadastrarAlimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(470, 296)
        Me.Controls.Add(Me.btnConsultarAlimento)
        Me.Controls.Add(Me.btnCadastrarAlimento)
        Me.Controls.Add(Me.dtgAlimentosCadastrados)
        Me.Controls.Add(Me.txtAlimento)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastrarAlimentos"
        Me.Text = "Cadastrar Alimentos"
        Me.Controls.SetChildIndex(Me.txtAlimento, 0)
        Me.Controls.SetChildIndex(Me.dtgAlimentosCadastrados, 0)
        Me.Controls.SetChildIndex(Me.btnCadastrarAlimento, 0)
        Me.Controls.SetChildIndex(Me.btnConsultarAlimento, 0)
        CType(Me.dtgAlimentosCadastrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAlimento As MvtWindowsForms.TextBoxStringWithLabel
    Friend WithEvents dtgAlimentosCadastrados As MvtWindowsForms.MvtDataGridView
    Friend WithEvents btnCadastrarAlimento As MvtWindowsForms.ButtonSave
    Friend WithEvents btnConsultarAlimento As MvtWindowsForms.ButtonFind
End Class
