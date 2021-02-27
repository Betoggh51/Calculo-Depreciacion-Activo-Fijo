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
    public partial class DigitoAños : Form
    {
        public DigitoAños()
        {
            InitializeComponent();
        }

        private void DigitoAños_Load(object sender, EventArgs e)
        {

        }

        private void LlenarDGV()
        {
            double valor = int.Parse(Valor.Text);
            int anio = int.Parse(txtAnio.Text);
            double vidaUtil = (anio * (anio + 1)) / 2;
            double fraccionAnio = 0;
            double valorDesecho = double.Parse(txtDesecho.Text);
            double j = anio;

            double depreciacionAnual = 0;
            double depreciacionAcumulada = 0;
            double depreciacionRestante = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("Años");
            dt.Columns.Add("Monto Depreciacion Anual");
            dt.Columns.Add("Depreciacion Acumulada");
            dt.Columns.Add("Depreciacion Restante");


            for (int i = 1; i <= anio; i++)
            {
                DataRow fila = dt.NewRow();

                fraccionAnio = j / vidaUtil;
                depreciacionAnual = fraccionAnio * (valor - valorDesecho);
                depreciacionAcumulada += depreciacionAnual;
                depreciacionRestante = valor - depreciacionAcumulada;

                MessageBox.Show(fraccionAnio.ToString());

                fila["Años"] = i;
                fila["Monto Depreciacion Anual"] = depreciacionAnual;  
                fila["Depreciacion Acumulada"] = depreciacionAcumulada;
                fila["Depreciacion Restante"] = depreciacionRestante;

                dt.Rows.Add(fila);
                dataGridView1.DataSource = dt;

                j--;
            }

            dataGridView1.Refresh();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LlenarDGV();
        }
    }
}
