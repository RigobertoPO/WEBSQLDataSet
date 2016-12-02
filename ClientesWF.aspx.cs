using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebSQLDataSet.Logica;

namespace WebSQLDataSet
{
    public partial class ClientesWF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
            }
            else
            {
                if (ClientesClass.esNuevo)
                {
                    this.IdTextBox.Text = "";
                    this.NombreTextBox.Text = "";
                    this.DireccionTextBox.Text = "";
                    
                }
                else
                {
                    this.IdTextBox.Text = ClientesClass.Id.ToString();
                    this.NombreTextBox.Text = ClientesClass.Nombre;
                    this.DireccionTextBox.Text = ClientesClass.Direccion;
                    if (ClientesClass.Sexo == "M")
                    { MasculinoRadioButton.Checked = true; }
                    else
                    { FemeninoRadioButton.Checked = true; }
                    FechaNacimientoCalendar.SelectedDate = ClientesClass.FechaNacimiento;
                }
            }
        }
        public string _sexo { get; set; }
        protected void AceptarButton_Click(object sender, EventArgs e)
        {
            if (MasculinoRadioButton.Checked)
            { _sexo = "M"; }
            else
            { _sexo = "F"; }

            if (ClientesClass.esNuevo)
            {
                
                ClientesClass.nuevoCliente(NombreTextBox.Text, DireccionTextBox.Text,_sexo,FechaNacimientoCalendar.SelectedDate.ToString());
                Response.Redirect("Default.aspx");
            }
            else
            {
                ClientesClass.editarCliente(Convert.ToInt32(IdTextBox.Text), NombreTextBox.Text, DireccionTextBox.Text, ClientesClass.Id, _sexo, FechaNacimientoCalendar.SelectedDate.ToString());
                Response.Redirect("Default.aspx");
            }
        }

        protected void SalirButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}