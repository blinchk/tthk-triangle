using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace tthk_triangle
{
    public partial class Form1 : Form
    {
        private bool byHeight;
        private bool byAngle;
        public Form1()
        {
            byHeight = false;
            byAngle = false;
            InitializeComponent();
        }

        private void AddVisualElements(Triangle triangle)
        {
            listView.Items.Add("Сторона а"); // добавляем соответсвующие ячейки в коллекцию items объекта listview1
            listView.Items.Add("Сторона b"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
            listView.Items.Add("Сторона c"); //
            listView.Items.Add("Высота"); //
            listView.Items.Add("Периметр"); //
            listView.Items.Add("Полупериметр"); //
            listView.Items.Add("Площадь"); //
            listView.Items.Add("Существует?"); //
            listView.Items.Add("Спецификатор"); //
            listView.Items[0].SubItems.Add(triangle.OutputA()); // методы по выводу сторон a, b ,c
            listView.Items[1].SubItems.Add(triangle.OutputB()); // (Item'у с индексом [i] присваиваем значение сабайтема, содержащегося во втором столбце
            listView.Items[2].SubItems.Add(triangle.OutputC()); //
            listView.Items[3].SubItems.Add(triangle.OutputH()); //
            listView.Items[4].SubItems.Add(Convert.ToString(triangle.Perimeter())); //выводим периметр
            listView.Items[5].SubItems.Add(Convert.ToString(triangle.HalfPerimeter())); //выводим полупериметр
            listView.Items[6].SubItems.Add(Convert.ToString(triangle.Surface())); // выводим значение площади
            if (triangle.ExistTriangle) { listView.Items[7].SubItems.Add("Существует"); } // свойство Triangle.exist
            else listView.Items[7].SubItems.Add("Не существует");
            listView.Items[8].SubItems.Add(triangle.TriangleType); // выводим вид треугольника
        }

        private void CheckValuesInTextboxes()
        {
            if (txtH.TextLength > 0)
            {
                txtC.Enabled = false;
                txtAngle.Enabled = false;
                checkBox1.Enabled = true;
            }
            else if (txtAngle.TextLength > 0)
            {
                txtC.Enabled = false;
                txtH.Enabled = false;
                checkBox1.Enabled = false;
            }
            else if (txtC.TextLength > 0)
            {
                txtH.Enabled = false;
                txtAngle.Enabled = false;
            }
            else
            {
                txtC.Enabled = true;
                txtH.Enabled = true;
                txtB.Enabled = true;
                txtAngle.Enabled = true;
                checkBox1.Enabled = false;
            }
        }

        private void launchButton_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count > 0)
            {
                listView.Items.Clear();
            }
            if (txtA.Text.Length > 0 && txtB.Text.Length > 0 && txtC.Text.Length > 0)
            {
                double a, b, c;
                a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
                b = Convert.ToDouble(txtB.Text); // считываем значение стороны b
                c = Convert.ToDouble(txtC.Text); // считываем значение стороны c
                Triangle triangle = new Triangle(a, b, c); // создаем объект класса Triangle с именем triangle
                AddVisualElements(triangle);
            }
            else if (txtA.Text.Length > 0 && txtH.Text.Length > 0)  
            {
                double a, h;
                a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
                h = Convert.ToDouble(txtH.Text);
                Triangle triangle = new Triangle(byHeight, a, h); // создаем объект класса Triangle с именем triangle
                AddVisualElements(triangle);
            }
            else if (txtA.TextLength > 0 && txtB.TextLength > 0 && txtAngle.TextLength > 0)
            {
                double a, b, angle;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                angle = Convert.ToDouble(txtAngle.Text);
                Triangle triangle = new Triangle(true, a, b, angle);
                AddVisualElements(triangle);
            }
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            CheckValuesInTextboxes();
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            CheckValuesInTextboxes();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            CheckValuesInTextboxes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CheckValuesInTextboxes();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            byHeight = checkBox1.Checked;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Form2 anotherDesign = new Form2();
            anotherDesign.Show();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            byAngle = true;
        }

        private void txtAngle_TextChanged(object sender, EventArgs e)
        {
            CheckValuesInTextboxes();
        }
    }
}
