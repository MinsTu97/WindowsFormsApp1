using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Invoice invoiceManager;
        public Form1()
        {
            InitializeComponent();
            invoiceManager = new Invoice();


            addInvoice.InvoiceManager = invoiceManager;
            manageInvoices.InvoiceManager = invoiceManager;

            addInvoice.Show();
            manageInvoices.Hide(); 
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Show();  
            addInvoice.Hide();
            manageInvoices.RefreshInvoiceList();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manageInvoices.Hide();
            addInvoice.Show();
        }

        private void addInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
