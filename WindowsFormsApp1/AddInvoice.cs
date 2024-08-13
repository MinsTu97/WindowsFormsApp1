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
    public partial class AddInvoice : UserControl
    {
        public Invoice InvoiceManager { get; set; }
        public AddInvoice()
        {
            InitializeComponent();
            customersTypeComboBox.SelectedItem = "Household customer";
            string currenMonth = DateTime.Now.Month.ToString();
            currentMonthComboBox.SelectedItem = currenMonth;
            numberOfPeopleInput.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddInvoice_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            string messages = "";
            bool isValid = true;
            if (customersCodeInput.Text == "")
            {
                isValid = false;
                messages += "Please enter customers code!\n";
            }
            if (customersNameInput.Text == "")
            {
                isValid = false;
                messages += "Please enter customers name!\n";
            }
            if (numberOfPeopleInput.Text=="" || !numberOfPeopleInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter valid number of people!\n";
            }
            if (lastMonthNumberInput.Text == "" || !lastMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter valid last month!\n";
            }
            if (thisMonthNumberInput.Text == "" || !thisMonthNumberInput.Text.All(char.IsDigit))
            {
                isValid = false;
                messages += "Please enter valid this month!\n";
            }
            if (isValid==false)
            {
                MessageBox.Show(messages);
                return;
            }
            string customerCode = customersCodeInput.Text;
            string customerName = customersNameInput.Text;
            string customerType = customersTypeComboBox.SelectedItem.ToString();
            int numberOfPeople = Convert.ToInt32(numberOfPeopleInput.Text);
            int lastMonthNumber = Convert.ToInt32(lastMonthNumberInput.Text);
            int thisMonthNumber = Convert.ToInt32(thisMonthNumberInput.Text);
            int currentMonth = Convert.ToInt32(currentMonthComboBox.SelectedItem);

            int comsumption = thisMonthNumber - lastMonthNumber;
            double price = 0;
            double envFee = 0;
            if ( numberOfPeople <= 0)
            {
                MessageBox.Show("Pl enter number of people!");
                return;
            }
            if (lastMonthNumber <= 0)
            {
                MessageBox.Show("Pl enter last month number!");
                return;
            }
            if ( lastMonthNumber > thisMonthNumber)
            {
                MessageBox.Show("The number you entered is not valid. Please try again!");
                return;
            }
            else 
            if (customerType == "Household customer")
            {
                decimal comsumptionPerPeople = comsumption / numberOfPeople;
                if (comsumptionPerPeople <= 10)
                {
                    price = 5973;
                    envFee = 597.3;
                }
                if (comsumptionPerPeople > 10 && comsumptionPerPeople <= 20)
                {
                    price = 7052;
                    envFee = 705.2;
                }
                if (comsumptionPerPeople >= 20 && comsumptionPerPeople <= 30)
                {
                    price = 8699;
                    envFee = 869.9;
                }
                if (comsumptionPerPeople > 30)
                {
                    price = 15929;
                    envFee = 1592.9;

                }
                if (customerType == "Administrative agency, public services")
                {
                    price = 9955;
                    envFee = 995.5;
                }
                if (customerType == "Production units")
                {
                    price = 11615;
                    envFee = 1161.5;
                }
                if (customerType == "Business services")
                {
                    price = 22068;
                    envFee = 2206.8;
                }
                double subTotal = price * comsumption;
                double VATFee = (subTotal + envFee) * 0.1;
                double total = subTotal + envFee + VATFee;




                consumptionLabel.Text = comsumption.ToString();
                priceLabel.Text = price.ToString();
                subtotalLabel.Text = Math.Round(subTotal, 2).ToString();
                envFeeLabel.Text = envFee.ToString();
                VATLabel.Text = Math.Round(VATFee).ToString();
                totalLabel.Text = Math.Round(total, 2).ToString();

                InvoiceManager.AddInvoice(customerCode, customerName, customerType, numberOfPeople,
                lastMonthNumber, thisMonthNumber, currentMonth, subTotal, envFee, VATFee, total);
            }

        }
        private void customersTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = customersTypeComboBox.SelectedItem.ToString();
            if ( customerType == "Household customer")
                numberOfPeopleInput.Enabled = true; 
            else
                numberOfPeopleInput.Enabled = false;
        }

        private void calculateButton_MouseHover(object sender, EventArgs e)
        {
            calculateButton.BackColor = Color.Blue;
        }
    }
}
