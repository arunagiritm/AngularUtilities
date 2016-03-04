namespace WindowsFormsApplication1
{
    partial class frmAUnit
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnJsonSelect = new System.Windows.Forms.Button();
            this.btnDestSelect = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileSelector = new System.Windows.Forms.OpenFileDialog();
            this.DestFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAngularFactoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJasmineTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create JSON Tree";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 71);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(352, 526);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select the Unit Test Files";
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.errorProvider1.SetError(this.txtSource, "Please Select the JSON file");
            this.txtSource.Location = new System.Drawing.Point(195, 35);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(185, 20);
            this.txtSource.TabIndex = 3;
            // 
            // btnJsonSelect
            // 
            this.btnJsonSelect.Location = new System.Drawing.Point(386, 33);
            this.btnJsonSelect.Name = "btnJsonSelect";
            this.btnJsonSelect.Size = new System.Drawing.Size(36, 23);
            this.btnJsonSelect.TabIndex = 4;
            this.btnJsonSelect.Text = "...";
            this.btnJsonSelect.UseVisualStyleBackColor = true;
            this.btnJsonSelect.Click += new System.EventHandler(this.btnJsonSelect_Click);
            // 
            // btnDestSelect
            // 
            this.btnDestSelect.Location = new System.Drawing.Point(839, 31);
            this.btnDestSelect.Name = "btnDestSelect";
            this.btnDestSelect.Size = new System.Drawing.Size(36, 23);
            this.btnDestSelect.TabIndex = 7;
            this.btnDestSelect.Text = "...";
            this.btnDestSelect.UseVisualStyleBackColor = true;
            this.btnDestSelect.Click += new System.EventHandler(this.btnDestSelect_Click);
            // 
            // txtDest
            // 
            this.errorProvider1.SetError(this.txtDest, "Please select the Destination folder");
            this.txtDest.Location = new System.Drawing.Point(648, 33);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(185, 20);
            this.txtDest.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the Destination Folder Path";
            // 
            // FileSelector
            // 
            this.FileSelector.Filter = "\"Spec\" | *spec.js";
            this.FileSelector.Multiselect = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Create Angular Factories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 643);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(36, 228);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAngularFactoriesToolStripMenuItem,
            this.createJasmineTestToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // createAngularFactoriesToolStripMenuItem
            // 
            this.createAngularFactoriesToolStripMenuItem.Name = "createAngularFactoriesToolStripMenuItem";
            this.createAngularFactoriesToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createAngularFactoriesToolStripMenuItem.Text = "Create Angular Factories";
            // 
            // createJasmineTestToolStripMenuItem
            // 
            this.createJasmineTestToolStripMenuItem.Name = "createJasmineTestToolStripMenuItem";
            this.createJasmineTestToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.createJasmineTestToolStripMenuItem.Text = "Create Jasmine Test ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(299, 614);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(391, 70);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(784, 527);
            this.webBrowser1.TabIndex = 14;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // frmAUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 666);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDestSelect);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJsonSelect);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Angular Factories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnJsonSelect;
        private System.Windows.Forms.Button btnDestSelect;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog FileSelector;
        private System.Windows.Forms.FolderBrowserDialog DestFolderSelector;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAngularFactoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createJasmineTestToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

