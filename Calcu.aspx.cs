using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorD
{
    public partial class Calcu : System.Web.UI.Page
    {
        static float a, c, d;
        static char b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Three_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Three.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Three.Text;
            }
        }

        protected void Four_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Four.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Four.Text;
            }
        }

        protected void Five_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Five.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Five.Text;
            }
        }

        protected void Six_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Six.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Six.Text;
            }
        }

        protected void Seven_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Seven.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Seven.Text;
            }
        }

        protected void Eight_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Eight.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Eight.Text;
            }
        }

        protected void Nine_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Nine.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Nine.Text;
            }
        }

        protected void Two_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Two.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Two.Text;
            }
        }

        protected void Zero_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text + Zero.Text;
            }

            else
            {
                TextBox1.Text = TextBox1.Text + Zero.Text;
            }
        }
        protected void One_Click(object sender, EventArgs e)
        {
            if ((TextBox1.Text == "+") || (TextBox1.Text == "-") || (TextBox1.Text == "*") || (TextBox1.Text == "/"))
            {

                TextBox1.Text = " ";
                TextBox1.Text = TextBox1.Text +One.Text;
            }
            
            else 
            {
                TextBox1.Text = TextBox1.Text + One.Text;
            }
        }


        protected void Clear_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            a = 0;
            b = '\0';
            c = 0;
            d = 0;
        }
        protected void Divide_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox1.Text, out a))
            {
                TextBox1.Text = "";
                b = '/';
            }
            else
            {
                // Handle parsing error
                TextBox1.Text = "Error";
            }
        }

        protected void Minus_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox1.Text, out a))
            {
                TextBox1.Text = "";
                b = '-';
            }
            else
            {
                // Handle parsing error
                TextBox1.Text = "Error";
            }
        }

        protected void Multiply_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox1.Text, out a))
            {
                TextBox1.Text = "";
                b = '*';
            }
            else
            {
                // Handle parsing error
                TextBox1.Text = "Error";
            }
        }

     

        protected void Plus_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox1.Text, out a))
            {
                TextBox1.Text = "";
                b = '+';
            }
            else
            {
                // Handle parsing error
                TextBox1.Text = "Error";
            }
        }

        protected void Equal_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TextBox1.Text, out c))
            {
                TextBox1.Text = "";

                // Handle division by zero
                if (b == '/' && c == 0)
                {
                    TextBox1.Text = "Error: Division by zero";
                    return;
                }

                switch (b)
                {
                    case '/':
                        d = a / c;
                        TextBox1.Text += d;
                        a = d;
                        break;
                    case '+':
                        d = a + c;
                        TextBox1.Text += d;
                        a = d;
                        break;
                    case '-':
                        d = a - c;
                        TextBox1.Text += d;
                        a = d;
                        break;
                    case '*':
                        d = a * c;
                        TextBox1.Text += d;
                        a = d;
                        break;
                }
            }
            else
            {
                // Handle parsing error
                TextBox1.Text = "Error";
            }
        }



    }
}