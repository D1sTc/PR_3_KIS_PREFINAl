using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Exit_Click(sender, e);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            GeometricMeanMatrixExit.Clear();
            errorProvider1.Clear();
            ValueMatrix.Controls.Clear();
            textBoxColumns.Clear();
            textBoxLines.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GeometricMeanMatrixButton_Click(object sender, EventArgs e)
        {

        }

        private double CalculateGeometricMean<T>(T[,] matrix) where T : IConvertible // вычисление среднего геометрического значения
        {
            double product = 1.0; // Инициализация произведения положительных значений | 1.0 как нач. значение
            int count = 0; // Инициализация количества положительных значений

            for (int i = 0; i < matrix.GetLength(0); i++) // Перебор всех элементов матрицы 2x2 || строки
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Перебор всех элементов матрицы 2x2 || столбцы
                {
                    double value = Convert.ToDouble(matrix[i, j], null); // преобразование элемента матрицы в double | null - x
                    if (value > 0)
                    {
                        product *= value; // умножение на + значение
                        count++; // увеличение кол-ва + значений
                    }
                    else MessageBox.Show("Ошибка. Были введены отрицательные значения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning); // ошибка на случай отрицательных значений
                }
            }
            return count > 0 ? Math.Pow(product, 1.0 / count) : 0; // проверка кол-ва и деление на него при > 0
        }

        private void ApplicationGeometricMean_Click(object sender, EventArgs e)
        {
            GeometricMeanMatrixButton_Click(sender, e);
        }

        private void CreateMatrix_Click(object sender, EventArgs e)
        {
            ValueMatrix.Controls.Clear(); // при нажатиии все поля очищаются в GroupBox
            int columns = Convert.ToInt32(textBoxColumns.Text);
            int lines = Convert.ToInt32(textBoxLines.Text);

            int count = 0;

            for (int l = 0; l < lines; l++) // цикл для строк
            {
                for (int c = 0; c < columns; c++) // цикл для колонок
                {
                    count++;
                    System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox(); // экземпляр
                    textBox.Name = $"textBox{count}";
                    textBox.Location = new System.Drawing.Point(6 + c * 55, 19 + l * 25);
                    textBox.Size = new System.Drawing.Size(30, 30);
                    textBox.TabIndex = count;
                    ValueMatrix.Controls.Add(textBox);
                }
            }
        }
    }
}