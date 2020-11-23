<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfiguracoes))
        Me.btnApagarConta = New System.Windows.Forms.Button()
        Me.btnApagarDados = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnApagarConta
        '
        Me.btnApagarConta.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApagarConta.Location = New System.Drawing.Point(12, 12)
        Me.btnApagarConta.Name = "btnApagarConta"
        Me.btnApagarConta.Size = New System.Drawing.Size(279, 33)
        Me.btnApagarConta.TabIndex = 1
        Me.btnApagarConta.Text = "Apagar Conta"
        Me.btnApagarConta.UseVisualStyleBackColor = True
        '
        'btnApagarDados
        '
        Me.btnApagarDados.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApagarDados.Location = New System.Drawing.Point(12, 51)
        Me.btnApagarDados.Name = "btnApagarDados"
        Me.btnApagarDados.Size = New System.Drawing.Size(279, 33)
        Me.btnApagarDados.TabIndex = 2
        Me.btnApagarDados.Text = "Apagar Dados"
        Me.btnApagarDados.UseVisualStyleBackColor = True
        '
        'frmConfiguracoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(303, 97)
        Me.Controls.Add(Me.btnApagarDados)
        Me.Controls.Add(Me.btnApagarConta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfiguracoes"
        Me.Text = "Configurações"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApagarConta As Button
    Friend WithEvents btnApagarDados As Button
End Class
