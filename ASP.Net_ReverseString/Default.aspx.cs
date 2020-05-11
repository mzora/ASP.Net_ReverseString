using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_ReverseString
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            createNewRow();
        }

        public string Reverse(string s)
        {
            char[] cArray = s.ToCharArray();
            string reverse = String.Empty;

            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        public void createNewRow()
        {
            
            string inputString = TextBox1.Text;
            string reverseString = Reverse(inputString);

            DataTable mytable = new DataTable();

            if (ViewState["Row"] != null)
            {
                mytable = (DataTable)ViewState["Row"];

                if (mytable.Rows.Count > 0)
                {
                    DataRow dr = mytable.NewRow();
                    dr["Input String"] = inputString;
                    dr["Reverse String"] = reverseString;
                    mytable.Rows.Add(dr);
                    ViewState["Row"] = mytable;
                    
                    GridView1.DataSource = ViewState["Row"];
                    GridView1.DataBind();
                }
            }
            else
            {
                mytable.Columns.Add("Input String", typeof(string));
                mytable.Columns.Add("Reverse String", typeof(string));

                DataRow dr1 = mytable.NewRow();
                dr1["Input String"] = inputString;
                dr1["Reverse String"] = reverseString;
                mytable.Rows.Add(dr1);

                ViewState["Row"] = mytable;
                GridView1.DataSource = ViewState["Row"];
                GridView1.DataBind();
            }
        }
    }
}