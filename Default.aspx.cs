using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

              }

              protected void NuevoButton_Click(object sender, EventArgs e)
              {

              }

              protected void EditarButton_Click(object sender, EventArgs e)
              {

              }

              protected void EliminarButton_Click(object sender, EventArgs e)
              {

              }
    }
}