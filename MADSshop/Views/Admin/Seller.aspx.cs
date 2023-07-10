using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MADSshop.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowSellers();
        }
        private void ShowSellers()
        {
            string Query = "SELECT * FROM SelTbl";
            SellerList.DataSource = Con.GetData(Query);
            SellerList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value== "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string Email = EmailTb.Value;
                    string Address = AddressTb.Value;
                    string Phone = PhoneTb.Value;

                    string Query = "insert into SelTbl values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, SName, Email, Phone,Address);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "New Seller Added Successfully";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    AddressTb.Value = "";
                    PhoneTb.Value = "";

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
            SNameTb.Value = SellerList.SelectedRow.Cells[2].Text;
            EmailTb.Value = SellerList.SelectedRow.Cells[3].Text;
            PhoneTb.Value = SellerList.SelectedRow.Cells[4].Text;
            AddressTb.Value = SellerList.SelectedRow.Cells[5].Text;
            if (SNameTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(SellerList.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value=="")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string Email = EmailTb.Value;
                    string Address = AddressTb.Value;
                    string Phone = PhoneTb.Value;

                    string Query = "update SellerTbl set SelName='{0}', SelEmail ='{1}',SelPhone='{2}',SelAddress='{3}' where SelId= {4}";
                    Query = string.Format(Query, SName, Email, Address,Phone, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Updated";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    AddressTb.Value = "";
                    PhoneTb.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SNameTb.Value == "" || EmailTb.Value == "" || PhoneTb.Value == "" || AddressTb.Value == "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string SName = SNameTb.Value;
                    string Email = EmailTb.Value;
                    string Address = AddressTb.Value;
                    string Phone = PhoneTb.Value;

                    string Query = "delete from SelTbl where SelId={0}";
                    Query = string.Format(Query, SellerList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowSellers();
                    ErrMsg.Text = "Seller Deleted";
                    SNameTb.Value = "";
                    EmailTb.Value = "";
                    AddressTb.Value = "";
                    PhoneTb.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}