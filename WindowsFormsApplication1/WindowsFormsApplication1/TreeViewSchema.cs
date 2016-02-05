using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TreeViewSchema
    {
        #region Property

        public DataTable DataSource
        {
            get;
            set;
        }

        public String DisplayMember
        {
            get;
            set;
        }

        public String ValueMember
        {
            get;
            set;
        }

        public String ParentMember
        {
            get;
            set;
        }

        public string KeyMember
        {
            get;
            set;
        }
        #endregion
    }
}
