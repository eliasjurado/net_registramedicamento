using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EL1Repechaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtCod.Text, @"^[5-9]\d{5}$"))
            {
                MessageBox.Show("Ingrese un código válido");
            }
            //Regex para nombre de medicamento, incluye: numeros reales, porcentajes, grado del alcohol, logos registrados  
            else if (!Regex.IsMatch(txtNom.Text, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜñÑçÇ0-9\s\-\/\+\±\(\)\,\.\:\;\·\%\""\#\*\°\'\&\=\>\<\@\©\®\™\¼\¾\½\÷\‰]{4,}$"))
            {
                MessageBox.Show("Recuerde que el nombre de medicamento debe tener al menos 4 caracteres");
            }
            else if (cboEst.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un estado de producto válido");
            }
            else
            {
                MessageBox.Show("El registro ha sido exitoso");
            }

        }
    }
}
