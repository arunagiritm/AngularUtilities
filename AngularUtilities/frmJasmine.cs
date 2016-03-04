using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmJasmine : Form
    {
        DataTable dt =new DataTable();
        Int32 intParentId = 0;
        bool bEditMode = false;
        Int32 intGridRow = 0;
         public frmJasmine()
         {
             InitializeComponent();
             errorProvider1.Clear();
             cmbInputType.SelectedIndex = 0;
         }

       
      

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnJsonSelect_Click(object sender, EventArgs e)
        {
            JsonFileSelector.ShowDialog();
            txtSource.Text = JsonFileSelector.FileName;
        }

        private void btnDestSelect_Click(object sender, EventArgs e)
        {
            DestFolderSelector.ShowDialog();
            txtDest.Text = DestFolderSelector.SelectedPath;
        }

     

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            Int32 rowid;
            rowid = Convert.ToInt32(e.Node.Tag);
            dt.Rows[rowid - 1]["Active"] = e.Node.Checked;
            foreach (TreeNode childnode in e.Node.Nodes)
            {
                childnode.Checked = e.Node.Checked;
                rowid=Convert.ToInt32( childnode.Tag);
                dt.Rows[rowid-1]["Active"] = e.Node.Checked;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ClearGridValues();
            bEditMode = false;
            intParentId = Convert.ToInt32(e.Node.Tag);
            if (e.Node.GetNodeCount(false)==0 ) //should be done only for child nodes
            {
                txtFieldName.Text = e.Node.Text;
            }
            else
            {
                txtFieldName.Text = string.Empty;
            }
            cmbJasmineExpect.Text = string.Empty;
            txtActualValue.Text = string.Empty;
            txtExpectedValue.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int irow;
            DataGridViewRow dvrow;
            if (ValidateGridItems())
            {
                if (bEditMode)
                {
                    irow = intGridRow;
                }
                else
                {
                    irow = dataGridView1.Rows.Add();
                }
                
                dvrow = dataGridView1.Rows[irow];
                dvrow.Cells["ID"].Value = intParentId.ToString();
                dvrow.Cells["FieldName"].Value = txtFieldName.Text;
                dvrow.Cells["Pre"].Value = cmbPre.Text;
                dvrow.Cells["JasmineExpect"].Value = cmbJasmineExpect.Text;
                dvrow.Cells["ActualValue"].Value = txtActualValue.Text;
                dvrow.Cells["ExpectedValue"].Value = txtExpectedValue.Text;
                ClearGridValues();
            }
        }

        private void ClearGridValues()
        {
            bEditMode = false;
            txtFieldName.Text = string.Empty;
            cmbPre.Text = string.Empty;
            cmbJasmineExpect.Text = string.Empty;
            txtActualValue.Text = string.Empty;
            txtExpectedValue.Text = string.Empty;
        }

        private bool ValidateGridItems()
        {
            errorProvider1.Clear();
            if (txtFieldName.Text==string.Empty)
            {
                errorProvider1.SetError(txtFieldName, "Field Name cannot be empty");
                return false;
            }
            else if (cmbJasmineExpect.Text == string.Empty)
            {
                errorProvider1.SetError(cmbJasmineExpect, "Jasmine conditon cannot be empty");
                return false;
            }
           
            return true;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearGridValues();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
                bEditMode = true;
                intGridRow = e.RowIndex;
                DataGridViewRow dvrow = dataGridView1.Rows[intGridRow];
                intParentId = Convert.ToInt32(dvrow.Cells["ID"].Value);
                txtFieldName.Text = dvrow.Cells["FieldName"].Value.ToString();
                cmbPre.Text = dvrow.Cells["Pre"].Value.ToString();
                cmbJasmineExpect.Text = dvrow.Cells["JasmineExpect"].Value.ToString();
                txtActualValue.Text = dvrow.Cells["ActualValue"].Value.ToString();
                txtExpectedValue.Text = dvrow.Cells["ExpectedValue"].Value.ToString();
            
            
        }

        private void btnCreateJasmineTest_Click(object sender, EventArgs e)
        {
            if (txtDest.Text.Trim()== string.Empty )
            {
                errorProvider1.SetError(txtDest, "Please select the Destination folder");
                return;

            }
            else if(txtJavascriptFile.Text.Trim() == string.Empty)
            {
                errorProvider1.SetError(txtJavascriptFile,"Please select the Javascript file for creating jasmine test");
                return;
            }
            createJasmineTest();
        }

        private void createJasmineTest()
        {
            string jFileContent = string.Empty;
            List<string> jMethods = new List<string>();
            if(!File.Exists(txtJavascriptFile.Text))
            {
                MessageBox.Show("The javascript file selected does not exist");
                return; 
            }
            jFileContent = File.ReadAllText(txtJavascriptFile.Text);
            if (jFileContent.Trim().Length<=0)
            {
                MessageBox.Show("The javascript file is empty");
                return;
            }
            jMethods = FindAllMethods(jFileContent);

        }

        private List<string> FindAllMethods(string jFileContent)
        {
            return new List<string>(); // to be modified
        }

        private void btnJavascriptFile_Click(object sender, EventArgs e)
        {
            JsonFileSelector.ShowDialog();
            txtJavascriptFile.Text = JsonFileSelector.FileName;
        }

   

        private void cmbInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInputType.Text=="JSON")
            {
                pnlJSFileSelection.Visible = false;
                btnCreateJSTree.Visible = false;
                btnCreateJSONTree.Visible = true;
                
            }
            else if(cmbInputType.Text=="Javascript")
            {
                pnlJSFileSelection.Visible = true;
                btnCreateJSTree.Visible = true;
                btnCreateJSONTree.Visible = false;

            }
        }

        private void btnCreateJSTree_Click(object sender, EventArgs e)
        {
            string jsString = string.Empty;

            if (txtJavascriptFile.Text == string.Empty)
            {
                errorProvider1.SetError(txtSource, "Please select a valid Javascript File");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            jsString = txtJavascriptFile.Text;
            Helper.JscriptReader(jsString, ref dt);
            Helper.CreateTreeView(treeView1, dt);
        }

        private void btnCreateJSONTree_Click(object sender, EventArgs e)
        {
            string jsonstring = string.Empty;

            if (txtSource.Text == string.Empty)
            {
                errorProvider1.SetError(txtSource, "Please select a valid JSON source");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            jsonstring = File.ReadAllText(txtSource.Text);
            Helper.JsonReader(jsonstring, ref dt);
            Helper.CreateTreeView(treeView1, dt);
        }


       


       
    }
}
