using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerApp2025C
{
    public partial class frmDataGrid : Form
    {
        public frmDataGrid()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialogDataGrid.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialogDataGrid.FileName;
                int total = dgvDatos.Rows.Count - 1;
                string linea = "";
                for (int i = 0; i < total; i++)
                {

                    for (int j = 0; j < dgvDatos.Columns.Count; j++)
                    {
                        if (j == dgvDatos.Columns.Count - 1)
                            linea += dgvDatos.Rows[i].Cells[j].Value.ToString() + "\n";
                        else
                            linea += dgvDatos.Rows[i].Cells[j].Value.ToString() + ",";
                    }

                }
                File.WriteAllText(filename, linea);
            }

        }

        private void saveFileDialogDataGrid_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult abrir = openFileDialog1.ShowDialog();

            if (abrir == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                try
                {
                    
                    string[] lines = File.ReadAllLines(filename);

                    
                    dgvDatos.Rows.Clear();
                    dgvDatos.Columns.Clear();

                    if (lines.Length > 0)
                    {
                       
                        string[] columnas = lines[0].Split(',');

                        foreach (string col in columnas)
                        {
                            dgvDatos.Columns.Add(col, col);
                        }

                        
                        for (int i = 1; i < lines.Length; i++)
                        {
                            string[] valores = lines[i].Split(',');

                       
                            if (valores.Length == dgvDatos.Columns.Count)
                            {
                                dgvDatos.Rows.Add(valores);
                            }
                            else
                            {
                                MessageBox.Show($"La línea {i + 1} del archivo tiene un número incorrecto de columnas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
