using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESNET_MovieRentalReturnEx
{
    public partial class RentalForm : Form
    {
        public RentalForm()
        {
            InitializeComponent();
            DafestyEntities ctx = new DafestyEntities();

            var t = ctx.IssueTrans.OrderByDescending(y => y.TransactionID).First();
            TransId_Label.Text = (t.TransactionID + 1).ToString();
        }

        private void CustCheck_Button_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            var q = from x in ctx.IssueTrans
                    select x.CustomerID;
            bool present = false;

            foreach (var qry in q)
            {
                if (CustId_TextBox.Text == qry)
                {
                    present = true;
                    var r = ctx.Customers.Where(z => z.CustomerID == qry).First();
                    CustName_TextBox.Text = r.CustomerName.ToString();
                }
            }

            if (present == false)
            {
                CustName_TextBox.Text = "No customer found";
            }

        }

        private void MovieCheck_Button_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            var q = from x in ctx.IssueTrans
                    select x.VideoCode;
            bool present = false;

            foreach (var qry in q)
            {
                if (MovieId_TextBox.Text == qry.ToString())
                {
                    present = true;
                    var r = ctx.Movies.Where(z => z.VideoCode == qry).First();
                    MovieName_TextBox.Text = r.MovieTitle.ToString();
                    StockLeft_TextBox.Text = r.TotalStock.ToString();
                }
            }

            if (present == false)
            {
                MovieName_TextBox.Text = "No movie found";
                StockLeft_TextBox.Text = "NULL";
            }
        }

        private void DateIssued_TimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateIssued_TimePicker.MinDate = System.DateTime.Today;
            DateIssued_TimePicker.MaxDate = DateTime.Today;
        }

        private void DueDate_TimePicker_ValueChanged(object sender, EventArgs e)
        {
            DueDate_TimePicker.MinDate = DateTime.Today.AddDays(3);
            DueDate_TimePicker.MaxDate = DateTime.Today.AddDays(7);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustId_ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchCustForm cust = new SearchCustForm();
            cust.ShowDialog();
            CustId_TextBox.Text = cust.ToSend;
        }
    }
}
