using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio__15._4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click1(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(num1.Text);
            double number2 = Convert.ToDouble(num2.Text);

            double sum = number1 + number2;

            result.Text = sum.ToString();
        }
    }
}