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
        public Form1()
        {
            InitializeComponent();
        }
            
        private void launchButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
            double a, b, c;
            a = Convert.ToDouble(txtA.Text); // считываем значение стороны а
            b = Convert.ToDouble(txtB.Text); // считываем значение стороны b
            c = Convert.ToDouble(txtC.Text); // считываем значение стороны c
            Triangle triangle = new Triangle(a, b, c); // создаем объект класса Triangle с именем triangle
            listView1.Items.Add("Сторона а"); // добавляем соответсвующие ячейки в коллекцию items объекта listview1
            listView1.Items.Add("Сторона b"); // (при клике на кнопку Запуск первый столбец заполнится этими нашими именами)
            listView1.Items.Add("Сторона c"); //
            listView1.Items.Add("Периметр"); //
            listView1.Items.Add("Полупериметр"); //
            listView1.Items.Add("Площадь"); //
            listView1.Items.Add("Существует?"); //
            listView1.Items.Add("Спецификатор"); //
            listView1.Items[0].SubItems.Add(triangle.OutputA()); // методы по выводу сторон a, b ,c
            listView1.Items[1].SubItems.Add(triangle.OutputB()); // (Item'у с индексом [i] присваиваем значение сабайтема, содержащегося во втором столбце
            listView1.Items[2].SubItems.Add(triangle.OutputC()); //
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter())); //выводим периметр
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.HalfPerimeter())); //выводим полупериметр
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Surface())); // выводим значение площади
            if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Существует"); } // свойство Triangle.exist
            else listView1.Items[6].SubItems.Add("Не существует");
            listView1.Items[7].SubItems.Add(triangle.TriangleType); // выводим вид треугольника
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
