using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjQuizFeira
{
    public partial class FormFacil : Form
    {
        public FormFacil()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormFacil1 f1 = new FormFacil1();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormFacil_Load(object sender, EventArgs e)
        {

        }
    }
}
