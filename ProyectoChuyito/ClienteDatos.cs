using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoChuyito
{
    public partial class ClienteDatos : Form
    {
        public SqlConnection ConexionBaseDatos;
        public bool Casado;
        public int PlanSug = 0;


        public ClienteDatos()
        {
            InitializeComponent();
            ConexionBaseDatos = new SqlConnection("Data Source = localhost\\SQLExpress; Initial Catalog = ProyectoChuy; User ID = sa; Password = 1234;");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtCurp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConexionBaseDatos.Open();
                String SQL = $"SELECT Nombre, Domicilio FROM Personas WHERE CURP = '{TxtCurp.Text}'";
                try
                {
                    using (SqlCommand command = new SqlCommand(SQL, ConexionBaseDatos))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TxtNombre.Text = Convert.ToString(reader.GetString(0));
                                TxtDomicilio.Text = Convert.ToString(reader.GetString(1));
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Curp no valida");
                }
                ConexionBaseDatos.Close();
            }
        }

        private void RdbCasado_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            NupHijos.Visible = true;
            Casado = true;
            NupIngresosMen.Enabled = true;
        }

        private void RdbSoltero_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = false;
            NupHijos.Visible = false;
            Casado = false;
            NupIngresosMen.Enabled = true;
        }

        private void NupIngresosMen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Casado == false)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((float)NupIngresosMen.Value * 0.80).ToString("N2");
                    if ((float)NupIngresosMen.Value * 0.80 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((float)NupIngresosMen.Value * 0.80 > 5000 && (float)NupIngresosMen.Value * 0.80 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((float)NupIngresosMen.Value * 0.80 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value == 0)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((float)NupIngresosMen.Value * 0.70).ToString("N2");

                    if ((float)NupIngresosMen.Value * 0.70 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((float)NupIngresosMen.Value * 0.70 > 5000 && (float)NupIngresosMen.Value * 0.70 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((float)NupIngresosMen.Value * 0.70 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value == 1)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((float)NupIngresosMen.Value * 0.60).ToString("N2");
                    if ((float)NupIngresosMen.Value * 0.60 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((float)NupIngresosMen.Value * 0.60 > 5000 && (float)NupIngresosMen.Value * 0.60 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((float)NupIngresosMen.Value * 0.60 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value == 2)
                {
                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((float)NupIngresosMen.Value * 0.55).ToString("N2");
                    if ((float)NupIngresosMen.Value * 0.55 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                    }
                    else if ((float)NupIngresosMen.Value * 0.55 > 5000 && (float)NupIngresosMen.Value * 0.55 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                    }
                    else if ((float)NupIngresosMen.Value * 0.55 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                    }
                }
                else if (Casado == true && NupHijos.Value > 2)
                {
                   

                    LblIngresos.Visible = true;
                    LblPlanSug.Visible = true;
                    LblIngresos.Text = "INGRESOS ACUMULABLES: $" + ((float)NupIngresosMen.Value * 0.50).ToString("N2");
                    if ((float)NupIngresosMen.Value * 0.50 <= 5000)
                    {
                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: BASICO";
                        PlanSug = 1;
                        PicBasicoMr.Visible = true;
                        PicOroMr.Visible = false;
                        PicPlatinumMr.Visible = false;
                    }
                    else if ((float)NupIngresosMen.Value * 0.50 > 5000 && (float)NupIngresosMen.Value * 0.50 <= 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: ORO";
                        PlanSug = 2;
                        PicOroMr.Visible = true;
                        PicBasicoMr.Visible = false;
                        PicPlatinumMr.Visible = false;
                    }
                    else if ((float)NupIngresosMen.Value * 0.50 > 18000)
                    {

                        LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO: PLATINUM";
                        PlanSug = 3;
                        PicPlatinumMr.Visible = true;
                        PicBasicoMr.Visible = false;
                        PicOroMr.Visible = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simulador simulador = new Simulador(PlanSug);
            //this.Visible = false;
            simulador.ShowDialog();
            this.Close();
        }

        private void ClienteDatos_Load(object sender, EventArgs e)
        {
            NupIngresosMen.Enabled = false;
          
        }

        private void PicPlatinum_Click(object sender, EventArgs e)
        {

        }

        private void NupIngresosMen_ValueChanged(object sender, EventArgs e)
        {
            NupIngresosMen.ThousandsSeparator = true;
        }
    }
}
