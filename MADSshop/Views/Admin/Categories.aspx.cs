using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MADSshop.Views.Admin
{
    public partial class Categories : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowCategories();
        }
        private void ShowCategories()
        {
            string Query = "SELECT * FROM CategoryTbl";
            CategoryList.DataSource = Con.GetData(Query);
            CategoryList.DataBind();
        }
        protected void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string CName = CatName.Value;
                    string CDesc = DescriptionTb.Value;
                    

                    string Query = "insert into CategoryTbl values('{0}','{1}')";
                    Query = string.Format(Query, CName, CDesc);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Inserted";
                    CatName.Value = "";
                    DescriptionTb.Value = "";
                   

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
        int Key = 0;
        protected void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatName.Value = CategoryList.SelectedRow.Cells[2].Text;
            DescriptionTb.Value = CategoryList.SelectedRow.Cells[3].Text;
            if (CatName.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CategoryList.SelectedRow.Cells[1].Text);
            }
        }
        protected void Editbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string CName = CatName.Value;
                    string CDesc = DescriptionTb.Value;
                    

                    string Query = "update CategoryTbl set CatName ='{0}', CatDescription ='{1}' where CatId= {2}";
                    Query = string.Format(Query, CName, CDesc,CategoryList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Updated";
                    CatName.Value = "";
                    DescriptionTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (CatName.Value == "" || DescriptionTb.Value == "")
                {
                    ErrMsg.Text = "Select a Category";
                }
                else
                {
                    string AName = CatName.Value;
                    string Gender = DescriptionTb.Value;
                    

                    string Query = "delete from CategoryTbl where CatId={0}";
                    Query = string.Format(Query, CategoryList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowCategories();
                    ErrMsg.Text = "Category Deleted";
                    CatName.Value = "";
                    DescriptionTb.Value = "";
                    

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}