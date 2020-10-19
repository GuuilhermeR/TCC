<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuPrincipal))
        Me.btnCalculos = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculos
        '
        Me.btnCalculos.Location = New System.Drawing.Point(83, 60)
        Me.btnCalculos.Name = "btnCalculos"
        Me.btnCalculos.Size = New System.Drawing.Size(195, 113)
        Me.btnCalculos.TabIndex = 1
        Me.btnCalculos.Text = "Cadastrar Medidas"
        Me.btnCalculos.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(534, 60)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(195, 113)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar Medidas"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 113)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Consultar Medidas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(836, 498)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCalculos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMenuPrincipal"
        Me.Text = "Menu Principal"
        Me.Controls.SetChildIndex(Me.btnCalculos, 0)
        Me.Controls.SetChildIndex(Me.btnConsultar, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalculos As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents Button1 As Button
End Class
