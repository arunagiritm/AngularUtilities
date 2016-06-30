using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAngularFactories : Form
    {
        DataTable dt =new DataTable();
        string dquotes = @"""";
         public frmAngularFactories()
         {
             InitializeComponent();
             errorProvider1.Clear();
         }

       
        private void button1_Click(object sender, EventArgs e)
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

            jsonstring=File.ReadAllText(txtSource.Text);
            Helper.JsonReader(jsonstring,ref dt);
            Helper.CreateTreeView(treeView1, dt);
        }
        
        private JsonFactory CreateFactory(string factoryName, Int32 factoryID)
        {
            string factorysuffix="factory";
            //string factoryName = string.Format("{0}", "json" );
            string injectedFactoryString = null;
            string returnFactoryName = string.Format("that{0}", factoryName);
            string parameterName ="resp";
            string factoryFields = null;
            string[] factoryFieldsArray =null;
            string[] injectedFactoryArray = null;
            StringBuilder bodyFunction = new StringBuilder();
            JsonFactory jfactory = new JsonFactory();

          
            
           
            injectedFactoryString = GetChildFactories(factoryID);
            factoryFields = GetFactoryFields( factoryID);
            injectedFactoryArray = injectedFactoryString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            factoryFieldsArray = factoryFields.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            
            bodyFunction.AppendLine(string.Format("function {0} (data) {1}",factoryName,"{"));
            
            bodyFunction.AppendLine(string.Format("this.init(data);"));
            
            bodyFunction.AppendLine(string.Format("{0};","}"));
            bodyFunction.AppendLine(string.Format("{0}.prototype ={1}",factoryName,"{"));
            bodyFunction.AppendLine(string.Format("init : function(data){0} ","{"));
            bodyFunction.AppendLine(string.Format("if(data){0}","{"));
            bodyFunction.AppendLine(string.Format("angular.extend(this,data);"));
           
            
            bodyFunction.AppendLine(string.Format("{0}", "}"));
            bodyFunction.AppendLine(string.Format("else {0}","{"));
            bodyFunction.AppendLine(string.Format("angular.extend(this, {0}", "{"));
            for (int i = 0; i < factoryFieldsArray.Length; i++)
            {
                bodyFunction.AppendLine(string.Format("{0} :null;",  factoryFieldsArray[i].Replace("'", ""))); //intialize factory fields to null
            }
            for (int i = 0; i < injectedFactoryArray.Length; i++)
            {
                bodyFunction.AppendLine(string.Format("{1} = {1}.init({0});", "{}", injectedFactoryArray[i].Replace("'", ""))); //call the init method of injected factories
            }
            bodyFunction.AppendLine("});");
            bodyFunction.AppendLine("}}}");
            bodyFunction.AppendLine(string.Format("return {0};", factoryName)); // return the intialized that object.

            jfactory.FactoryName = factoryName;
            if (injectedFactoryArray.Length>0)
            {
                jfactory.InjectedFactories = injectedFactoryString;
            }
            else
            {
                jfactory.InjectedFactories = string.Empty;
            }
            
            jfactory.FactoryBodyCode = bodyFunction.ToString();

            return jfactory;
        }

        private string GetChildFactories(int factoryID)
        {
            StringBuilder filterStringBuilder = new StringBuilder();
            string filterString = "Type = " + "'" + Helper.JSONTYPE.OBJECT.ToString() + "' and Active=true ";

            filterString += " and ParentId = " + factoryID.ToString();

            DataRow[] drows = dt.Select(filterString);

            foreach (DataRow dr in drows)
            {
                filterStringBuilder.Append("'");
                filterStringBuilder.Append(dr["Node"]);
                filterStringBuilder.Append("',");
            }
            filterString = filterStringBuilder.ToString();
            if (filterString.EndsWith(","))
            {
                filterString = filterString.Substring(0, filterString.Length - 1);
            }
            return filterString;
        }

        private string GetFactoryFields( Int32 factoryID)
        {
            List<Int32> factoryIds = GetFactoryIds(factoryID);
            StringBuilder filterStringBuilder = new StringBuilder();
            string filterString = string.Empty;

            foreach (Int32 fid in factoryIds)
            {
                filterString = "Type = " + "'" + Helper.JSONTYPE.FIELD.ToString() + "'";

                filterString += " and ParentId = " + fid.ToString();

                DataRow[] drows = dt.Select(filterString);

                foreach (DataRow dr in drows)
                {
                    filterStringBuilder.Append("'");
                    filterStringBuilder.Append(dr["Node"]);
                    filterStringBuilder.Append("',");
                }
                filterString = filterStringBuilder.ToString();
                if (filterString.EndsWith(","))
                {
                    filterString = filterString.Substring(0, filterString.Length - 1);
                }
            }
            return filterString;
        }

        private List<Int32> GetFactoryIds(int factoryID) // This function will return the related factory ids which is set to false
        {
            List<Int32> factoryIds = new List<int>();
            StringBuilder filterStringBuilder = new StringBuilder();
            string filterString = "Type = " + "'" + Helper.JSONTYPE.OBJECT.ToString() + "'";
            bool state;

            filterString += " and ParentId = " + factoryID.ToString();
            DataRow[] drows = dt.Select(filterString);
            factoryIds.Add(factoryID); // the passed id should be included first
            foreach (DataRow dr in drows)
            {
                state=Convert.ToBoolean( dr["Active"]);
                if (!state)
                {
                    factoryIds.Add(Convert.ToInt32(dr["Id"]));
                }
            }
            return factoryIds;

        }

        private DataView GetFilteredData(string fieldName,Helper.JSONTYPE ftype,Int32? parentId)
        {
            StringBuilder filterStringBuilder = new StringBuilder();
            string filterString = "Type = " + "'" + ftype.ToString() + "'" + " and Active =true ";
            if (parentId!=null)
            {
                filterString+=" and parentId = " +  parentId.ToString()  ;
            }
             DataRow[] drows= dt.Select(filterString );

             DataView dv = new DataView(dt);
             dv.RowFilter = filterString;

             return dv;
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

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtDest.Text == string.Empty)
            {
                errorProvider1.SetError(txtDest, "Please select a valid folder to store Angular Factories");
                return;
            }
            else if (treeView1.Nodes.Count <=0)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(treeView1, "The JSON tree needs to created before generating factories");
                return;
            }
            else if(!(Directory.Exists(txtDest.Text)))
            {
                MessageBox.Show("The destination folder is not a valid folder");
                return;
            }
            GenerateFactories();
        }

        private void GenerateFactories()
        {
            DataTable dtParent = new DataTable();
            dtParent = GetFilteredData("Node", Helper.JSONTYPE.OBJECT, null).ToTable();
            DataRowCollection factories = dtParent.Rows;
           string factorystr = string.Empty;
            Int32 pbarValue = 1;
            string factoryFileName = string.Empty;
            
            string sourceTemplate = File.ReadAllText(@".\Templates\FactoryTemplate.txt");
            List<JsonFactory> jfactoryList = new List<JsonFactory>();
            JsonFactory jfactory = new JsonFactory();

            progressBar1.Maximum = factories.Count-1;
            foreach (DataRow factory in factories)
            {
                if (factory["Node"].ToString() == "JSON")
                {
                    continue;
                }
                string strComma = string.Empty;
                if (jfactory.InjectedFactories != null)
                {
                    if (jfactory.InjectedFactories.Trim().Length > 0)
                    {
                        strComma = ",";
                    }
                }
                jfactory = CreateFactory(factory["Node"].ToString(), Convert.ToInt32(factory["Id"]));
                jfactory.FactoryFullCode = string.Format(sourceTemplate, 
                                                            jfactory.FactoryName, 
                                                            jfactory.InjectedFactories, 
                                                            jfactory.FactoryBodyCode,
                                                            "{",
                                                            "}",
                                                            strComma,
                                                            jfactory.InjectedFactories.Replace("'","")
                                                            );
                jfactoryList.Add(jfactory);     
            }
            foreach (JsonFactory jf in jfactoryList)
            {
                factoryFileName=string.Format(@"{0}\{1}.js", txtDest.Text, jf.FactoryName);
               File.WriteAllText(factoryFileName, jf.FactoryFullCode);
               lblProgress.Text = string.Format("Generating factories for {0} {1} of {2}", jf.FactoryName, pbarValue, progressBar1.Maximum);

               progressBar1.Value = pbarValue;
               pbarValue++;
            }
            if (MessageBox.Show("Do you want to beautify the generated code? This may take some time","Beautify JS",MessageBoxButtons.YesNo)== System.Windows.Forms.DialogResult.Yes)
            {
                pbarValue = 1;
                ProcessStartInfo ps = new ProcessStartInfo();
                ps.FileName = "cmd.exe";
                ps.CreateNoWindow = true;
                ps.UseShellExecute = false;
                ps.WindowStyle = ProcessWindowStyle.Hidden;
                
                foreach (JsonFactory jf in jfactoryList)
                {
                    factoryFileName = string.Format(@"{0}\{1}.js", txtDest.Text, jf.FactoryName);
                    lblProgress.Text = string.Format("Beautifying file for {0} {1} of {2}", factoryFileName, pbarValue, progressBar1.Maximum);
                    progressBar1.Value = pbarValue;
                    pbarValue++;
                    
                    ps.Arguments = string.Format(@"{2}/c {0}NodeModules\js-beautify\js-beautify.cmd  -o {1}{2}", AppDomain.CurrentDomain.BaseDirectory, factoryFileName,dquotes);

                    try
                    {
                        
                        // Start the process with the info we specified.
                        // Call WaitForExit and then the using statement will close.
                        using (Process exeProcess = Process.Start(ps))
                        {
                            exeProcess.WaitForExit();
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Angular factories successfully created");
            }
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


       
    }
}
