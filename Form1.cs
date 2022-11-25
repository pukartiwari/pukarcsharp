namespace newproject3rd_sem
{
    public partial class Form1 : Form
    {
        string operate = "";
        decimal calculation = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void username_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "1";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "2";
            }

            else
            {

                string data = result.Text;
                result.Text = data + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "3";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "4";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "4";
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "5";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "6";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "7";
            }

            else

            {
                string data = result.Text;
                result.Text = data + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "8";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "9";
            }

            else
            {
                string data = result.Text;
                result.Text = data + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string data = result.Text;
            result.Text = data + ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (result.Text == "+" || result.Text == "-" || result.Text == "*" || result.Text == "/")
            {
                result.Text = "1";
            }

            else

            {
                string data = result.Text;
                result.Text = data + "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            result.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GetresultValue();
            calculation = Convert.ToDecimal(result.Text);
            operate = "+";
            result.Text = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            calculation = Convert.ToDecimal(result.Text);
            
            operate = "-";
            result.Text = "-";
        }

        private void GetresultValue()
        {
            if (result.Text != "" && result.Text != "+" && result.Text != "-" && result.Text != "*" && result.Text != "/")
            {
                calculation = Convert.ToDecimal(result.Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            GetresultValue();
            calculation = Convert.ToDecimal(result.Text);
            operate = "/";
            result.Text = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            GetresultValue();
            calculation = Convert.ToDecimal(result.Text);
            operate = "*";
            result.Text = "*";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            decimal firstnum = calculation;
            decimal secondnum = Convert.ToDecimal(result.Text);
            switch(operate)
            {
                case "+":
                    calculation = ( firstnum+secondnum);
                    result.Text = calculation.ToString();
                    break;
                    case "-":
                    calculation = (firstnum - secondnum);
                    result.Text = calculation.ToString();
                    break;
                case "*":
                    calculation = (firstnum * secondnum);
                    result.Text = calculation.ToString();
                    break;
                case "/":
                  
                    {
                        calculation = (firstnum / secondnum);
                        result.Text = calculation.ToString();
                        break;
                    }

            }
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 objectname = new form2();
            objectname.ShowDialog();
        }
    }
}