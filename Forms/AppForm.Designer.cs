namespace BinViewer.Front
{
	partial class AppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNumericBaseConverter = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslViewMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBytesByLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBytesByGroup = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbFileViewer = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBytesByGroup = new System.Windows.Forms.ComboBox();
            this.lblBytesByGroup = new System.Windows.Forms.Label();
            this.cboBytesByLine = new System.Windows.Forms.ComboBox();
            this.lblBytesByLine = new System.Windows.Forms.Label();
            this.cboViewMode = new System.Windows.Forms.ComboBox();
            this.lblViewMode = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiClose,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(180, 22);
            this.tsmiOpen.Text = "Open...";
            this.tsmiOpen.Click += new System.EventHandler(this.Open);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(180, 22);
            this.tsmiClose.Text = "Close";
            this.tsmiClose.Click += new System.EventHandler(this.Close);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNumericBaseConverter});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // tsmiNumericBaseConverter
            // 
            this.tsmiNumericBaseConverter.Name = "tsmiNumericBaseConverter";
            this.tsmiNumericBaseConverter.Size = new System.Drawing.Size(200, 22);
            this.tsmiNumericBaseConverter.Text = "Numeric base converter";
            this.tsmiNumericBaseConverter.Click += new System.EventHandler(this.tsmiNumericBaseConverter_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(180, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFileName,
            this.tsslViewMode,
            this.tsslBytesByLine,
            this.tsslBytesByGroup});
            this.statusStrip.Location = new System.Drawing.Point(0, 426);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // tsslFileName
            // 
            this.tsslFileName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslFileName.Name = "tsslFileName";
            this.tsslFileName.Size = new System.Drawing.Size(46, 19);
            this.tsslFileName.Text = "No file";
            // 
            // tsslViewMode
            // 
            this.tsslViewMode.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslViewMode.Name = "tsslViewMode";
            this.tsslViewMode.Size = new System.Drawing.Size(70, 19);
            this.tsslViewMode.Text = "View mode";
            // 
            // tsslBytesByLine
            // 
            this.tsslBytesByLine.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslBytesByLine.Name = "tsslBytesByLine";
            this.tsslBytesByLine.Size = new System.Drawing.Size(77, 19);
            this.tsslBytesByLine.Text = "Bytes by line";
            // 
            // tsslBytesByGroup
            // 
            this.tsslBytesByGroup.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslBytesByGroup.Name = "tsslBytesByGroup";
            this.tsslBytesByGroup.Size = new System.Drawing.Size(90, 19);
            this.tsslBytesByGroup.Text = "Bytes by group";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.rtbFileViewer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 402);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // rtbFileViewer
            // 
            this.rtbFileViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbFileViewer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFileViewer.Location = new System.Drawing.Point(123, 3);
            this.rtbFileViewer.Name = "rtbFileViewer";
            this.rtbFileViewer.ReadOnly = true;
            this.rtbFileViewer.Size = new System.Drawing.Size(674, 396);
            this.rtbFileViewer.TabIndex = 0;
            this.rtbFileViewer.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBytesByGroup);
            this.groupBox1.Controls.Add(this.lblBytesByGroup);
            this.groupBox1.Controls.Add(this.cboBytesByLine);
            this.groupBox1.Controls.Add(this.lblBytesByLine);
            this.groupBox1.Controls.Add(this.cboViewMode);
            this.groupBox1.Controls.Add(this.lblViewMode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cboBytesByGroup
            // 
            this.cboBytesByGroup.DisplayMember = "3";
            this.cboBytesByGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBytesByGroup.FormattingEnabled = true;
            this.cboBytesByGroup.Items.AddRange(new object[] {
            "1 (8 bits)",
            "2 (16 bits)",
            "4 (32 bits)",
            "8 (64 bits)"});
            this.cboBytesByGroup.Location = new System.Drawing.Point(6, 125);
            this.cboBytesByGroup.Name = "cboBytesByGroup";
            this.cboBytesByGroup.Size = new System.Drawing.Size(102, 21);
            this.cboBytesByGroup.TabIndex = 2;
            this.cboBytesByGroup.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // lblBytesByGroup
            // 
            this.lblBytesByGroup.AutoSize = true;
            this.lblBytesByGroup.Location = new System.Drawing.Point(6, 109);
            this.lblBytesByGroup.Name = "lblBytesByGroup";
            this.lblBytesByGroup.Size = new System.Drawing.Size(77, 13);
            this.lblBytesByGroup.TabIndex = 4;
            this.lblBytesByGroup.Text = "Bytes by group";
            // 
            // cboBytesByLine
            // 
            this.cboBytesByLine.DisplayMember = "0";
            this.cboBytesByLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBytesByLine.FormattingEnabled = true;
            this.cboBytesByLine.Items.AddRange(new object[] {
            "1 (8 bits)",
            "2 (16 bits)",
            "4 (32 bits)",
            "8 (64 bits)"});
            this.cboBytesByLine.Location = new System.Drawing.Point(6, 81);
            this.cboBytesByLine.Name = "cboBytesByLine";
            this.cboBytesByLine.Size = new System.Drawing.Size(102, 21);
            this.cboBytesByLine.TabIndex = 1;
            this.cboBytesByLine.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // lblBytesByLine
            // 
            this.lblBytesByLine.AutoSize = true;
            this.lblBytesByLine.Location = new System.Drawing.Point(6, 65);
            this.lblBytesByLine.Name = "lblBytesByLine";
            this.lblBytesByLine.Size = new System.Drawing.Size(66, 13);
            this.lblBytesByLine.TabIndex = 2;
            this.lblBytesByLine.Text = "Bytes by line";
            // 
            // cboViewMode
            // 
            this.cboViewMode.DisplayMember = "0";
            this.cboViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboViewMode.FormattingEnabled = true;
            this.cboViewMode.Items.AddRange(new object[] {
            "Bit",
            "Byte",
            "Octal",
            "Decimal",
            "Hexadecimal",
            "ASCII",
            "UTF-8",
            "Base64"});
            this.cboViewMode.Location = new System.Drawing.Point(6, 37);
            this.cboViewMode.Name = "cboViewMode";
            this.cboViewMode.Size = new System.Drawing.Size(102, 21);
            this.cboViewMode.TabIndex = 0;
            this.cboViewMode.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // lblViewMode
            // 
            this.lblViewMode.AutoSize = true;
            this.lblViewMode.Location = new System.Drawing.Point(6, 21);
            this.lblViewMode.Name = "lblViewMode";
            this.lblViewMode.Size = new System.Drawing.Size(59, 13);
            this.lblViewMode.TabIndex = 0;
            this.lblViewMode.Text = "View mode";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Open file";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadFile);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bin Viewer";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.ToolStripMenuItem tsmiClose;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RichTextBox rtbFileViewer;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cboBytesByLine;
		private System.Windows.Forms.Label lblBytesByLine;
		private System.Windows.Forms.ComboBox cboViewMode;
		private System.Windows.Forms.Label lblViewMode;
		private System.Windows.Forms.ComboBox cboBytesByGroup;
		private System.Windows.Forms.Label lblBytesByGroup;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripStatusLabel tsslViewMode;
		private System.Windows.Forms.ToolStripStatusLabel tsslBytesByLine;
		private System.Windows.Forms.ToolStripStatusLabel tsslBytesByGroup;
		private System.Windows.Forms.ToolStripMenuItem tsmiNumericBaseConverter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

