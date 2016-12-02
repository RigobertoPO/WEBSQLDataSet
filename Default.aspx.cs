using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSQLDataSet.Logica;

namespace WebSQLDataSet
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            { }
            else
            {
                cargarDatos();

            }
        }
              private void cargarDatos()
        {
             TiendaDataSetTableAdapters.ClientesTableAdapter DsDatos = new TiendaDataSetTableAdapters.ClientesTableAdapter();
            ClientesGridView.DataSource = DsDatos.GetData();
            ClientesGridView.DataBind();
        }

              protected void ClientesGridView_SelectedIndexChanged(object sender, EventArgs e)
              {
                  ClientesClass.Id = Convert.ToInt32(ClientesGridView.Rows[ClientesGridView.SelectedIndex].Cells[1].Text);
                  ClientesClass.Nombre = ClientesGridView.Rows[ClientesGridView.SelectedIndex].Cells[2].Text;
                  ClientesClass.Direccion = ClientesGridView.Rows[ClientesGridView.SelectedIndex].Cells[3].Text;
                  ClientesClass.Sexo = ClientesGridView.Rows[ClientesGridView.SelectedIndex].Cells[4].Text;
                  ClientesClass.FechaNacimiento =DateTime.Parse( ClientesGridView.Rows[ClientesGridView.SelectedIndex].Cells[5].Text);
                  EditarButton.Enabled = true;
                  EliminarButton.Enabled = true;
              }

              protected void NuevoButton_Click(object sender, EventArgs e)
              {
                  Logica.ClientesClass.esNuevo = true;
                  Response.Redirect("ClientesWF.aspx");
              }

              protected void EditarButton_Click(object sender, EventArgs e)
              {
                  Logica.ClientesClass.esNuevo = false;
                  Response.Redirect("ClientesWF.aspx");
              }

              protected void EliminarButton_Click(object sender, EventArgs e)
              {
                  Logica.ClientesClass.esNuevo = false;
                  Logica.ClientesClass.eliminarCliente(ClientesClass.Id);
                  cargarDatos();
              }
    }
}