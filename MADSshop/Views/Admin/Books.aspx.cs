using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MADSshop.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                ShowBooks();
                GetAuthors();
                GetCategories();
            }
        }
        private void ShowBooks()
        {
            string Query = "SELECT * FROM BookTbl";
            BooksList.DataSource = Con.GetData(Query);
            BooksList.DataBind();
        }
        private void GetAuthors()
        {
            string Query = "SELECT * FROM AuthorTbl";
            BauthTd.DataSource = Con.GetData(Query);
            BauthTd.DataTextField = Con.GetData(Query).Columns["AutName"].ToString();
            BauthTd.DataValueField = Con.GetData(Query).Columns["AutID"].ToString();
            BauthTd.DataSource = Con.GetData(Query);
            BauthTd.DataBind();
        }
        private void GetCategories()
        {
            string Query = "SELECT * FROM CategoryTbl";
            BcatTd.DataSource = Con.GetData(Query);
            BcatTd.DataTextField = Con.GetData(Query).Columns["CatName"].ToString();
            BcatTd.DataValueField = Con.GetData(Query).Columns["Catid"].ToString();
            BcatTd.DataSource = Con.GetData(Query);
            BcatTd.DataBind();
        }



        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (BtitleTb.Value == "" || BauthTd.SelectedIndex == -1 || BcatTd.SelectedIndex == -1 || BpriceTb.Value == "" || Bquantity.Value == "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string Btitle = BtitleTb.Value;
                    string Bauth = BauthTd.SelectedValue.ToString();
                    string Bcat = BcatTd.SelectedValue.ToString();
                    int Bquant = Convert.ToInt32(Bquantity.Value);
                    int Bprice = Convert.ToInt32(BpriceTb.Value);


                    string Query = "insert into BookTbl values('{0}',{1},{2},{3},{4})";
                    Query = string.Format(Query, Btitle,Bauth ,Bcat, Bquant, Bprice);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "New Book Added Successfully";
                    BtitleTb.Value = "";
                    BauthTd.SelectedIndex = -1;
                    BcatTd.SelectedIndex = -1;
                    BpriceTb.Value = "";
                    Bquantity.Value = "";

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
            BtitleTb.Value = BooksList.SelectedRow.Cells[2].Text;
            BauthTd.SelectedItem.Value = BooksList.SelectedRow.Cells[3].Text;
            BcatTd.SelectedItem.Value = BooksList.SelectedRow.Cells[4].Text;
            BpriceTb.Value = BooksList.SelectedRow.Cells[5].Text;
            Bquantity.Value = BooksList.SelectedRow.Cells[6].Text;

            if (BtitleTb.Value == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BooksList.SelectedRow.Cells[1].Text);
            }
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (BtitleTb.Value == "" || BauthTd.SelectedIndex == -1 || BcatTd.SelectedIndex == -1 || BpriceTb.Value == "" || Bquantity.Value == "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string Btitle = BtitleTb.Value;
                    string Bauth = BauthTd.SelectedValue.ToString();
                    string Bcat = BcatTd.SelectedValue.ToString();
                    int Bquant = Convert.ToInt32(Bquantity.Value);
                    int Bprice = Convert.ToInt32(BpriceTb.Value);


                    string Query = "update BookTbl set Btitle='{0}',Bauth='{1}',Bcat ='{2}',Bquant ='{3}',Bprice ='{4}' where BId={5}";
                    Query = string.Format(Query, Btitle, Bauth, Bcat, Bquant, Bprice, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = "Book Updated";
                    BtitleTb.Value = "";
                    BauthTd.SelectedIndex = -1;
                    BcatTd.SelectedIndex = -1;
                    BpriceTb.Value = "";
                    Bquantity.Value = "";

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

                if (BtitleTb.Value == "" || BauthTd.SelectedIndex == -1 || BcatTd.SelectedIndex == -1 || BpriceTb.Value == "" || Bquantity.Value == "")
                {
                    ErrMsg.Text = "Please fill all the fields";
                }
                else
                {
                    string Btitle = BtitleTb.Value;
                    string Bauth = BauthTd.SelectedValue.ToString();
                    string Bcat = BcatTd.SelectedValue.ToString();
                    int Bquant = Convert.ToInt32(Bquantity.Value);
                    int Bprice = Convert.ToInt32(BpriceTb.Value);


                    string Query = "delete BookTbl where BId={0}";
                    Query = string.Format(Query, BooksList.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    ShowBooks();
                    ErrMsg.Text = " Book Deleted";
                    BtitleTb.Value = "";
                    BauthTd.SelectedIndex = -1;
                    BcatTd.SelectedIndex = -1;
                    BpriceTb.Value = "";
                    Bquantity.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.Text = Ex.Message;
            }
        }
    }
}