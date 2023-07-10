using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MADSshop.Assets
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }
        public static string UName = "";
        public static int User;
        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UsernameTb.Value == "" || PasswordTb.Value == "")
            {
                
            }
            else if(UsernameTb.Value == "Admin@gmail.com" && PasswordTb.Value == "Admin")
            {
                Response.Redirect("Admin/Books.aspx");
            }
            else
            {
                string Query = "select * from SelTbl where SelEmail = '{0}' and SelPassword = '{1}'";
                Query = string.Format(Query, UsernameTb.Value, PasswordTb.Value);
                DataTable dt = Con.GetData(Query);
                
                if(dt.Rows.Count == 0)
                {
                    Response.Redirect("Admin/Books.aspx");
                }
                else
                {
                    UName = UsernameTb.Value;
                    User = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
        }
    }
}