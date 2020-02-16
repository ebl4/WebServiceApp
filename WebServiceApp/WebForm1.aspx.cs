using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WebService1 webService;
        protected void Page_Load(object sender, EventArgs e)
        {
            webService = new WebService1();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<int> intList = new List<int> { 1,2,3,4};
            Label1.Text = "Saida do WebService: " + webService.Add(intList).ToString();
        }
    }
}