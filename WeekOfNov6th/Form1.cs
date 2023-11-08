using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double hi;
            if (rtbOutput.Text != "")
            {
                rtbOutput.Text += "\n";
            }
            if (double.TryParse(txtInput1.Text, out hi) == true || double.TryParse(txtInput2.Text, out hi) == true)
            {
                if (txtInput1.Text != "")
                {
                    double tryNum = double.Parse(txtInput1.Text);
                    if(rdoTempConverter1.Checked == true)
                    {
                        rtbOutput.Text += "Input 1: Celsius to Fahrenheit is " + ((tryNum * 9 / 5) + 32) + "\n";
                    }else if (rdoTempConverter2.Checked == true)
                    {
                        rtbOutput.Text += "Input 1: Fahrenheit to Celsius is " + ((tryNum - 32) * 5 / 9) + "\n";
                    }
                }
                if (txtInput2.Text != "")
                {
                    double tryNum = double.Parse(txtInput2.Text);
                    if (rdoTempConverter1.Checked == true)
                    {
                        rtbOutput.Text += "Input 2: Celsius to Fahrenheit is " + ((tryNum * 9 / 5) + 32) + "\n";
                    }
                    else if (rdoTempConverter2.Checked == true)
                    {
                        rtbOutput.Text += "Input 2: Fahrenheit to Celsius is " + ((tryNum - 32) * 5 / 9) + "\n";
                    }
                }
                
                
            }else
            {
                rtbOutput.Text += "Please input a convertable number!\n\n";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            double hi;
            if (double.TryParse(txtInput1.Text, out hi) == true || double.TryParse(txtInput2.Text, out hi) == true)
            {
                if (txtInput1.Text != "")
                {
                    double heyy = double.Parse(txtInput1.Text);
                    if (cmbMoneyConverter.Text == "Dollar - Yen")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} dollars is " + (heyy * 149.77) + " in yen\n";
                    }
                    if (cmbMoneyConverter.Text == "Yen - Dollar")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} yen is " + (heyy * 0.0067) + " in dollars\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Euro")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} dollars is " + (heyy * 0.93) + " in euros\n";
                    }
                    if (cmbMoneyConverter.Text == "Euro - Dollar")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} euros is " + (heyy * 1.07) + " in dollar\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Peso")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} dollars is " + (heyy * 17.54) + " in pesos\n";
                    }
                    if (cmbMoneyConverter.Text == "Peso - Dollar")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} pesos is " + (heyy * 0.057) + " in dollars\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Rupee")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} dollars is " + (heyy * 83.22) + " in rupees\n";
                    }
                    if (cmbMoneyConverter.Text == "Rupee - Dollar")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} rupees is " + (heyy * 0.012) + " in dollars\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Real")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} dollars is " + (heyy * 4.90) + " in reals\n";
                    }
                    if (cmbMoneyConverter.Text == "Real - Dollar")
                    {
                        rtbOutput.Text += $"Input 1: {txtInput1.Text} reals is " + (heyy * 0.20) + " in dollars\n";
                    }
                }
                if (txtInput2.Text != "")
                {
                    double heyy = double.Parse(txtInput2.Text);
                    if (cmbMoneyConverter.Text == "Dollar - Yen")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} dollars is " + (heyy * 149.77) + " in yen\n";
                    }
                    if (cmbMoneyConverter.Text == "Yen - Dollar")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} yen is " + (heyy * 0.0067) + " in dollars\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Euro")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} dollars is " + (heyy * 0.93) + " in euros\n";
                    }
                    if (cmbMoneyConverter.Text == "Euro - Dollar")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} euros is " + (heyy * 1.07) + " in dollar\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Peso")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} dollars is " + (heyy * 17.54) + " in pesos\n";
                    }
                    if (cmbMoneyConverter.Text == "Peso - Dollar")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} pesos is " + (heyy * 0.057) + " in dollars\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Rupee")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} dollars is " + (heyy * 83.22) + " in rupees\n";
                    }
                    if (cmbMoneyConverter.Text == "Rupee - Dollar")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} rupees is " + (heyy * 0.012) + " in dollars\n";
                    }
                    if (cmbMoneyConverter.Text == "Dollar - Real")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} dollars is " + (heyy * 4.90) + " in reals\n";
                    }
                    if (cmbMoneyConverter.Text == "Real - Dollar")
                    {
                        rtbOutput.Text += $"Input 2: {txtInput2.Text} reals is " + (heyy * 0.20) + " in dollars\n";
                    }

                }
            }else
            {
                rtbOutput.Text += "Please input a convertable number!\n";
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            double hi;

            if (double.TryParse(txtInput1.Text, out hi) == true || double.TryParse(txtInput2.Text, out hi) == true)
            {          
                if (txtInput1.Text != "")
                {
                    double one = double.Parse(txtInput1.Text);
                    if (chkMileToKilo.Checked == true)
                    {
                        rtbOutput.Text += $"Input 1: Converting {txtInput1.Text} from Miles to Kilometers is " + (one * 1.60934);
                    }
                    if (chkMileToKilo.Checked == true && chkMeterToInch.Checked == true)
                    {
                        rtbOutput.Text += " / ";
                    }
                    if (chkMeterToInch.Checked == true)
                    {
                        rtbOutput.Text += $"Converting {txtInput1.Text} from Meters to Inches is " + (one * 39.3701);
                    }   
                }
                if (txtInput2.Text != "")
                {
                    double two = double.Parse(txtInput2.Text);
                    rtbOutput.Text += "\n";
                    if (chkMileToKilo.Checked == true)
                    {
                        rtbOutput.Text += $"Input 2: Converting {txtInput2.Text} from Miles to Kilometers is " + (two * 1.60934);
                    }
                    if (chkMileToKilo.Checked == true && chkMeterToInch.Checked == true)
                    {
                        rtbOutput.Text += " / ";
                    }
                    if (chkMeterToInch.Checked == true)
                    {
                        rtbOutput.Text += $"Converting {txtInput2.Text} from Meters to Inches is " + (two * 39.3701);
                    }
                }
                
            }
            else
            {
                rtbOutput.Text += "Please input a convertable number!\n";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double hi;
            if (rtbOutput.Text != "")
            {
                rtbOutput.Text += "\n";
            }
            if (double.TryParse(txtInput1.Text, out hi) == true || double.TryParse(txtInput2.Text, out hi) == true)
            {
                if (txtInput1.Text != "")
                {
                    double one = double.Parse(txtInput1.Text);
                    if (chkKiloToMiles.Checked == true)
                    {
                        rtbOutput.Text += $"Input 1: Converting {txtInput1.Text} from Kilometers to Miles is " + (one * 0.621371);
                    }
                    if (chkKiloToMiles.Checked == true && chkInchToMeter.Checked == true)
                    {
                        rtbOutput.Text += " / ";
                    }
                    if (chkInchToMeter.Checked == true)
                    {
                        rtbOutput.Text += $"Converting {txtInput1.Text} from Inches to Meters is " + (one * 0.0254);
                    }
                }
                if (txtInput2.Text != "")
                {
                    double two = double.Parse(txtInput2.Text);
                    rtbOutput.Text += "\n";
                    if (chkKiloToMiles.Checked == true)
                    {
                        rtbOutput.Text += $"Input 2: Converting {txtInput2.Text} from Kilometers to Miles is " + (two * 0.621371);
                    }
                    if (chkKiloToMiles.Checked == true && chkInchToMeter.Checked == true)
                    {
                        rtbOutput.Text += " / ";
                    }
                    if (chkInchToMeter.Checked == true)
                    {
                        rtbOutput.Text += $"Converting {txtInput2.Text} from Inches to Meters is " + (two * 0.0254);
                    }
                }

            }
            else
            {
                rtbOutput.Text += "Please input a convertable number!\n";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string line = System.IO.File.ReadAllText("test.txt.txt");

            rtbOutput.Text += line + "\n\n";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int n;

            //this line of code came from Mr. L if you are wondering why it's not streamreader
            string line = System.IO.File.ReadAllText("test.txt.txt");

            string[] arr = line.Split(' ');
            rtbOutput.Text += "The length is " + arr.Length + "\n";

            if (int.TryParse(txtInput1.Text, out n) && n > 0)
            {
                int hey = int.Parse(txtInput1.Text);

                List<string> selectedWords = new List<string>();

                for (int i = n - 1; i < arr.Length; i += n)
                {
                    selectedWords.Add(arr[i]);
                }

                rtbOutput.Text += string.Join(" ", selectedWords);
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (i == 0 || i == 4 || i == 8 || i == 14 || i == 20)
                {
                    alphabet[i] = (char)('A' + i);
                }else
                {
                    alphabet[i] = (char)('a' + i);
                }
                
                rtbOutput.Text += alphabet[i] + " ";
            }
            rtbOutput.Text += "\n\n";

            int hyy = alphabet.Length - 1;
            int count = 0;
            while (hyy >= 0)
            {
                char alpha = alphabet[hyy];
                if (count % 5 == 0)
                {
                    rtbOutput.Text += (char.ToLower(alpha) + ", ");
                }else
                {
                    rtbOutput.Text += (char.ToUpper(alpha) + " ");
                }
                count++;
                hyy--;
            }

        }
    }
}
