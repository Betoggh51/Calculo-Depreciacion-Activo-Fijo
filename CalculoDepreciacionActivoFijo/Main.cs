using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDepreciacionActivoFijo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void lineaRectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineaRecta lineaRecta = new LineaRecta();
            lineaRecta.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void añosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DigitoAños digitoAños = new DigitoAños();
            digitoAños.ShowDialog();
        }
    }
}
