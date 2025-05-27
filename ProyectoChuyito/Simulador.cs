using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoChuyito
{
    public partial class Simulador : Form
    {
        public int PlanSug;
        public Simulador(int planSug)
        {
            InitializeComponent();
            PlanSug = planSug;
            if (PlanSug == 1)
            {
                LblPlanSug.Text = LblPlanSug.Text + " Basico";
                LblLimit.Text = LblLimit.Text + "$20,000.00 ";
                NupSaldoDeu.Maximum = 20000;
              
            }
            else if (PlanSug == 2)
            {
                LblLimit.Text = LblLimit.Text + "$50,000.00 ";
                LblPlanSug.Text = LblPlanSug.Text + " Oro";

                NupSaldoDeu.Maximum = 50000;
            }
            else if (PlanSug == 3)
            {
                LblLimit.Text = LblLimit.Text + "$200,000.00 ";
                LblPlanSug.Text = LblPlanSug.Text + " Platino";

                NupSaldoDeu.Maximum = 200000;
            }
        }

        private void NupSaldoDeu_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (PlanSug == 1)
                {
                    Lbl12Mes.Text = "SI PAGA EN 12 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.65).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.65 / 12).ToString("N2");
                    Lbl6Mes.Text = "SI PAGA EN 6 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.325).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.325 / 6).ToString("N2");   
                    Lbl3Mes.Text = "SI PAGA EN 3 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.1625).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.1625 / 3).ToString("N2");
                    Lbl1Mes.Text = "SI PAGA EN 1 MES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.0541).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.0541).ToString("N2");
                    if (NupSaldoDeu.Value >= 20000)
                        MessageBox.Show("El Saldo Maximo Es De 20000");
                }
                else if (PlanSug == 2)
                {
                    Lbl12Mes.Text = "SI PAGA EN 12 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.55).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.55 / 12).ToString("N2");
                    Lbl6Mes.Text = "SI PAGA EN 6 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.275).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.275 / 6).ToString("N2");
                    Lbl3Mes.Text = "SI PAGA EN 3 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.1375).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.1375 / 3).ToString("N2");
                    Lbl1Mes.Text = "SI PAGA EN 1 MES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.0458).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.0458).ToString("N2");
                    if (NupSaldoDeu.Value >= 50000)
                        MessageBox.Show("El Saldo Maximo Es De 50000");
                }
                else if (PlanSug == 3)
                {
                    Lbl12Mes.Text = "SI PAGA EN 12 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.45).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.45 / 12).ToString("N2");
                    Lbl6Mes.Text = "SI PAGA EN 6 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.225).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.225 / 6).ToString("N2"); 
                    Lbl3Mes.Text = "SI PAGA EN 3 MESES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.1125).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.1125 / 3).ToString("N2");
                    Lbl1Mes.Text = "SI PAGA EN 1 MES PAGARIA $" + ((float)NupSaldoDeu.Value * 1.0375).ToString("N2") + " Mensualidad: $" + ((float)NupSaldoDeu.Value * 1.0375).ToString("N2");
                    if (NupSaldoDeu.Value >= 200000)
                        MessageBox.Show("El Saldo Maximo Es De 200000");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void Simulador_Load(object sender, EventArgs e)
        {

        }

        private void NupSaldoDeu_ValueChanged(object sender, EventArgs e)
        {
            NupSaldoDeu.ThousandsSeparator = true;
        }

        private void TxtSaldoDeu_TextChanged(object sender, EventArgs e)
        {
            string texto = TxtSaldoDeu.Text.Replace(",", "").TrimStart('0');

            if (decimal.TryParse(texto, out decimal valor))
            {
                TxtSaldoDeu.TextChanged -= TxtSaldoDeu_TextChanged;
                TxtSaldoDeu.Text = string.Format("{0:N2}", valor);
                TxtSaldoDeu.SelectionStart = TxtSaldoDeu.Text.Length;
                TxtSaldoDeu.TextChanged += TxtSaldoDeu_TextChanged;
            }
        }
    }
}
