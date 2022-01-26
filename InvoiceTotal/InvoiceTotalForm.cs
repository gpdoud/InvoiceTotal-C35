using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal {
    public partial class InvoiceTotalForm : Form {
        public InvoiceTotalForm() {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e) {
            var subTotal = Convert.ToDecimal(Subtotal.Text);
            var discPct = 0.1m;
            var discAmt = subTotal * discPct;
            var total = subTotal - discAmt;

            DiscountPercent.Text = discPct.ToString("#0%");
            DiscountAmount.Text = discAmt.ToString("C");
            Total.Text = total.ToString("C");
        }
    }
}
