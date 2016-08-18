using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator.Models
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static double a;
        static char operation;

        protected void Button14_Click(object sender, EventArgs e)
        {
            Label1.Text += 0;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Label1.Text += ",";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Label1.Text += 1;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Label1.Text += 2;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Label1.Text += 3;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Label1.Text += 4;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Label1.Text += 5;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Label1.Text += 6;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text += 7;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text += 8;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text += 9;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = String.Empty;
            Label2.Text = String.Empty;
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (Label1.Text != string.Empty)
            {
                a = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + " + ";
                Label1.Text = String.Empty;
                operation = char.Parse("+");
            }
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if ((Label1.Text != string.Empty) && (Label2.Text != string.Empty) && operation.ToString()!= string.Empty)
            {
                Label3.Text += Label2.Text + Label1.Text;
                switch (operation)
                {
                    case '+':
                        Label1.Text = (a + Convert.ToDouble(Label1.Text)).ToString();
                        Label2.Text = string.Empty;
                        break;
                    case '-':
                        Label1.Text = (a - Convert.ToDouble(Label1.Text)).ToString();
                        Label2.Text = string.Empty;
                        break;
                    case '*':
                        Label1.Text = (a * Convert.ToDouble(Label1.Text)).ToString();
                        Label2.Text = string.Empty;
                        break;
                    case '/':
                        Label1.Text = (a / Convert.ToDouble(Label1.Text)).ToString();
                        Label2.Text = string.Empty;
                        break;
                    default:
                        Label2.Text = "Error ";
                        Label1.Text = "Error";
                        break;
                }
                Label3.Text += " = " + Label1.Text + "</br>";
            }
            else Label3.Text = "Error";
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            if (Label1.Text != string.Empty)
            {
                a = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + " - ";
                Label1.Text = String.Empty;
                operation = '-';
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            if (Label1.Text != string.Empty)
            {
                a = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + " * ";
                Label1.Text = String.Empty;
                operation = '*';
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if (Label1.Text != string.Empty)
            {
                a = Convert.ToDouble(Label1.Text);
                Label2.Text = Label1.Text + " / ";
                Label1.Text = String.Empty;
                operation = '/';
            }
        }
    }
}
//http://calculator2016.azurewebsites.net