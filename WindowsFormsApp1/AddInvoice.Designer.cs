namespace WindowsFormsApp1
{
    partial class AddInvoice
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.customersCodeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customersNameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastMonthNumberInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numberOfPeopleInput = new System.Windows.Forms.TextBox();
            this.thisMonthNumberInput = new System.Windows.Forms.TextBox();
            this.currentMonthComboBox = new System.Windows.Forms.ComboBox();
            this.customersTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.consumptionLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.envFeeLabel = new System.Windows.Forms.Label();
            this.VATLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customers Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customersCodeInput
            // 
            this.customersCodeInput.Location = new System.Drawing.Point(62, 31);
            this.customersCodeInput.Name = "customersCodeInput";
            this.customersCodeInput.Size = new System.Drawing.Size(209, 22);
            this.customersCodeInput.TabIndex = 1;
            this.customersCodeInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customers Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // customersNameInput
            // 
            this.customersNameInput.Location = new System.Drawing.Point(63, 87);
            this.customersNameInput.Name = "customersNameInput";
            this.customersNameInput.Size = new System.Drawing.Size(209, 22);
            this.customersNameInput.TabIndex = 1;
            this.customersNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Month\'s Water meter readings";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastMonthNumberInput
            // 
            this.lastMonthNumberInput.Location = new System.Drawing.Point(62, 150);
            this.lastMonthNumberInput.Name = "lastMonthNumberInput";
            this.lastMonthNumberInput.Size = new System.Drawing.Size(209, 22);
            this.lastMonthNumberInput.TabIndex = 1;
            this.lastMonthNumberInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Month";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(420, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Customers Type";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = " Number Of People";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "This Month\'s Water meter readings";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // numberOfPeopleInput
            // 
            this.numberOfPeopleInput.Location = new System.Drawing.Point(423, 87);
            this.numberOfPeopleInput.Name = "numberOfPeopleInput";
            this.numberOfPeopleInput.Size = new System.Drawing.Size(209, 22);
            this.numberOfPeopleInput.TabIndex = 1;
            // 
            // thisMonthNumberInput
            // 
            this.thisMonthNumberInput.Location = new System.Drawing.Point(423, 150);
            this.thisMonthNumberInput.Name = "thisMonthNumberInput";
            this.thisMonthNumberInput.Size = new System.Drawing.Size(209, 22);
            this.thisMonthNumberInput.TabIndex = 1;
            this.thisMonthNumberInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // currentMonthComboBox
            // 
            this.currentMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentMonthComboBox.FormattingEnabled = true;
            this.currentMonthComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.currentMonthComboBox.Location = new System.Drawing.Point(63, 204);
            this.currentMonthComboBox.Name = "currentMonthComboBox";
            this.currentMonthComboBox.Size = new System.Drawing.Size(209, 24);
            this.currentMonthComboBox.TabIndex = 2;
            // 
            // customersTypeComboBox
            // 
            this.customersTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersTypeComboBox.DropDownWidth = 250;
            this.customersTypeComboBox.FormattingEnabled = true;
            this.customersTypeComboBox.Items.AddRange(new object[] {
            "Household customer",
            "Administrative agency, public services",
            "Production units",
            "Business services"});
            this.customersTypeComboBox.Location = new System.Drawing.Point(425, 31);
            this.customersTypeComboBox.Name = "customersTypeComboBox";
            this.customersTypeComboBox.Size = new System.Drawing.Size(209, 24);
            this.customersTypeComboBox.TabIndex = 3;
            this.customersTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customersTypeComboBox_SelectedIndexChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Cyan;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(63, 244);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(172, 69);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            this.calculateButton.MouseHover += new System.EventHandler(this.calculateButton_MouseHover);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Yellow;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.saveButton.Location = new System.Drawing.Point(63, 321);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(172, 66);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Amous of comsumption :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Price :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Subtotal : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(420, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Environment Fees :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(420, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "VAT ( 10%) :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(418, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "label9";
            // 
            // consumptionLabel
            // 
            this.consumptionLabel.Location = new System.Drawing.Point(578, 194);
            this.consumptionLabel.Name = "consumptionLabel";
            this.consumptionLabel.Size = new System.Drawing.Size(92, 16);
            this.consumptionLabel.TabIndex = 6;
            this.consumptionLabel.Text = "0";
            this.consumptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Location = new System.Drawing.Point(578, 247);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(92, 16);
            this.subtotalLabel.TabIndex = 6;
            this.subtotalLabel.Text = "0";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            this.envFeeLabel.Location = new System.Drawing.Point(578, 269);
            this.envFeeLabel.Name = "envFeeLabel";
            this.envFeeLabel.Size = new System.Drawing.Size(92, 27);
            this.envFeeLabel.TabIndex = 7;
            this.envFeeLabel.Text = "0";
            this.envFeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            this.VATLabel.Location = new System.Drawing.Point(578, 299);
            this.VATLabel.Name = "VATLabel";
            this.VATLabel.Size = new System.Drawing.Size(92, 17);
            this.VATLabel.TabIndex = 7;
            this.VATLabel.Text = "0";
            this.VATLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            this.priceLabel.Location = new System.Drawing.Point(578, 215);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(92, 26);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "0";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label24.Location = new System.Drawing.Point(418, 339);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(132, 29);
            this.label24.TabIndex = 7;
            this.label24.Text = "Total Bill :";
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.totalLabel.Location = new System.Drawing.Point(556, 339);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(121, 29);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label24);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.VATLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.envFeeLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.consumptionLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.customersTypeComboBox);
            this.Controls.Add(this.currentMonthComboBox);
            this.Controls.Add(this.thisMonthNumberInput);
            this.Controls.Add(this.lastMonthNumberInput);
            this.Controls.Add(this.numberOfPeopleInput);
            this.Controls.Add(this.customersNameInput);
            this.Controls.Add(this.customersCodeInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddInvoice";
            this.Size = new System.Drawing.Size(754, 546);
            this.Load += new System.EventHandler(this.AddInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customersCodeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customersNameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastMonthNumberInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numberOfPeopleInput;
        private System.Windows.Forms.TextBox thisMonthNumberInput;
        private System.Windows.Forms.ComboBox currentMonthComboBox;
        private System.Windows.Forms.ComboBox customersTypeComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label consumptionLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label envFeeLabel;
        private System.Windows.Forms.Label VATLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label totalLabel;
    }
}
