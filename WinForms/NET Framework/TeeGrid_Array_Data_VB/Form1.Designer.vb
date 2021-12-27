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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.bObject = New System.Windows.Forms.Button()
        Me.bString = New System.Windows.Forms.Button()
        Me.bFloat = New System.Windows.Forms.Button()
        Me.bInteger = New System.Windows.Forms.Button()
        Me.bRecord = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.teeGrid1 = New Steema.TeeGrid.WinForm.TGrid()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.bObject)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bString)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bFloat)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bInteger)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bRecord)
        Me.SplitContainer1.Panel1.Controls.Add(Me.button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(814, 523)
        Me.SplitContainer1.SplitterDistance = 69
        Me.SplitContainer1.TabIndex = 0
        '
        'bObject
        '
        Me.bObject.BackColor = System.Drawing.Color.Transparent
        Me.bObject.Location = New System.Drawing.Point(521, 21)
        Me.bObject.Name = "bObject"
        Me.bObject.Size = New System.Drawing.Size(75, 23)
        Me.bObject.TabIndex = 11
        Me.bObject.Text = "Object"
        Me.bObject.UseVisualStyleBackColor = False
        '
        'bString
        '
        Me.bString.BackColor = System.Drawing.Color.Transparent
        Me.bString.Location = New System.Drawing.Point(440, 21)
        Me.bString.Name = "bString"
        Me.bString.Size = New System.Drawing.Size(75, 23)
        Me.bString.TabIndex = 10
        Me.bString.Text = "String ID"
        Me.bString.UseVisualStyleBackColor = False
        '
        'bFloat
        '
        Me.bFloat.BackColor = System.Drawing.Color.Transparent
        Me.bFloat.Location = New System.Drawing.Point(359, 21)
        Me.bFloat.Name = "bFloat"
        Me.bFloat.Size = New System.Drawing.Size(75, 23)
        Me.bFloat.TabIndex = 9
        Me.bFloat.Text = "Float ID"
        Me.bFloat.UseVisualStyleBackColor = False
        '
        'bInteger
        '
        Me.bInteger.BackColor = System.Drawing.Color.Transparent
        Me.bInteger.Location = New System.Drawing.Point(278, 21)
        Me.bInteger.Name = "bInteger"
        Me.bInteger.Size = New System.Drawing.Size(75, 23)
        Me.bInteger.TabIndex = 8
        Me.bInteger.Text = "Integer ID"
        Me.bInteger.UseVisualStyleBackColor = False
        '
        'bRecord
        '
        Me.bRecord.BackColor = System.Drawing.Color.Transparent
        Me.bRecord.Location = New System.Drawing.Point(197, 21)
        Me.bRecord.Name = "bRecord"
        Me.bRecord.Size = New System.Drawing.Size(75, 23)
        Me.bRecord.TabIndex = 7
        Me.bRecord.Text = "Record"
        Me.bRecord.UseVisualStyleBackColor = False
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Transparent
        Me.button1.Location = New System.Drawing.Point(27, 21)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Edit..."
        Me.button1.UseVisualStyleBackColor = False
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.teeGrid1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.button3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.button2)
        Me.SplitContainer2.Size = New System.Drawing.Size(814, 450)
        Me.SplitContainer2.SplitterDistance = 362
        Me.SplitContainer2.TabIndex = 0
        '
        'teeGrid1
        '
        Me.teeGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.teeGrid1.Location = New System.Drawing.Point(0, 0)
        Me.teeGrid1.Name = "teeGrid1"
        Me.teeGrid1.Selected.ScrollToView = False
        Me.teeGrid1.Size = New System.Drawing.Size(814, 362)
        Me.teeGrid1.TabIndex = 0
        Me.teeGrid1.Text = "TGrid1"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.Transparent
        Me.button3.Location = New System.Drawing.Point(121, 25)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 3
        Me.button3.Text = "Footer..."
        Me.button3.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Transparent
        Me.button2.Location = New System.Drawing.Point(16, 25)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Header..."
        Me.button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 523)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "TeeGrid using Array as Data"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Private WithEvents bObject As Button
    Private WithEvents bString As Button
    Private WithEvents bFloat As Button
    Private WithEvents bInteger As Button
    Private WithEvents bRecord As Button
    Private WithEvents button1 As Button
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Friend WithEvents teeGrid1 As Steema.TeeGrid.WinForm.TGrid
End Class
