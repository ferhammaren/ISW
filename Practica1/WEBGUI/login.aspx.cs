using Practica1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBGUI
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            notFound.Visible = false;
            errorMsg.Visible = false;
            if (ImageButton1.ImageUrl.Equals("/images/ES.png"))
            {
                Session["language"] = "ES";
            }
            else
            {
                Session["language"] = "EN";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (uNBox.Text.Equals("") || pWBox.Text.Equals(""))
            {
                if (uNBox.Text.Equals(""))
                {
                    uNBox.BackColor= System.Drawing.ColorTranslator.FromHtml("#ffb3b3");
                }
                else
                {
                    pWBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3b3");
                }
                errorMsg.Visible = true;
               
            }
            else { 
            Session["username"] = uNBox.Text;
            Session["pass"] = pWBox.Text;
                bool userExists = false;
                userExists = Usuarios.validarUsuario(Session["username"].ToString(), Session["pass"].ToString());
                if (userExists == true)
                {
                    Response.Redirect("index.aspx");
                }
                else
                {
                    notFound.Visible = true;
                }
               
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
          
            
            if (Session["language"].Equals("ES"))
            {
                ImageButton1.ImageUrl = "/images/EN.png";
                Session["language"] = "EN";
                Label1.Text = "Username: ";
                Label2.Text = "Password";
                enter.Text = "Login";
                errorMsg.Text = "Error: Missing fields";
                notFound.Text = "Error: User not found";
                Page.Title = "Login";   
            }
            else
            {
                ImageButton1.ImageUrl = "/images/ES.png";
                Session["language"] = "ES";
                Label1.Text = "Nombre de Usuario";
                Label2.Text = "Contraseña";
                enter.Text = "Ingresar";
                errorMsg.Text = "Error: te faltan campos";
                notFound.Text = "Error: Usuario no encontrado";
                Page.Title = "Inicio";
            }
        }
    }
}