namespace WindowsFormsApplication1
{
    partial class frmJasmine
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
            this.btnCreateJSONTree = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnJsonSelect = new System.Windows.Forms.Button();
            this.btnDestSelect = new System.Windows.Forms.Button();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JsonFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.DestFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCreateJasmineTest = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbJasmineExpect = new System.Windows.Forms.ComboBox();
            this.txtFieldName = new System.Windows.Forms.TextBox();
            this.txtJavascriptFile = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAngularFactoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createJasmineTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JasmineExpect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPre = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExpectedValue = new System.Windows.Forms.TextBox();
            this.txtActualValue = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnCreateJSTree = new System.Windows.Forms.Button();
            this.pnlJSFileSelection = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnJavascriptFile = new System.Windows.Forms.Button();
            this.cmbInputType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlJSFileSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateJSONTree
            // 
            this.btnCreateJSONTree.Location = new System.Drawing.Point(16, 410);
            this.btnCreateJSONTree.Name = "btnCreateJSONTree";
            this.btnCreateJSONTree.Size = new System.Drawing.Size(109, 23);
            this.btnCreateJSONTree.TabIndex = 0;
            this.btnCreateJSONTree.Text = "Create JSON Tree";
            this.btnCreateJSONTree.UseVisualStyleBackColor = true;
            this.btnCreateJSONTree.Click += new System.EventHandler(this.btnCreateJSONTree_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the Source JSON Path";
            // 
            // txtSource
            // 
            this.errorProvider1.SetError(this.txtSource, "Please Select the JSON file");
            this.txtSource.Location = new System.Drawing.Point(195, 64);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(185, 20);
            this.txtSource.TabIndex = 3;
            // 
            // btnJsonSelect
            // 
            this.btnJsonSelect.Location = new System.Drawing.Point(386, 62);
            this.btnJsonSelect.Name = "btnJsonSelect";
            this.btnJsonSelect.Size = new System.Drawing.Size(36, 23);
            this.btnJsonSelect.TabIndex = 4;
            this.btnJsonSelect.Text = "...";
            this.btnJsonSelect.UseVisualStyleBackColor = true;
            this.btnJsonSelect.Click += new System.EventHandler(this.btnJsonSelect_Click);
            // 
            // btnDestSelect
            // 
            this.btnDestSelect.Location = new System.Drawing.Point(386, 100);
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
            this.txtDest.Location = new System.Drawing.Point(195, 102);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(185, 20);
            this.txtDest.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the Destination Folder Path";
            // 
            // JsonFileSelector
            // 
            this.JsonFileSelector.Filter = "\"json file\" | *.json";
            // 
            // btnCreateJasmineTest
            // 
            this.btnCreateJasmineTest.Location = new System.Drawing.Point(169, 410);
            this.btnCreateJasmineTest.Name = "btnCreateJasmineTest";
            this.btnCreateJasmineTest.Size = new System.Drawing.Size(140, 23);
            this.btnCreateJasmineTest.TabIndex = 8;
            this.btnCreateJasmineTest.Text = "Create Jasmine Test";
            this.btnCreateJasmineTest.UseVisualStyleBackColor = true;
            this.btnCreateJasmineTest.Click += new System.EventHandler(this.btnCreateJasmineTest_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbJasmineExpect
            // 
            this.cmbJasmineExpect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJasmineExpect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.errorProvider1.SetError(this.cmbJasmineExpect, "Jasmine Expect cannot be empty");
            this.cmbJasmineExpect.FormattingEnabled = true;
            this.cmbJasmineExpect.Items.AddRange(new object[] {
            "toBe",
            "toEqual",
            "toMatch",
            "toBeDefined",
            "toBeNull",
            "toBeTruthy",
            "toContain",
            "toBeLessThan",
            "toBeGreaterThan",
            "toBeCloseTo",
            "toThrow",
            "toThrowError",
            "toHaveBeenCalled"});
            this.cmbJasmineExpect.Location = new System.Drawing.Point(204, 29);
            this.cmbJasmineExpect.Name = "cmbJasmineExpect";
            this.cmbJasmineExpect.Size = new System.Drawing.Size(121, 21);
            this.cmbJasmineExpect.TabIndex = 32;
            // 
            // txtFieldName
            // 
            this.errorProvider1.SetError(this.txtFieldName, "Field Name cannot be empty");
            this.txtFieldName.Location = new System.Drawing.Point(6, 29);
            this.txtFieldName.Name = "txtFieldName";
            this.txtFieldName.ReadOnly = true;
            this.txtFieldName.Size = new System.Drawing.Size(100, 20);
            this.txtFieldName.TabIndex = 25;
            // 
            // txtJavascriptFile
            // 
            this.errorProvider1.SetError(this.txtJavascriptFile, "Please select the Javascript file ");
            this.txtJavascriptFile.Location = new System.Drawing.Point(184, 6);
            this.txtJavascriptFile.Name = "txtJavascriptFile";
            this.txtJavascriptFile.Size = new System.Drawing.Size(185, 20);
            this.txtJavascriptFile.TabIndex = 34;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(534, 410);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(464, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(486, 365);
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
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
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
            this.btnClose.Location = new System.Drawing.Point(353, 410);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FieldName,
            this.Pre,
            this.JasmineExpect,
            this.ActualValue,
            this.ExpectedValue});
            this.dataGridView1.Location = new System.Drawing.Point(447, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(574, 171);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "Field Name";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            // 
            // Pre
            // 
            this.Pre.HeaderText = "Pre";
            this.Pre.Name = "Pre";
            this.Pre.ReadOnly = true;
            this.Pre.Width = 50;
            // 
            // JasmineExpect
            // 
            this.JasmineExpect.HeaderText = "Jasmine Expect";
            this.JasmineExpect.Name = "JasmineExpect";
            this.JasmineExpect.ReadOnly = true;
            this.JasmineExpect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JasmineExpect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ActualValue
            // 
            this.ActualValue.HeaderText = "Actutal Value";
            this.ActualValue.Name = "ActualValue";
            this.ActualValue.ReadOnly = true;
            this.ActualValue.Width = 125;
            // 
            // ExpectedValue
            // 
            this.ExpectedValue.HeaderText = "Expected Value";
            this.ExpectedValue.Name = "ExpectedValue";
            this.ExpectedValue.ReadOnly = true;
            this.ExpectedValue.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbPre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbJasmineExpect);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtExpectedValue);
            this.panel1.Controls.Add(this.txtActualValue);
            this.panel1.Controls.Add(this.txtFieldName);
            this.panel1.Location = new System.Drawing.Point(434, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 126);
            this.panel1.TabIndex = 25;
            // 
            // cmbPre
            // 
            this.cmbPre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPre.FormattingEnabled = true;
            this.cmbPre.Items.AddRange(new object[] {
            "not"});
            this.cmbPre.Location = new System.Drawing.Point(124, 29);
            this.cmbPre.Name = "cmbPre";
            this.cmbPre.Size = new System.Drawing.Size(52, 21);
            this.cmbPre.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Pre condition";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(431, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 94);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Expected Value";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Actual Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Jasmine Expect";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Field Name";
            // 
            // txtExpectedValue
            // 
            this.txtExpectedValue.Location = new System.Drawing.Point(466, 29);
            this.txtExpectedValue.Name = "txtExpectedValue";
            this.txtExpectedValue.Size = new System.Drawing.Size(97, 20);
            this.txtExpectedValue.TabIndex = 27;
            // 
            // txtActualValue
            // 
            this.txtActualValue.Location = new System.Drawing.Point(356, 29);
            this.txtActualValue.Name = "txtActualValue";
            this.txtActualValue.Size = new System.Drawing.Size(105, 20);
            this.txtActualValue.TabIndex = 26;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(28, 136);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(368, 268);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnCreateJSTree
            // 
            this.btnCreateJSTree.Location = new System.Drawing.Point(7, 410);
            this.btnCreateJSTree.Name = "btnCreateJSTree";
            this.btnCreateJSTree.Size = new System.Drawing.Size(140, 23);
            this.btnCreateJSTree.TabIndex = 29;
            this.btnCreateJSTree.Text = "Create Function Treee";
            this.btnCreateJSTree.UseVisualStyleBackColor = true;
            this.btnCreateJSTree.Click += new System.EventHandler(this.btnCreateJSTree_Click);
            // 
            // pnlJSFileSelection
            // 
            this.pnlJSFileSelection.Controls.Add(this.label8);
            this.pnlJSFileSelection.Controls.Add(this.txtJavascriptFile);
            this.pnlJSFileSelection.Controls.Add(this.btnJavascriptFile);
            this.pnlJSFileSelection.Location = new System.Drawing.Point(11, 58);
            this.pnlJSFileSelection.Name = "pnlJSFileSelection";
            this.pnlJSFileSelection.Size = new System.Drawing.Size(425, 35);
            this.pnlJSFileSelection.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Select the Javascript file";
            // 
            // btnJavascriptFile
            // 
            this.btnJavascriptFile.Location = new System.Drawing.Point(375, 6);
            this.btnJavascriptFile.Name = "btnJavascriptFile";
            this.btnJavascriptFile.Size = new System.Drawing.Size(36, 23);
            this.btnJavascriptFile.TabIndex = 35;
            this.btnJavascriptFile.Text = "...";
            this.btnJavascriptFile.UseVisualStyleBackColor = true;
            // 
            // cmbInputType
            // 
            this.cmbInputType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbInputType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInputType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInputType.FormattingEnabled = true;
            this.cmbInputType.Items.AddRange(new object[] {
            "JSON",
            "Javascript"});
            this.cmbInputType.Location = new System.Drawing.Point(195, 31);
            this.cmbInputType.Name = "cmbInputType";
            this.cmbInputType.Size = new System.Drawing.Size(185, 21);
            this.cmbInputType.TabIndex = 34;
            this.cmbInputType.SelectedIndexChanged += new System.EventHandler(this.cmbInputType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Select Input Type";
            // 
            // frmJasmine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbInputType);
            this.Controls.Add(this.btnCreateJSTree);
            this.Controls.Add(this.pnlJSFileSelection);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCreateJasmineTest);
            this.Controls.Add(this.btnDestSelect);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnJsonSelect);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnCreateJSONTree);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmJasmine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jasmine Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlJSFileSelection.ResumeLayout(false);
            this.pnlJSFileSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateJSONTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnJsonSelect;
        private System.Windows.Forms.Button btnDestSelect;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog JsonFileSelector;
        private System.Windows.Forms.FolderBrowserDialog DestFolderSelector;
        private System.Windows.Forms.Button btnCreateJasmineTest;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbJasmineExpect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExpectedValue;
        private System.Windows.Forms.TextBox txtActualValue;
        private System.Windows.Forms.TextBox txtFieldName;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cmbPre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn JasmineExpect;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedValue;
        private System.Windows.Forms.Button btnCreateJSTree;
        private System.Windows.Forms.Panel pnlJSFileSelection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJavascriptFile;
        private System.Windows.Forms.Button btnJavascriptFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbInputType;
    }
}

