using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguranca2010;

public partial class Login : System.Web.UI.Page
{

    //deve-se delclara as BLLs
    BLLSeguranca Seguranca = new BLLSeguranca();
    BLLComum Comum = new BLLComum();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogar_Click(object sender, EventArgs e)
    {
        if (!Seguranca.Logar(UserName.Text, Senha.Text, 67))
        {
            erro.Text = "Verifique sua senha e Login!";
            Senha.Focus();
        }
    }

}