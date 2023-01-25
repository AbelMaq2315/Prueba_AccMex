using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Data.SqlClient;
using System.Data;
using ABB_ACCMEX.Datos;

namespace ABB_ACCMEX.Presentacion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        ConexionBD_ABBACCMEX conexionBD = new ConexionBD_ABBACCMEX();

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            //conexionBD.Abrir();
            table = conexionBD.Confirmar(ID.Text, Contrasena.Text);
            //conexionBD.Cerrar();
            if (table.Rows.Count > 0)
            {
                Navigation.PushAsync(new Index());
            }
            else
            {
                Console.WriteLine("No Paso");
            }


        }
    }
}