<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransparenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AumentarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisminuirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.TransparenciaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(727, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalidaToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalidaToolStripMenuItem.Text = "Salir"
        '
        'TransparenciaToolStripMenuItem
        '
        Me.TransparenciaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AumentarToolStripMenuItem, Me.DisminuirToolStripMenuItem})
        Me.TransparenciaToolStripMenuItem.Name = "TransparenciaToolStripMenuItem"
        Me.TransparenciaToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.TransparenciaToolStripMenuItem.Text = "Transparencia"
        '
        'AumentarToolStripMenuItem
        '
        Me.AumentarToolStripMenuItem.Name = "AumentarToolStripMenuItem"
        Me.AumentarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AumentarToolStripMenuItem.Text = "Aumentar"
        '
        'DisminuirToolStripMenuItem
        '
        Me.DisminuirToolStripMenuItem.Name = "DisminuirToolStripMenuItem"
        Me.DisminuirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DisminuirToolStripMenuItem.Text = "Disminuir"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 437)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema Académico UCA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransparenciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AumentarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisminuirToolStripMenuItem As ToolStripMenuItem
End Class
