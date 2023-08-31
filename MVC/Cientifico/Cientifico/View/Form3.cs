using Cientifico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cientifico.View
{
    public partial class FormCrearCientifico : Form
    {
        public Cientific CientificoCreado { get; private set; }

        public FormCrearCientifico()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nomApels = txtNomApels.Text;

            if (!string.IsNullOrWhiteSpace(dni) && !string.IsNullOrWhiteSpace(nomApels))
            {
                CientificoCreado = new Cientific(dni, nomApels);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
