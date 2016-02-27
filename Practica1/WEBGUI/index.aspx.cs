using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBGUI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //woohoo empieza lo bueno. Al label2 le ponemos el contenido de la sesion username. Facilito.
            Label2.Text = Session["username"].ToString();
            if (Session["language"].Equals(null)) //como es posible que hayamos cambiado el lenguaje en la pagina
                //anterior, debemos checar que idioma es el que tenemos asignado para mostrar la pagina en el 
                //lenguaje correspondiente.
            {
                Session["language"] = "ES";
            }else if (Session["language"].Equals("ES"))
            {
                Page.Title = "Página de usuario";
                Label1.Text = "Bienvenido ";
                GridView1.Columns[0].HeaderText = "Nombre";
                GridView1.Columns[1].HeaderText = "Correo";
                GridView1.Columns[2].HeaderText = "Organización";
                GridView1.Columns[3].HeaderText = "Último Acceso"; //tal vez esto se pueda hacer en un metodo especifico... te lo dejo
                //de tarea xD un metodo pues que contenga todos los cambios de lenguaje y aqui simplemente se mande llamars
            }
            else if (Session["language"].Equals("EN"))
            {
                Page.Title = "User Page";
                Label1.Text = "Welcome ";
                GridView1.Columns[0].HeaderText = "Name";
                GridView1.Columns[1].HeaderText = "E-Mail";
                GridView1.Columns[2].HeaderText = "Organization";
                GridView1.Columns[3].HeaderText = "Last Access";
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //lo mismo, el cambio de idioma dandole click al boton
            if (Session["language"].Equals("ES"))
            {
                ImageButton1.ImageUrl = "/images/EN.png";
                Session["language"] = "EN";
                Label1.Text = "Welcome ";
                GridView1.Columns[0].HeaderText = "Name"; //asi es como cambias el texto del header de una columna de un
                //gridview
                GridView1.Columns[1].HeaderText = "E-Mail";
                GridView1.Columns[2].HeaderText = "Organization";
                GridView1.Columns[3].HeaderText = "Last Access";

            }
            else
            {
                ImageButton1.ImageUrl = "/images/ES.png";
                Session["language"] = "ES";
                Label1.Text = "Bienvenido ";
                GridView1.Columns[0].HeaderText = "Nombre";
                GridView1.Columns[1].HeaderText = "Correo";
                GridView1.Columns[2].HeaderText = "Organización";
                GridView1.Columns[3].HeaderText = "Último Acceso";

            }
        }
    }
}