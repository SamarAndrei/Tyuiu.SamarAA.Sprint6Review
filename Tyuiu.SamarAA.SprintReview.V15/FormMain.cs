using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SamarAA.SprintReview.V15.Lib;

namespace Tyuiu.SamarAA.SprintReview.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxM_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(textBoxN.Text);
                int M = Convert.ToInt32(textBoxM.Text);
                int n1 = Convert.ToInt32(textBoxn1.Text);
                int n2 = Convert.ToInt32(textBoxn2.Text);
                int K = Convert.ToInt32(textBoxK.Text);
                int L = Convert.ToInt32(textBoxL.Text);
                int C = Convert.ToInt32(textBoxC.Text);

                if ((n1 < n2) && (K < L) && (C <= M - 1) && (L <= N - 1))
                {
                    dataGridView1.RowCount = N;
                    dataGridView1.ColumnCount = M;

                    for (int r = 0; r < M; r++)
                    {
                        dataGridView1.Columns[r].Width = 25;
                    }
                    int[,] arr = new int[N, M];
                    arr = ds.GetRandomMatrix(ref arr, n1, n2);
                    int res = ds.GetRes(arr, C, K, L);
                    for (int r = 0; r < arr.GetLength(0); r++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            dataGridView1.Rows[r].Cells[j].Value = arr[r, j];
                        }
                    }
                    textBoxRes.Text = Convert.ToString(res);

                }
                else
                {
                    MessageBox.Show("Данные введены не корректно!\nn1<n2,K<L,C<=M-1,L<=N-1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
