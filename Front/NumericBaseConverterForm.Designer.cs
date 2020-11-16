namespace BinViewer.Front
{
	partial class NumericBaseConverterForm
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtOctal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDecimal = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBinary = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtHexadecimal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtOctal);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDecimal);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtBinary);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtHexadecimal);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(532, 134);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Please, type the number in one of below fields";
			// 
			// txtOctal
			// 
			this.txtOctal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOctal.Location = new System.Drawing.Point(86, 103);
			this.txtOctal.MaxLength = 64;
			this.txtOctal.Name = "txtOctal";
			this.txtOctal.Size = new System.Drawing.Size(427, 20);
			this.txtOctal.TabIndex = 3;
			this.txtOctal.TextChanged += new System.EventHandler(this.TBsTextChanged);
			this.txtOctal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBsKeyDown);
			this.txtOctal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBsKeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 16;
			this.label4.Text = "Octal";
			// 
			// txtDecimal
			// 
			this.txtDecimal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDecimal.Location = new System.Drawing.Point(86, 77);
			this.txtDecimal.MaxLength = 64;
			this.txtDecimal.Name = "txtDecimal";
			this.txtDecimal.Size = new System.Drawing.Size(427, 20);
			this.txtDecimal.TabIndex = 2;
			this.txtDecimal.TextChanged += new System.EventHandler(this.TBsTextChanged);
			this.txtDecimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBsKeyDown);
			this.txtDecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBsKeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Decimal";
			// 
			// txtBinary
			// 
			this.txtBinary.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBinary.Location = new System.Drawing.Point(86, 51);
			this.txtBinary.MaxLength = 64;
			this.txtBinary.Name = "txtBinary";
			this.txtBinary.Size = new System.Drawing.Size(427, 20);
			this.txtBinary.TabIndex = 1;
			this.txtBinary.TextChanged += new System.EventHandler(this.TBsTextChanged);
			this.txtBinary.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBsKeyDown);
			this.txtBinary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBsKeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Binary";
			// 
			// txtHexadecimal
			// 
			this.txtHexadecimal.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHexadecimal.Location = new System.Drawing.Point(86, 25);
			this.txtHexadecimal.MaxLength = 16;
			this.txtHexadecimal.Name = "txtHexadecimal";
			this.txtHexadecimal.Size = new System.Drawing.Size(427, 20);
			this.txtHexadecimal.TabIndex = 0;
			this.txtHexadecimal.TextChanged += new System.EventHandler(this.TBsTextChanged);
			this.txtHexadecimal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBsKeyDown);
			this.txtHexadecimal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBsKeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Hexadecimal";
			// 
			// NumericBaseConverterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 134);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "NumericBaseConverterForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Numeric Base Converter";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtOctal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDecimal;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBinary;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtHexadecimal;
		private System.Windows.Forms.Label label1;
	}
}