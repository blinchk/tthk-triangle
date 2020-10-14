namespace tthk_triangle
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.launchButton = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.Location = new System.Drawing.Point(427, 8);
            this.launchButton.Margin = new System.Windows.Forms.Padding(2);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(191, 77);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtA.Location = new System.Drawing.Point(297, 178);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(116, 24);
            this.txtA.TabIndex = 3;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сторона A:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сторона B:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtB.Location = new System.Drawing.Point(297, 203);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(116, 24);
            this.txtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(209, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сторона C:";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtC.Location = new System.Drawing.Point(297, 227);
            this.txtC.Margin = new System.Windows.Forms.Padding(2);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(116, 24);
            this.txtC.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(8, 8);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView1";
            this.listView.Scrollable = false;
            this.listView.Size = new System.Drawing.Size(405, 168);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Поле";
            this.columnHeader1.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 419;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(230, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Высота:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtH
            // 
            this.txtH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtH.Location = new System.Drawing.Point(297, 252);
            this.txtH.Margin = new System.Windows.Forms.Padding(2);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(116, 24);
            this.txtH.TabIndex = 10;
            this.txtH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = global::tthk_triangle.Properties.Resources.triang_noun_001_18172;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(443, 140);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 158);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // colorBindingSource
            // 
            this.colorBindingSource.DataSource = typeof(System.Drawing.Color);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(427, 88);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 22);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Прямоугольный";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.Location = new System.Drawing.Point(568, 89);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(52, 18);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Form2";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(169, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Известный угол:";
            // 
            // txtAngle
            // 
            this.txtAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAngle.Location = new System.Drawing.Point(297, 276);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(116, 24);
            this.txtAngle.TabIndex = 15;
            this.txtAngle.TextChanged += new System.EventHandler(this.txtAngle_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 309);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.launchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Работа с треугольником";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource colorBindingSource;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAngle;
    }
}

