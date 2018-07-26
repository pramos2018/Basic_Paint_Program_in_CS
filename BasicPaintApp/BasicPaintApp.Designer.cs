namespace NS_BasicPaintApp
{
    partial class BasicPaintApp
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
            this.shortCutsGroup = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.setupGBox = new System.Windows.Forms.GroupBox();
            this.lblFill = new System.Windows.Forms.Label();
            this.ckBoxFill = new System.Windows.Forms.CheckBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblPSize = new System.Windows.Forms.Label();
            this.penSize = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.menuGroup = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.clearScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shapDropBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInput = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.shortCutsGroup.SuspendLayout();
            this.setupGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).BeginInit();
            this.menuGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortCutsGroup
            // 
            this.shortCutsGroup.Controls.Add(this.btnExit);
            this.shortCutsGroup.Controls.Add(this.setupGBox);
            this.shortCutsGroup.Controls.Add(this.btnColor);
            this.shortCutsGroup.Controls.Add(this.btnFont);
            this.shortCutsGroup.Controls.Add(this.btnPaste);
            this.shortCutsGroup.Controls.Add(this.btnCopy);
            this.shortCutsGroup.Controls.Add(this.btnCut);
            this.shortCutsGroup.Location = new System.Drawing.Point(12, 12);
            this.shortCutsGroup.Name = "shortCutsGroup";
            this.shortCutsGroup.Size = new System.Drawing.Size(73, 442);
            this.shortCutsGroup.TabIndex = 1;
            this.shortCutsGroup.TabStop = false;
            this.shortCutsGroup.Text = "ShortCuts";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 406);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // setupGBox
            // 
            this.setupGBox.Controls.Add(this.lblFill);
            this.setupGBox.Controls.Add(this.ckBoxFill);
            this.setupGBox.Controls.Add(this.txtSize);
            this.setupGBox.Controls.Add(this.lblPSize);
            this.setupGBox.Controls.Add(this.penSize);
            this.setupGBox.Controls.Add(this.lblWidth);
            this.setupGBox.Location = new System.Drawing.Point(6, 212);
            this.setupGBox.Name = "setupGBox";
            this.setupGBox.Size = new System.Drawing.Size(62, 188);
            this.setupGBox.TabIndex = 3;
            this.setupGBox.TabStop = false;
            this.setupGBox.Text = "Setup";
            // 
            // lblFill
            // 
            this.lblFill.AutoSize = true;
            this.lblFill.Location = new System.Drawing.Point(9, 107);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(41, 13);
            this.lblFill.TabIndex = 6;
            this.lblFill.Text = "Shape:";
            // 
            // ckBoxFill
            // 
            this.ckBoxFill.AutoSize = true;
            this.ckBoxFill.Location = new System.Drawing.Point(9, 123);
            this.ckBoxFill.Name = "ckBoxFill";
            this.ckBoxFill.Size = new System.Drawing.Size(38, 17);
            this.ckBoxFill.TabIndex = 5;
            this.ckBoxFill.Text = "Fill";
            this.ckBoxFill.UseVisualStyleBackColor = true;
            this.ckBoxFill.CheckedChanged += new System.EventHandler(this.ckBoxFill_CheckedChanged);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(9, 78);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(42, 20);
            this.txtSize.TabIndex = 4;
            this.txtSize.MouseLeave += new System.EventHandler(this.txtSize_MouseLeave);
            // 
            // lblPSize
            // 
            this.lblPSize.AutoSize = true;
            this.lblPSize.Location = new System.Drawing.Point(6, 16);
            this.lblPSize.Name = "lblPSize";
            this.lblPSize.Size = new System.Drawing.Size(52, 13);
            this.lblPSize.TabIndex = 3;
            this.lblPSize.Text = "Pen Size:";
            // 
            // penSize
            // 
            this.penSize.Location = new System.Drawing.Point(9, 32);
            this.penSize.Name = "penSize";
            this.penSize.Size = new System.Drawing.Size(42, 20);
            this.penSize.TabIndex = 2;
            this.penSize.ValueChanged += new System.EventHandler(this.penSize_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(9, 62);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(30, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Size:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(6, 174);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(58, 32);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(6, 136);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(58, 32);
            this.btnFont.TabIndex = 1;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(6, 98);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(58, 32);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(6, 60);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(58, 32);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(6, 19);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(58, 32);
            this.btnCut.TabIndex = 1;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // menuGroup
            // 
            this.menuGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuGroup.Controls.Add(this.menuStrip1);
            this.menuGroup.Location = new System.Drawing.Point(91, 12);
            this.menuGroup.Name = "menuGroup";
            this.menuGroup.Size = new System.Drawing.Size(506, 51);
            this.menuGroup.TabIndex = 2;
            this.menuGroup.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.clearScreenToolStripMenuItem,
            this.toolStripMenuItem1,
            this.shapDropBox,
            this.toolStripMenuItem2,
            this.txtInput});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 23);
            this.menuFile.Text = "&File";
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.newFileToolStripMenuItem.Text = "&New File";
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openFileToolStripMenuItem.Text = "&Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveFileToolStripMenuItem.Text = "&Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.saveFileAsToolStripMenuItem.Text = "Save File &As";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.saveFileAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(52, 23);
            this.menuHelp.Text = "&About";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // clearScreenToolStripMenuItem
            // 
            this.clearScreenToolStripMenuItem.Name = "clearScreenToolStripMenuItem";
            this.clearScreenToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
            this.clearScreenToolStripMenuItem.Text = "Clear";
            this.clearScreenToolStripMenuItem.Click += new System.EventHandler(this.clearScreenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 23);
            this.toolStripMenuItem1.Text = "Shape:";
            // 
            // shapDropBox
            // 
            this.shapDropBox.DropDownWidth = 75;
            this.shapDropBox.Name = "shapDropBox";
            this.shapDropBox.Size = new System.Drawing.Size(75, 23);
            this.shapDropBox.SelectedIndexChanged += new System.EventHandler(this.shapDropBox_SelectedIndexChanged);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 23);
            this.toolStripMenuItem2.Text = "Text:";
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(175, 23);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(91, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 363);
            this.panel1.TabIndex = 3;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(91, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Selected Shape:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 469);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuGroup);
            this.Controls.Add(this.shortCutsGroup);
            this.Name = "Form5";
            this.Text = "Basic Paint Program";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResizeEnd += new System.EventHandler(this.Form5_ResizeEnd);
            this.shortCutsGroup.ResumeLayout(false);
            this.setupGBox.ResumeLayout(false);
            this.setupGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penSize)).EndInit();
            this.menuGroup.ResumeLayout(false);
            this.menuGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox shortCutsGroup;
        private System.Windows.Forms.GroupBox menuGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox shapDropBox;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox setupGBox;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblPSize;
        private System.Windows.Forms.NumericUpDown penSize;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.CheckBox ckBoxFill;
        private System.Windows.Forms.ToolStripMenuItem clearScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox txtInput;
        private System.Windows.Forms.Label lblStatus;
    }
}