using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace tthk_triangle
{
    public class Form3 : Form
    {
        private Button launchButton;
        private PictureBox pictureBox1;
        private BindingSource colorBindingSource;
        private TextBox txtA, txtB, txtC, txtH, txtAngle;
        private Label label1, label2, label3, label4, label5;
        private ListView listView;
        private ColumnHeader columnHeader1, columnHeader2;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Container components;
        private bool byHeight, byAngle;

        public Form3()
        {
            byHeight = false;
            byAngle = false;
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form1));

            Icon = resources.GetObject("$this.Icon") as Icon;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Работа с треугольником";

            launchButton = new Button();
            txtA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtB = new TextBox();
            label3 = new Label();
            txtC = new TextBox();
            listView = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label4 = new Label();
            txtH = new TextBox();
            pictureBox1 = new PictureBox();
            colorBindingSource = new BindingSource(components);
            checkBox1 = new CheckBox();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            txtAngle = new TextBox();
            ((ISupportInitialize)pictureBox1).BeginInit();
            ((ISupportInitialize)colorBindingSource).BeginInit();
            launchButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            launchButton.Location = new Point(427, 8);
            launchButton.Margin = new Padding(2);
            launchButton.Name = "launchButton";
            launchButton.Size = new Size(191, 77);
            launchButton.TabIndex = 0;
            launchButton.Text = "Launch";
            launchButton.UseVisualStyleBackColor = true;
            launchButton.Click += new EventHandler(this.launchButton_Click);

            txtA.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtA.Location = new Point(297, 178);
            txtA.Margin = new Padding(2);
            txtA.Name = "txtA";
            txtA.Size = new Size(116, 24);
            txtA.TabIndex = 3;
            txtA.TextChanged += new EventHandler(this.txtA_TextChanged); 

            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(209, 180);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 4;
            label1.Text = "Сторона A:";
            label1.Click += new EventHandler(this.label1_Click);

            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(209, 205);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 6;
            label2.Text = "Сторона B:";
            label2.Click += new EventHandler(this.label2_Click);

            txtB.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtB.Location = new Point(297, 203);
            txtB.Margin = new Padding(2);
            txtB.Name = "txtB";
            txtB.Size = new Size(116, 24);
            txtB.TabIndex = 5;

            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(209, 229);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 18);
            label3.TabIndex = 8;
            label3.Text = "Сторона C:";

            txtC.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            txtC.Location = new Point(297, 227);
            txtC.Margin = new Padding(2);
            txtC.Name = "txtC";
            txtC.Size = new Size(116, 24);
            txtC.TabIndex = 7;

            listView.Alignment = ListViewAlignment.Left;
            listView.Columns.AddRange(new ColumnHeader[] {
            columnHeader1,
            columnHeader2});

            listView.HideSelection = false;
            listView.Location = new Point(8, 8);
            listView.Margin = new Padding(2);
            listView.Name = "listView";
            listView.Scrollable = false;
            listView.Size = new Size(405, 168);
            listView.TabIndex = 9;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;

            columnHeader1.Text = "Поле";
            columnHeader1.Width = 175;
            columnHeader2.Text = "Значение";
            columnHeader2.Width = 419;

            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new Point(230, 252);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 11;
            label4.Text = "Высота:";
            label4.Click += new EventHandler(this.label4_Click);

            txtH.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            txtH.Location = new Point(297, 252);
            txtH.Margin = new Padding(2);
            txtH.Name = "txtH";
            txtH.Size = new Size(116, 24);
            txtH.TabIndex = 10;
            txtH.TextChanged += new EventHandler(this.textBox1_TextChanged);

            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.BackgroundImage = Properties.Resources.triang_noun_001_18172;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(442, 142);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 156);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;

            colorBindingSource.DataSource = typeof(Color);

            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.Location = new Point(427, 88);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 22);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Прямоугольный";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);

            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            linkLabel1.Location = new Point(568, 89);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 18);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Form2";
            linkLabel1.Click += new EventHandler(this.linkLabel1_Click);

            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(169, 276);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 18);
            label5.TabIndex = 16;
            label5.Text = "Известный угол:";

            txtAngle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtAngle.Location = new Point(297, 276);
            txtAngle.Margin = new Padding(2);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new Size(116, 24);
            txtAngle.TabIndex = 15;
            txtAngle.TextChanged += new EventHandler(txtAngle_TextChanged);

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 309);

            Controls.Add(label5);
            Controls.Add(txtAngle);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(txtH);
            Controls.Add(listView);
            Controls.Add(label3);
            Controls.Add(txtC);
            Controls.Add(label2);
            Controls.Add(txtB);
            Controls.Add(label1);
            Controls.Add(txtA);
            Controls.Add(pictureBox1);
            Controls.Add(launchButton);

            ((ISupportInitialize)pictureBox1).EndInit();
            ((ISupportInitialize)colorBindingSource).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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