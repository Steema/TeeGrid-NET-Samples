<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.label1 = New System.Windows.Forms.Label()
        Me.tBSpeed = New System.Windows.Forms.TrackBar()
        Me.LSpeed = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TGrid1 = New Steema.TeeGrid.WinForm.TGrid()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.tBSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.LSpeed)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tBSpeed)
        Me.SplitContainer1.Panel1.Controls.Add(Me.label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(471, 514)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TGrid1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Size = New System.Drawing.Size(471, 423)
        Me.SplitContainer2.SplitterDistance = 254
        Me.SplitContainer2.TabIndex = 0
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(15, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Refresh speed:"
        '
        'tBSpeed
        '
        Me.tBSpeed.LargeChange = 50
        Me.tBSpeed.Location = New System.Drawing.Point(100, 12)
        Me.tBSpeed.Maximum = 2000
        Me.tBSpeed.Minimum = 1
        Me.tBSpeed.Name = "tBSpeed"
        Me.tBSpeed.Size = New System.Drawing.Size(190, 45)
        Me.tBSpeed.SmallChange = 10
        Me.tBSpeed.TabIndex = 3
        Me.tBSpeed.Value = 150
        '
        'LSpeed
        '
        Me.LSpeed.AutoSize = True
        Me.LSpeed.Location = New System.Drawing.Point(314, 23)
        Me.LSpeed.Name = "LSpeed"
        Me.LSpeed.Size = New System.Drawing.Size(44, 13)
        Me.LSpeed.TabIndex = 4
        Me.LSpeed.Text = "LSpeed"
        '
        'timer1
        '
        Me.timer1.Interval = 150
        '
        'TGrid1
        '
        Me.TGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TGrid1.Location = New System.Drawing.Point(0, 0)
        Me.TGrid1.Name = "TGrid1"
        Me.TGrid1.Selected.ScrollToView = False
        Me.TGrid1.Size = New System.Drawing.Size(471, 254)
        Me.TGrid1.TabIndex = 0
        Me.TGrid1.Text = "TGrid1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 514)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "TeeGrid Ticker"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.tBSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents tBSpeed As TrackBar
    Private WithEvents label1 As Label
    Private WithEvents LSpeed As Label
    Private WithEvents timer1 As Timer
    Friend WithEvents TGrid1 As Steema.TeeGrid.WinForm.TGrid
End Class
