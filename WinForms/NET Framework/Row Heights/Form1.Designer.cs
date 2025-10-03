namespace TeeGrid_WinForm_Row_Heights
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.button3 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.cbMultiLine = new System.Windows.Forms.CheckBox();
      this.tTeeGrid1 = new Steema.TeeGrid.WinForm.TGrid();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
      this.splitContainer1.Panel1.Controls.Add(this.button3);
      this.splitContainer1.Panel1.Controls.Add(this.button2);
      this.splitContainer1.Panel1.Controls.Add(this.button1);
      this.splitContainer1.Panel1.Controls.Add(this.cbMultiLine);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tTeeGrid1);
      this.splitContainer1.Size = new System.Drawing.Size(828, 523);
      this.splitContainer1.SplitterDistance = 64;
      this.splitContainer1.TabIndex = 0;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(715, 22);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(78, 21);
      this.button3.TabIndex = 3;
      this.button3.Text = "mod colours";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(207, 22);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(93, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "Benchmark";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(126, 22);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Edit...";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // cbMultiLine
      // 
      this.cbMultiLine.AutoSize = true;
      this.cbMultiLine.Checked = true;
      this.cbMultiLine.CheckState = System.Windows.Forms.CheckState.Checked;
      this.cbMultiLine.Location = new System.Drawing.Point(12, 26);
      this.cbMultiLine.Name = "cbMultiLine";
      this.cbMultiLine.Size = new System.Drawing.Size(95, 17);
      this.cbMultiLine.TabIndex = 0;
      this.cbMultiLine.Text = "Multi-Line Text";
      this.cbMultiLine.UseVisualStyleBackColor = true;
      this.cbMultiLine.CheckedChanged += new System.EventHandler(this.CbMultiLine_CheckedChanged);
      // 
      // tTeeGrid1
      // 
      this.tTeeGrid1.BackColor = System.Drawing.Color.White;
      this.tTeeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tTeeGrid1.Location = new System.Drawing.Point(0, 0);
      this.tTeeGrid1.Name = "tTeeGrid1";
      this.tTeeGrid1.Size = new System.Drawing.Size(828, 455);
      this.tTeeGrid1.TabIndex = 0;
      this.tTeeGrid1.Text = "tTeeGrid1";
      this.tTeeGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tTeeGrid1_MouseClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(828, 523);
      this.Controls.Add(this.splitContainer1);
      this.Name = "Form1";
      this.Text = "TeeGrid Row Heights";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox cbMultiLine;
		private Steema.TeeGrid.WinForm.TGrid tTeeGrid1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

