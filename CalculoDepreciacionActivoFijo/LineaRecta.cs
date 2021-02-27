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
    public partial class LineaRecta : Form
    {
        public LineaRecta()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LlenarDGV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Años");
            dt.Columns.Add("Monto Depreciacion Anual");
            dt.Columns.Add("Depreciacion Acumulada");
            dt.Columns.Add("Depreciacion Restante");


            double monto = double.Parse(txtMonto.Text);
            int anio = int.Parse(txtAnio.Text);

            double depreciacionAnual = monto / anio;
            double depreciacionAcumulada = 0;
            double depreciacionRestante = 0;


            for (int i = 1; i <= anio; i++)
            {
                DataRow fila = dt.NewRow();

                depreciacionAcumulada = depreciacionAnual * i;
                depreciacionRestante = monto - depreciacionAcumulada;

                fila["Años"] = i;
                fila["Monto Depreciacion Anual"] = depreciacionAnual;
                fila["Depreciacion Acumulada"] = depreciacionAcumulada;
                fila["Depreciacion Restante"] = depreciacionRestante;

                dt.Rows.Add(fila);
                dataGridView1.DataSource = dt;

                if (depreciacionRestante <= 0)
                    break;
            }

            dataGridView1.Refresh();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LlenarDGV();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
