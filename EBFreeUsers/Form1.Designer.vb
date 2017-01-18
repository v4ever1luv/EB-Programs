<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nazitimer = New System.Windows.Forms.Timer(Me.components)
        Me.jew_worker = New System.ComponentModel.BackgroundWorker()
        Me.niggermenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.yuukisuckskappa = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.niggermenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'nazitimer
        '
        Me.nazitimer.Enabled = True
        Me.nazitimer.Interval = 5000
        '
        'jew_worker
        '
        '
        'niggermenu
        '
        Me.niggermenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.niggermenu.Name = "niggermenu"
        Me.niggermenu.Size = New System.Drawing.Size(104, 26)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = CType(resources.GetObject("CloseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'yuukisuckskappa
        '
        Me.yuukisuckskappa.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.yuukisuckskappa.BalloonTipText = "wawixs suck dicks"
        Me.yuukisuckskappa.BalloonTipTitle = "nazi"
        Me.yuukisuckskappa.ContextMenuStrip = Me.niggermenu
        Me.yuukisuckskappa.Icon = CType(resources.GetObject("yuukisuckskappa.Icon"), System.Drawing.Icon)
        Me.yuukisuckskappa.Text = "EB Free Checker"
        Me.yuukisuckskappa.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 0)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EB Free user checker"
        Me.niggermenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents nazitimer As Timer
    Friend WithEvents jew_worker As System.ComponentModel.BackgroundWorker
    Friend WithEvents niggermenu As ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents yuukisuckskappa As NotifyIcon
End Class
