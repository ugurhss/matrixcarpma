using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrixcarpma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Sütun 1");
            dataGridView1.Columns.Add("Column2", "Sütun 2");
            dataGridView1.Columns.Add("Column3", "Sütun 3");

            dataGridView2.Columns.Add("Column1", "Sütun 1");
            dataGridView2.Columns.Add("Column2", "Sütun 2");
            dataGridView2.Columns.Add("Column3", "Sütun 3");

            dataGridView3.Columns.Add("Column1", "Sütun 1");
            dataGridView3.Columns.Add("Column2", "Sütun 2");
            dataGridView3.Columns.Add("Column3", "Sütun 3");
        }

        private void button1_Click(object sender, EventArgs e)
        
            {
                int[,] matrix1 = new int[3, 3];
                int[,] matrix2 = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        matrix1[i, j] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                        matrix2[i, j] = int.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                    }
                }

                int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

                for (int i = 0; i < 3; i++)
                {
                    dataGridView3.Rows.Add(new object[] { resultMatrix[i, 0], resultMatrix[i, 1], resultMatrix[i, 2] });
                }
            }

            private int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
            {
                int[,] resultMatrix = new int[3, 3];

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < 3; k++)
                        {
                            sum += matrix1[i, k] * matrix2[k, j];
                        }
                        resultMatrix[i, j] = sum;
                    }
                }

                return resultMatrix;
            }

        private void projeHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Matrixlerde carpma işlemleri");
        }

        private void ögrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AD ve SOYAD: Ugur can DOĞAN Numara:220007027 ");
        }

        private void ögretmenHakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gökalp");
        }

        private void antalyaBelekÜnüvisitesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antalya Belek Ünüvisitesi 2023");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hoşgeldiniz Hocam Ve arkadaşlar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = null;
                }
            }
        }
    }
    }
    

