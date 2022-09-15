using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NachoOpera_Resta;
using Nacho_opera_multiplicacion;
using Nachopera.Suma;
using Nachopera.Division;

namespace Nacho_Opera
{
    public partial class Frm_Principal : Form
    {
        long a;
        long b;

        long Resultado;

        public Frm_Principal()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Btn_Sumar_Click(object sender, EventArgs e)
        {
            try
            {
                a = long.Parse(Txt_ValorA.Text);
                b = long.Parse(Txt_ValorB.Text);

                Resultado = Nachopera.Suma.Suma.Sumar(a, b);
                Lbl_Respuesta.Text = Convert.ToString(Resultado);
            }
            catch (Exception Err)
            {
                MessageBox.Show("Recuerde Ingresar Todos Los Campos Y Solo Numeros.\nCodigo De Error:" + Err.Message);
            }
        }

        private void Btn_Resta_Click(object sender, EventArgs e)
        {
            try
            {
                a = long.Parse(Txt_ValorA.Text);
                b = long.Parse(Txt_ValorB.Text);

                Resultado = NachoOpera_Resta.Resta.Re_Resta(a, b);
                Lbl_Respuesta.Text = Convert.ToString(Resultado);
            }
            catch (Exception Err)
            {
                MessageBox.Show("Recuerde Ingresar Todos Los Campos Y Solo Numeros.\nCodigo De Error:" + Err.Message);
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_ValorA.Text = "";
            Txt_ValorB.Text = "";
            Lbl_Respuesta.Text = "";
        }

        private void Btn_Multiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                a = long.Parse(Txt_ValorA.Text);
                b = long.Parse(Txt_ValorB.Text);

                Resultado = Nacho_opera_multiplicacion.multiplicacion.multi(a, b);
                Lbl_Respuesta.Text = Convert.ToString(Resultado);
            }
            catch (Exception Err)
            {
                MessageBox.Show("Recuerde Ingresar Todos Los Campos Y Solo Numeros.\nCodigo De Error:" + Err.Message);
            }

        }

        private void Btn_Division_Click(object sender, EventArgs e)
        {
            try
            {
                a = long.Parse(Txt_ValorA.Text);
                b = long.Parse(Txt_ValorB.Text);

                Resultado = Nachopera.Division.Division.Dividir(a, b);
                Lbl_Respuesta.Text = Convert.ToString(Resultado);
            }
            catch (Exception Err)
            {
                MessageBox.Show("Recuerde Ingresar Todos Los Campos Y Solo Numeros.\nCodigo De Error:" + Err.Message);
            }

        }
    }
}
