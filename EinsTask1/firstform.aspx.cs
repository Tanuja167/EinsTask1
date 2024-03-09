using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EinsTask1
{
    public partial class firstform : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList1.Items.Add("large");
                DropDownList1.Items.Add("smallest");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string options = DropDownList1.SelectedValue;

            txtresult.Text = options;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            int num3 = Convert.ToInt32(TextBox3.Text);
            // int large = 0;

            /*if(num1>num2)
            {
                if(num1>num3)
                {
                    large = num1;
                }
                else
                {
                    large = num3;
                }
            }
            else 
            {
                large = num2;
            }*/


            if (DropDownList1.SelectedValue == "large")
            {
                int large = Math.Max(num1, (Math.Max(num1, num3)));
                txtresult.Text = $"Largest : {large}";

            }
            else if (DropDownList1.SelectedValue == "smallest")
            {
                int smallest = Math.Min(num1, Math.Min(num2, num3));
                txtresult.Text = $"Smallest :  {smallest}";
            }
        }
    }
}