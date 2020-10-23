<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuPrincipal
    Inherits MvtWindowsForms.MvtForm

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
        Me.btnCalculos = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnCadastrarAlimento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculos
        '
        Me.btnCalculos.Location = New System.Drawing.Point(12, 12)
        Me.btnCalculos.Name = "btnCalculos"
        Me.btnCalculos.Size = New System.Drawing.Size(195, 113)
        Me.btnCalculos.TabIndex = 1
        Me.btnCalculos.Text = "Cadastrar Medidas"
        Me.btnCalculos.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(414, 13)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(195, 113)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar Medidas Caseiras"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnCadastrarAlimento
        '
        Me.btnCadastrarAlimento.Location = New System.Drawing.Point(213, 13)
        Me.btnCadastrarAlimento.Name = "btnCadastrarAlimento"
        Me.btnCadastrarAlimento.Size = New System.Drawing.Size(195, 113)
        Me.btnCadastrarAlimento.TabIndex = 3
        Me.btnCadastrarAlimento.Text = "Cadastrar Alimento"
        Me.btnCadastrarAlimento.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(617, 138)
        Me.Controls.Add(Me.btnCadastrarAlimento)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCalculos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.Controls.SetChildIndex(Me.btnCalculos, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.btnCadastrarAlimento, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalculos As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnCadastrarAlimento As Button
End Class
