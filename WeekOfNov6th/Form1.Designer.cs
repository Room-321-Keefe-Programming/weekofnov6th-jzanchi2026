namespace WeekOfNov6th
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemperatureConverter = new System.Windows.Forms.Label();
            this.lblMoneyConvert = new System.Windows.Forms.Label();
            this.rdoTempConverter1 = new System.Windows.Forms.RadioButton();
            this.rdoTempConverter2 = new System.Windows.Forms.RadioButton();
            this.grpTempConverter = new System.Windows.Forms.GroupBox();
            this.cmbMoneyConverter = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblDistanceConverter = new System.Windows.Forms.Label();
            this.chkMeterToInch = new System.Windows.Forms.CheckBox();
            this.chkMileToKilo = new System.Windows.Forms.CheckBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.chkInchToMeter = new System.Windows.Forms.CheckBox();
            this.chkKiloToMiles = new System.Windows.Forms.CheckBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.grpTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatureConverter
            // 
            this.lblTemperatureConverter.AutoSize = true;
            this.lblTemperatureConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureConverter.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTemperatureConverter.Location = new System.Drawing.Point(42, 68);
            this.lblTemperatureConverter.Name = "lblTemperatureConverter";
            this.lblTemperatureConverter.Size = new System.Drawing.Size(236, 26);
            this.lblTemperatureConverter.TabIndex = 0;
            this.lblTemperatureConverter.Text = "Temperature Converter";
            // 
            // lblMoneyConvert
            // 
            this.lblMoneyConvert.AutoSize = true;
            this.lblMoneyConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyConvert.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMoneyConvert.Location = new System.Drawing.Point(42, 142);
            this.lblMoneyConvert.Name = "lblMoneyConvert";
            this.lblMoneyConvert.Size = new System.Drawing.Size(178, 26);
            this.lblMoneyConvert.TabIndex = 1;
            this.lblMoneyConvert.Text = "Money Converter";
            // 
            // rdoTempConverter1
            // 
            this.rdoTempConverter1.AutoSize = true;
            this.rdoTempConverter1.Location = new System.Drawing.Point(18, 31);
            this.rdoTempConverter1.Name = "rdoTempConverter1";
            this.rdoTempConverter1.Size = new System.Drawing.Size(196, 28);
            this.rdoTempConverter1.TabIndex = 2;
            this.rdoTempConverter1.TabStop = true;
            this.rdoTempConverter1.Text = "Celsius - Fahrenheit";
            this.rdoTempConverter1.UseVisualStyleBackColor = true;
            // 
            // rdoTempConverter2
            // 
            this.rdoTempConverter2.AutoSize = true;
            this.rdoTempConverter2.Location = new System.Drawing.Point(234, 31);
            this.rdoTempConverter2.Name = "rdoTempConverter2";
            this.rdoTempConverter2.Size = new System.Drawing.Size(196, 28);
            this.rdoTempConverter2.TabIndex = 3;
            this.rdoTempConverter2.TabStop = true;
            this.rdoTempConverter2.Text = "Fahrenheit - Celsius";
            this.rdoTempConverter2.UseVisualStyleBackColor = true;
            // 
            // grpTempConverter
            // 
            this.grpTempConverter.Controls.Add(this.rdoTempConverter1);
            this.grpTempConverter.Controls.Add(this.rdoTempConverter2);
            this.grpTempConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempConverter.ForeColor = System.Drawing.Color.IndianRed;
            this.grpTempConverter.Location = new System.Drawing.Point(321, 38);
            this.grpTempConverter.Name = "grpTempConverter";
            this.grpTempConverter.Size = new System.Drawing.Size(458, 77);
            this.grpTempConverter.TabIndex = 4;
            this.grpTempConverter.TabStop = false;
            this.grpTempConverter.Tag = "";
            this.grpTempConverter.Text = "Convert";
            // 
            // cmbMoneyConverter
            // 
            this.cmbMoneyConverter.BackColor = System.Drawing.Color.SeaShell;
            this.cmbMoneyConverter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneyConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMoneyConverter.ForeColor = System.Drawing.Color.IndianRed;
            this.cmbMoneyConverter.FormattingEnabled = true;
            this.cmbMoneyConverter.Items.AddRange(new object[] {
            "Dollar - Yen",
            "Yen - Dollar",
            "Dollar - Euro",
            "Euro - Dollar",
            "Dollar - Peso",
            "Peso - Dollar",
            "Dollar - Rupee",
            "Rupee - Dollar",
            "Dollar - Real",
            "Real - Dollar"});
            this.cmbMoneyConverter.Location = new System.Drawing.Point(321, 142);
            this.cmbMoneyConverter.Name = "cmbMoneyConverter";
            this.cmbMoneyConverter.Size = new System.Drawing.Size(155, 32);
            this.cmbMoneyConverter.TabIndex = 5;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SeaShell;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.IndianRed;
            this.btn1.Location = new System.Drawing.Point(846, 48);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(165, 66);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Temp Convert - \r\nGo!";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOutput.ForeColor = System.Drawing.Color.IndianRed;
            this.rtbOutput.Location = new System.Drawing.Point(47, 478);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(964, 148);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SeaShell;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.IndianRed;
            this.btn2.Location = new System.Drawing.Point(846, 136);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(165, 58);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "Money Convert -\r\nGo!\r\n";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.ForeColor = System.Drawing.Color.IndianRed;
            this.txtInput2.Location = new System.Drawing.Point(321, 411);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(169, 29);
            this.txtInput2.TabIndex = 9;
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.ForeColor = System.Drawing.Color.IndianRed;
            this.txtInput1.Location = new System.Drawing.Point(47, 411);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(173, 29);
            this.txtInput1.TabIndex = 10;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.ForeColor = System.Drawing.Color.IndianRed;
            this.lblInput1.Location = new System.Drawing.Point(43, 372);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(61, 24);
            this.lblInput1.TabIndex = 11;
            this.lblInput1.Text = "Input1";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput2.ForeColor = System.Drawing.Color.IndianRed;
            this.lblInput2.Location = new System.Drawing.Point(317, 372);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(61, 24);
            this.lblInput2.TabIndex = 12;
            this.lblInput2.Text = "Input2";
            // 
            // lblDistanceConverter
            // 
            this.lblDistanceConverter.AutoSize = true;
            this.lblDistanceConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceConverter.ForeColor = System.Drawing.Color.IndianRed;
            this.lblDistanceConverter.Location = new System.Drawing.Point(42, 243);
            this.lblDistanceConverter.Name = "lblDistanceConverter";
            this.lblDistanceConverter.Size = new System.Drawing.Size(196, 25);
            this.lblDistanceConverter.TabIndex = 13;
            this.lblDistanceConverter.Tag = "";
            this.lblDistanceConverter.Text = "Distance Converter";
            // 
            // chkMeterToInch
            // 
            this.chkMeterToInch.AutoSize = true;
            this.chkMeterToInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMeterToInch.ForeColor = System.Drawing.Color.IndianRed;
            this.chkMeterToInch.Location = new System.Drawing.Point(570, 240);
            this.chkMeterToInch.Name = "chkMeterToInch";
            this.chkMeterToInch.Size = new System.Drawing.Size(167, 28);
            this.chkMeterToInch.TabIndex = 14;
            this.chkMeterToInch.Text = "Meters to Inches";
            this.chkMeterToInch.UseVisualStyleBackColor = true;
            // 
            // chkMileToKilo
            // 
            this.chkMileToKilo.AutoSize = true;
            this.chkMileToKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMileToKilo.ForeColor = System.Drawing.Color.IndianRed;
            this.chkMileToKilo.Location = new System.Drawing.Point(321, 240);
            this.chkMileToKilo.Name = "chkMileToKilo";
            this.chkMileToKilo.Size = new System.Drawing.Size(186, 28);
            this.chkMileToKilo.TabIndex = 15;
            this.chkMileToKilo.Tag = "";
            this.chkMileToKilo.Text = "Miles to Kilometers";
            this.chkMileToKilo.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SeaShell;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.IndianRed;
            this.btn3.Location = new System.Drawing.Point(846, 243);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(165, 31);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "Convert Top";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // chkInchToMeter
            // 
            this.chkInchToMeter.AutoSize = true;
            this.chkInchToMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInchToMeter.ForeColor = System.Drawing.Color.IndianRed;
            this.chkInchToMeter.Location = new System.Drawing.Point(570, 290);
            this.chkInchToMeter.Name = "chkInchToMeter";
            this.chkInchToMeter.Size = new System.Drawing.Size(167, 28);
            this.chkInchToMeter.TabIndex = 17;
            this.chkInchToMeter.Text = "Inches to Meters";
            this.chkInchToMeter.UseVisualStyleBackColor = true;
            // 
            // chkKiloToMiles
            // 
            this.chkKiloToMiles.AutoSize = true;
            this.chkKiloToMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKiloToMiles.ForeColor = System.Drawing.Color.IndianRed;
            this.chkKiloToMiles.Location = new System.Drawing.Point(321, 290);
            this.chkKiloToMiles.Name = "chkKiloToMiles";
            this.chkKiloToMiles.Size = new System.Drawing.Size(186, 28);
            this.chkKiloToMiles.TabIndex = 18;
            this.chkKiloToMiles.Text = "Kilometers to Miles";
            this.chkKiloToMiles.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SeaShell;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.IndianRed;
            this.btn4.Location = new System.Drawing.Point(846, 287);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(165, 31);
            this.btn4.TabIndex = 19;
            this.btn4.Text = "Convert Bottom Row";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.SeaShell;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.IndianRed;
            this.btn5.Location = new System.Drawing.Point(846, 372);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(165, 58);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "Clear!!";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1061, 648);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.chkKiloToMiles);
            this.Controls.Add(this.chkInchToMeter);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.chkMileToKilo);
            this.Controls.Add(this.chkMeterToInch);
            this.Controls.Add(this.lblDistanceConverter);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.cmbMoneyConverter);
            this.Controls.Add(this.grpTempConverter);
            this.Controls.Add(this.lblMoneyConvert);
            this.Controls.Add(this.lblTemperatureConverter);
            this.Name = "Form1";
            this.Text = " ";
            this.grpTempConverter.ResumeLayout(false);
            this.grpTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatureConverter;
        private System.Windows.Forms.Label lblMoneyConvert;
        private System.Windows.Forms.RadioButton rdoTempConverter1;
        private System.Windows.Forms.RadioButton rdoTempConverter2;
        private System.Windows.Forms.GroupBox grpTempConverter;
        private System.Windows.Forms.ComboBox cmbMoneyConverter;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblDistanceConverter;
        private System.Windows.Forms.CheckBox chkMeterToInch;
        private System.Windows.Forms.CheckBox chkMileToKilo;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.CheckBox chkInchToMeter;
        private System.Windows.Forms.CheckBox chkKiloToMiles;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
    }
}

