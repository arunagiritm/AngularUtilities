using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{

    public static class Helper
    {
        static Stack<Int32> jstack = new Stack<Int32>();

        static Int32 rkey;
       
       public  enum JSONTYPE
        {
            FIELD = 0,
            OBJECT = 1,
            ARRAY = 2
        }


        public static void PopulateTree(TreeView objTreeView, TreeViewSchema tvwSchema)
        {
            objTreeView.Nodes.Clear();
            if (tvwSchema.DataSource != null)
            {
                foreach (DataRow dataRow in tvwSchema.DataSource.Rows)
                {
                    
                    if (Convert.ToInt32(dataRow[tvwSchema.ParentMember]) ==  0)
                    {
                        
                        TreeNode treeRoot = new TreeNode();
                        treeRoot.Text = dataRow[tvwSchema.DisplayMember].ToString();
                        treeRoot.Tag = dataRow[tvwSchema.ValueMember].ToString();
                        treeRoot.ExpandAll();
                        objTreeView.Nodes.Add(treeRoot);
                        Int32 keyMember = Convert.ToInt32(dataRow[tvwSchema.KeyMember].ToString());
                        foreach (TreeNode childNode in GetChildNode(keyMember, tvwSchema))
                        {
                            treeRoot.Nodes.Add(childNode);
                        }
                    }
                }
            }
        }

        private static List<TreeNode> GetChildNode(Int32 parentid, TreeViewSchema tvwSchema)
        {
            List<TreeNode> childtreenodes = new List<TreeNode>();
            DataView dataView1 = new DataView(tvwSchema.DataSource);
            String strFilter = "" + tvwSchema.ParentMember + "=" + parentid.ToString() + "";
            dataView1.RowFilter = strFilter;

            if (dataView1.Count > 0)
            {
                foreach (DataRow dataRow in dataView1.ToTable().Rows)
                {
                    TreeNode childNode = new TreeNode();
                    childNode.Text = dataRow[tvwSchema.DisplayMember].ToString();
                    childNode.Tag = dataRow[tvwSchema.ValueMember].ToString();
                    childNode.ExpandAll();
                    Int32 keyMember = Convert.ToInt32(dataRow[tvwSchema.KeyMember].ToString());
                    foreach (TreeNode cnode in GetChildNode(keyMember, tvwSchema))
                    {
                        childNode.Nodes.Add(cnode);
                    }
                    childtreenodes.Add(childNode);

                }
            }
            return childtreenodes;

        }

        private static void ReadJsonProperties(JsonTextReader reader,  ref Int32 pid, ref DataRow dr, ref Int32 rkey, ref Stack<Int32> jsonParenetStack,ref DataTable dt)
        {

            while (reader.TokenType == JsonToken.PropertyName)
            {
                dr = dt.NewRow();
                dr["Id"] = rkey;
                dr["Node"] = reader.Value;
                dr["ParentId"] = pid;
                dr["Type"] = JSONTYPE.FIELD.ToString();
                dt.Rows.Add(dr);
                
                rkey++;
                reader.Read();
                if (!(reader.TokenType == JsonToken.StartObject || reader.TokenType == JsonToken.StartObject || reader.TokenType == JsonToken.StartObject))
                {
                    reader.Read();
                }
                if (reader.TokenType == JsonToken.EndObject)
                {
                    jsonParenetStack.Pop();
                    pid = jsonParenetStack.Peek();
                    reader.Read();
                }
            }

        }

         public static void JsonReader(string json, ref DataTable dt)
        {
             
            JavaScriptSerializer js = new JavaScriptSerializer();
            rkey = 1;
            Int32 pid = 0;
            try
            {
                Dictionary<string, object> dic = js.Deserialize<Dictionary<string, object>>(json);
                dt = CreateSchema();
                dt.Clear();
                DataRow dr = dt.NewRow();
                dr["Id"] = rkey;
                dr["Node"] = "JSON";
                dr["ParentId"] = pid;
                dr["Type"] = JSONTYPE.OBJECT.ToString();
                dt.Rows.Add(dr);
                pid = rkey;
                rkey++;
                BuildTree(dic, ref dt,pid);

            }
            catch (Exception)
            {
                
                MessageBox.Show("JSON data is not valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }

         private static void BuildTree(Dictionary<string, object> dictionary, ref DataTable dt,Int32 pid)
        {
             
            
            foreach (KeyValuePair<string, object> item in dictionary)
            {
                DataRow dr;
                Int32 ppid;
                try
                {

                    if (item.Value==null)
                    {
                        AddRowstoTable(ref dt,rkey,item,pid,JSONTYPE.FIELD.ToString());
                        rkey++;
                    }
                        
                    else if(item.Value.GetType().Name == "Dictionary`2" ||
                            item.Value.GetType().Name == "ArrayList") //parent node
                    {
                        AddRowstoTable(ref dt, rkey, item, pid, JSONTYPE.OBJECT.ToString());
                        ppid = pid;
                        pid = rkey;
                        rkey++;
                        if (item.Value.GetType().Name == "Dictionary`2")
                        {
                            dictionary = (Dictionary<string, object>)item.Value;
                            jstack.Push(ppid);
                            BuildTree(dictionary, ref dt, pid);
                            pid=jstack.Pop();
                        }
                        else if (item.Value.GetType().Name == "ArrayList")
                        {
                            ArrayList arrItem = (ArrayList)item.Value;
                            for (int i = 0; i < arrItem.Count; i++)
                            {

                                KeyValuePair<string, object> itemlocal = new KeyValuePair<string, object>(i.ToString(), null);
                                AddRowstoTable(ref dt, rkey, itemlocal, pid, JSONTYPE.OBJECT.ToString());
                                ppid = pid;
                                pid = rkey;
                                rkey++;
                                if (arrItem[i].GetType().Name == "Dictionary`2")
                                {
                                    dictionary = (Dictionary<string, object>)arrItem[i];
                                    jstack.Push(ppid);
                                    BuildTree(dictionary, ref dt, pid);
                                    pid=jstack.Pop();
                                }

                            }
                            
                        }
                           
                    }
                    //if (item.Value.GetType().Name == "String") //leaf node
                    else
                    {
                        AddRowstoTable(ref dt, rkey, item, pid, JSONTYPE.FIELD.ToString());
                        rkey++;
                    }


                    
                    
                }
                catch (InvalidCastException dicE ) {
                    MessageBox.Show(dicE.Message);
                }
            }
            //pid = jstack.Pop();
        }

         private static void AddRowstoTable(ref DataTable dt, int rkey, KeyValuePair<string, object> item, int pid, string p)
         {
             DataRow dr;
             dr = dt.NewRow();
             dr["Id"] = rkey;
             dr["Node"] = item.Key;
             dr["ParentId"] = pid;
             dr["Type"] = p;
             dt.Rows.Add(dr);
         }

        
        public static void JsonReader1(string json, ref DataTable dt)
        {
            dt =Helper.CreateSchema();
            dt.Clear();
            Int32 rkey = 1;
            Int32 pid = 0;
            Stack<Int32> jsonParenetStack = new Stack<int>();
            DataRow dr = dt.NewRow();

            jsonParenetStack.Push(rkey);
            JsonTextReader reader = new JsonTextReader(new StringReader(json));
            dr = dt.NewRow();
            if (reader.TokenType == JsonToken.PropertyName)
            {
                dr["Node"] = reader.Value;
                reader.Read();
            }
            else
            {
                dr["Node"] = "JSON";
            }

            dr["Id"] = rkey;
            dr["ParentId"] = pid;
            dr["Type"] = JSONTYPE.OBJECT.ToString();
            dt.Rows.Add(dr);
            rkey++;
            while (reader.Read())
            {

                while (reader.TokenType == JsonToken.StartObject)
                {

                    if (rkey > 2)
                    {
                        jsonParenetStack.Push(rkey - 1);
                        dt.Rows[rkey - 2]["Type"] = JSONTYPE.OBJECT.ToString();
                    }
                    pid = jsonParenetStack.Peek();


                    reader.Read();
                    ReadJsonProperties(reader, ref pid, ref dr, ref rkey, ref jsonParenetStack,ref dt);

                    if (reader.TokenType == JsonToken.EndObject)
                    {
                        jsonParenetStack.Pop();
                        pid = jsonParenetStack.Peek();
                        reader.Read();
                        ReadJsonProperties(reader, ref pid, ref dr, ref rkey, ref jsonParenetStack, ref dt);
                    }


                }
            }
            if (reader.TokenType == JsonToken.EndObject)
            {
                jsonParenetStack.Pop();
                pid = jsonParenetStack.Peek();
                reader.Read();
                ReadJsonProperties(reader, ref pid, ref dr, ref rkey, ref jsonParenetStack, ref dt);
            }
        }

        private static DataTable CreateSchema()
        {
           DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(Int32));
            dt.Columns.Add("Node");
            dt.Columns.Add("ParentId", typeof(Int32));
            dt.Columns.Add("Type");
            dt.Columns.Add("Active", typeof(Boolean));
            dt.Columns["Active"].DefaultValue = true;
            return dt;

        }

        public static void CreateTreeView(TreeView treeView1,DataTable dt)
        {

            TreeViewSchema tvwSchema = new TreeViewSchema();
            tvwSchema.DataSource = dt;
            tvwSchema.KeyMember = "Id";
            tvwSchema.DisplayMember = "Node";
            tvwSchema.ValueMember = "Id";
            tvwSchema.ParentMember = "ParentId";
            Helper.PopulateTree(treeView1, tvwSchema);
            treeView1.ExpandAll();
            treeView1.CheckBoxes = true;
            treeView1.Nodes[0].Checked = true;

        }

        public static void JscriptReader(string jsfile,ref DataTable dt)
        {
            DataRow dr;
            string[] fileContent;
            string tjsline = string.Empty;
            string targsLine = string.Empty;
            Int32 loc=0;
            Int32 eloc;
            Int32 rkey=1;
            Int32 pid =0;
            Int32 lstart,lend = 0;
            Int32 argsLength = 0;
            bool locFound = false;
            Stack<Int32> jsStack = new Stack<int>();
            jsStack.Push(pid);

            string[] args;
            string methodName = string.Empty;
            dt = CreateSchema();

            jsStack.Push(rkey);
            dr = dt.NewRow();
            dr["Id"] = rkey;
            dr["Node"] = "Root";
            dr["ParentId"] = pid;
            dr["Type"] = JSONTYPE.OBJECT.ToString();
            dt.Rows.Add(dr);
            rkey++;
            fileContent= File.ReadAllLines(jsfile);
            foreach (string jsline in fileContent)
            {
                tjsline = jsline.Replace(" ", "");
                tjsline = Regex.Replace(tjsline, @"\t|\n|\r", "");
                if (!locFound)
                {
                    targsLine = string.Empty;
                    loc = tjsline.IndexOf("function");
                }
               
                if (loc >= 0)
                {
                   
                    locFound = true;
                    tjsline = targsLine + tjsline;
                    eloc = tjsline.IndexOf(")", loc);
                    if (eloc<0)
                    {
                        targsLine = tjsline;
                        argsLength += tjsline.Length;
                        continue;
                    }
                    
                    lstart = loc + 9;
                    if (loc>0)
                    {
                        loc--;
                    }
                    lend = eloc -lstart;
                    //check whether the name of the funtion is preceding or following
                    if (tjsline.Substring(lstart-1, 1) != "(")
                    {

                        methodName = tjsline.Substring(lstart-1, tjsline.Length - lend + 1 + lstart);
                        lstart = lstart + methodName.Length;

                    }
                    else if (tjsline.Substring(loc, 1) == "=")
                    {
                        targsLine = string.Empty;
                        methodName = tjsline.Substring(0, loc);
                    }
                    else
                    {
                        locFound = false;
                        continue;
                    }

                    //args = tjsline.Substring(lstart, lend ).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    args = getArgs(tjsline);
                  
                    jsStack.Push(rkey);
                    dr = dt.NewRow();
                    dr["Id"] = rkey;
                    dr["Node"] = methodName;
                    dr["ParentId"] = pid;
                    dr["Type"] = JSONTYPE.OBJECT.ToString();
                    dt.Rows.Add(dr);
                    rkey++;
                    if (jsStack.Count > 0)
                    {
                        pid = jsStack.Peek();
                    }
                    foreach (string arg in args)
                    {
                        dr = dt.NewRow();
                        dr["Id"] = rkey;
                        dr["Node"] = arg;
                        dr["ParentId"] = pid;
                        dr["Type"] = JSONTYPE.FIELD.ToString();
                        dt.Rows.Add(dr);
                        rkey++;
                    }
                    jsStack.Pop();
                    pid = jsStack.Peek();
                    locFound = false;
                }

            }
        }
        public static void JSpecReader(string jsfile, ref DataTable dt)
        {
            DataRow dr;
            string[] fileContent;
            string tjsline = string.Empty;
            Int32 loc = 0;
            Int32 rkey = 1;
            Int32 pid = 0;
            string jtype = string.Empty;
            string strToFind=string.Empty;
            Stack<Int32> jsStack = new Stack<int>();
            string strquote = "\"";
            
            //jsStack.Push(pid);
            //Console.WriteLine(string.Format("stack: {0} Node : {1}, rkey : {2}, ParentId: {3}", pid, "File Name", rkey, pid));

            string[] args;
            string methodName = string.Empty;
            dt = CreateSchema();
            
            //jsStack.Push(rkey);
            pid = rkey;
            //Console.WriteLine(string.Format("stack: {0} Node : {1}, rkey : {2}, ParentId: {3}", string.Join(",",jsStack) , "First Node", rkey, pid));
            dr = dt.NewRow();
            dr["Id"] = rkey;
            dr["Node"] = jsfile;
            dr["ParentId"] = pid;
            dr["Type"] = JSONTYPE.OBJECT.ToString();
            dt.Rows.Add(dr);
            rkey++;
            
            fileContent = File.ReadAllLines(jsfile);
            foreach (string jsline in fileContent)
            {
                tjsline = jsline.Replace(" ", "");
                tjsline = Regex.Replace(tjsline, @"\t|\n|\r|"+strquote, "");
                if (tjsline.Contains("describe("))
                {
                    //pid = jsStack.Peek();
                    //jsStack.Push(rkey);
                    //Console.WriteLine(string.Format("stack: {0} Node : {1}, rkey : {2}, ParentId: {3}", string.Join(",", jsStack), "describe", rkey, pid));
                    jtype= JSONTYPE.OBJECT.ToString();
                    strToFind="describe(";
                }
                else if (tjsline.Contains("it("))
                {
                    //Console.WriteLine(string.Format("stack: {0} Node : {1}, rkey : {2}, ParentId: {3}", string.Join(",", jsStack), "it", rkey, pid));
                     jtype= JSONTYPE.FIELD.ToString();
                    strToFind="it(";
                }
                if(tjsline.Contains("{"))
                {
                    if (jsStack.Count>0)
                    {
                        pid = jsStack.Peek();
                    }
                   
                    jsStack.Push(rkey);
                   // Console.WriteLine(string.Format("stack: {0} Node : {1}, rkey : {2}, ParentId: {3}", string.Join(",", jsStack), "Start Token", rkey, pid));

                }
                else if (tjsline.Contains("}"))
                {
                    jsStack.Pop();
                    if (jsStack.Count>0)
                    {
                        pid = jsStack.Peek();    
                    }
                    
                    //Console.WriteLine(string.Format("stack: {0} Node : {1}, rkey : {2}, ParentId: {3}", string.Join(",", jsStack), "End token", rkey, pid));
                }
                else
                {
                    continue;
                }
                loc = tjsline.IndexOf(strToFind);
                if (loc>=0)
	            {
                    tjsline=tjsline.Substring(loc+ strToFind.Length);
                    loc = tjsline.IndexOf(",");
                    methodName=tjsline.Substring(0,loc);
                    dr = dt.NewRow();
                    dr["Id"] = rkey;
                    dr["Node"] = methodName;
                    dr["ParentId"] = pid;
                    dr["Type"] = jtype;
                    dt.Rows.Add(dr);
                    rkey++;
                   
                    
	            }
            }
        }

        private static string[] getArgs(string tjsline)
        {
            Int32 iBracketStart;
            Int32 iBracketEnd;
            string strLine;
            string[] args=null;
            iBracketStart = tjsline.IndexOf("(");
            iBracketEnd = tjsline.IndexOf(")");

            if (iBracketStart>=0 && (iBracketEnd >=0 && iBracketEnd >=iBracketStart))
            {
                strLine = tjsline.Substring(iBracketStart+1);
               args= tjsline.Substring(iBracketStart+1, iBracketEnd-iBracketStart-1).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            }
            return args;
        }

      



    }
}