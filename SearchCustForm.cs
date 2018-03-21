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
    public partial class SearchCustForm : Form
    {
        private string toSend;

        public SearchCustForm()
        {
            InitializeComponent();
        }

        private void NameSearch_Button_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            var q = from x in ctx.Customers
                    where x.CustomerName == CustName_TextBox.Text
                    select new { x.CustomerID, x.CustomerName, x.MemberCategory, x.PhoneNumber};

            CustGridView.DataSource = q.ToList();
        }

        private void PhoneNo_Button_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            var q = from x in ctx.Customers
                    where x.PhoneNumber == PhoneNo_TextBox.Text
                    select new { x.CustomerID, x.CustomerName, x.MemberCategory, x.PhoneNumber };

            CustGridView.DataSource = q.ToList();
        }

        protected void CustGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var q = CustGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            //label1.Text = q.ToString();

            if (e.RowIndex >= 0)
            {
                int yCoord = CustGridView.CurrentCellAddress.Y;
                toSend = CustGridView.Rows[yCoord].Cells[0].Value.ToString();
                this.Close();
            }
        }

        public string ToSend
        {
            get
            {
                return this.toSend;
            }
        }
    }
}
