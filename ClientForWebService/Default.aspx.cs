using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;
using System.Web.UI.WebControls;



public partial class _Default : System.Web.UI.Page
{
    int a, b, c;
    //   create the object of the web service class  - a proxy class on client side
    localhost.WebService client = new localhost.WebService();
 
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = client.Add(a, b);
        lblResult.Text = c.ToString();
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = client.Sub(a, b);
        lblResult.Text = c.ToString();
    }
    protected void BtnMul_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = client.Mul(a, b);
        lblResult.Text = c.ToString();
    }
    protected void btnDiv_Click(object sender, EventArgs e)
    {
        a = Convert.ToInt32(txtFno.Text);
        b = Convert.ToInt32(txtSno.Text);
        c = client.Div(a, b);
        lblResult.Text = c.ToString();
    }
}