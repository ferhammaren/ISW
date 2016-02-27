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
            //hacemos invisibles los mensajes de error
            notFound.Visible = false;
            errorMsg.Visible = false;
            if (ImageButton1.ImageUrl.Equals("/images/ES.png")) //asignamos la sesion lenguaje segun la url del boton
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
            if (uNBox.Text.Equals("") || pWBox.Text.Equals("")) //ponemos los campos que falten en color rojo para decirle al usuario
                //que esta menso y no lleno lo que debia
            {
                if (uNBox.Text.Equals(""))
                {
                    uNBox.BackColor= System.Drawing.ColorTranslator.FromHtml("#ffb3b3");
                }
                else
                {
                    pWBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffb3b3");
                }
                errorMsg.Visible = true; //hacemos visible el mensaje de errors
               
            }
            else { 
            Session["username"] = uNBox.Text;
            Session["pass"] = pWBox.Text; //asignamos las sesiones de username y password
                bool userExists = false;
                userExists = Usuarios.validarUsuario(Session["username"].ToString(), Session["pass"].ToString()); //verificamos que exista
                //el usuario. Es importante ver que este metodo validar usuario es un metodo estatico, de otra forma
                //no podemos llamarlo asi como lo tengo aqui.
                if (userExists == true)
                {
                    Response.Redirect("index.aspx"); //si el usuario existe entonces te manda a la pagina index
                }
                else
                {
                    notFound.Visible = true; //si no pues te deja en la pagina de login y te dice que el usuario no fue encontrado
                }
               
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
         //metodo click para cambiar el lenguaje. Tengo un poco de duda con esto porque no te esta redireccionando a otra pagina,
         //simplemente esta recargando la pagina para actualizar los labels y que salgan en el otro lenguaje. Se mira un poco de lag
         //porque el sitio no esta desplegado, se esta corriendo localmente y pues ahi siempre se tarda un poco mas pero una vez que se
         //despliega, entonces si se hace en tiempo real sin lag. 
            
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