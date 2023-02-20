namespace Binary2Decimal
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
            this.binIn = new System.Windows.Forms.TextBox();
            this.dec = new System.Windows.Forms.Button();
            this.binary = new System.Windows.Forms.Button();
            this.decIn = new System.Windows.Forms.TextBox();
            this.binaryOut = new System.Windows.Forms.TextBox();
            this.decOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // binIn
            // 
            this.binIn.Location = new System.Drawing.Point(73, 200);
            this.binIn.Name = "binIn";
            this.binIn.Size = new System.Drawing.Size(343, 38);
            this.binIn.TabIndex = 0;
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.Color.DodgerBlue;
            this.dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec.ForeColor = System.Drawing.Color.Transparent;
            this.dec.Location = new System.Drawing.Point(117, 305);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(244, 86);
            this.dec.TabIndex = 1;
            this.dec.Text = "Convert to decimal";
            this.dec.UseVisualStyleBackColor = false;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // binary
            // 
            this.binary.BackColor = System.Drawing.Color.DodgerBlue;
            this.binary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.binary.ForeColor = System.Drawing.Color.Transparent;
            this.binary.Location = new System.Drawing.Point(639, 305);
            this.binary.Name = "binary";
            this.binary.Size = new System.Drawing.Size(244, 86);
            this.binary.TabIndex = 3;
            this.binary.Text = "Convert to bianry";
            this.binary.UseVisualStyleBackColor = false;
            this.binary.Click += new System.EventHandler(this.binary_Click);
            // 
            // decIn
            // 
            this.decIn.Location = new System.Drawing.Point(602, 200);
            this.decIn.Name = "decIn";
            this.decIn.Size = new System.Drawing.Size(343, 38);
            this.decIn.TabIndex = 2;
            // 
            // binaryOut
            // 
            this.binaryOut.Location = new System.Drawing.Point(602, 455);
            this.binaryOut.Name = "binaryOut";
            this.binaryOut.Size = new System.Drawing.Size(343, 38);
            this.binaryOut.TabIndex = 6;
            // 
            // decOut
            // 
            this.decOut.Location = new System.Drawing.Point(73, 455);
            this.decOut.Name = "decOut";
            this.decOut.Size = new System.Drawing.Size(343, 38);
            this.decOut.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1030, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "Binary to Decimal Converter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1041, 661);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binaryOut);
            this.Controls.Add(this.decOut);
            this.Controls.Add(this.binary);
            this.Controls.Add(this.decIn);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.binIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox binIn;
		private System.Windows.Forms.Button dec;
		private System.Windows.Forms.Button binary;
		private System.Windows.Forms.TextBox decIn;
		private System.Windows.Forms.TextBox binaryOut;
		private System.Windows.Forms.TextBox decOut;
        private System.Windows.Forms.Label label1;
    }
}

