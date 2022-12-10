
namespace pr
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
            this.магазинDataSet = new pr.магазинDataSet();
            this.товарыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарыTableAdapter = new pr.магазинDataSetTableAdapters.товарыTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеТовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПродавцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.товарыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюТовараToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.otdel = new System.Windows.Forms.TextBox();
            this.nametov = new System.Windows.Forms.TextBox();
            this.prodavec = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.магазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // магазинDataSet
            // 
            this.магазинDataSet.DataSetName = "магазинDataSet";
            this.магазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // товарыBindingSource
            // 
            this.товарыBindingSource.DataMember = "товары";
            this.товарыBindingSource.DataSource = this.магазинDataSet;
            // 
            // товарыTableAdapter
            // 
            this.товарыTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(285, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // cena
            // 
            this.cena.Location = new System.Drawing.Point(285, 99);
            this.cena.Name = "cena";
            this.cena.Size = new System.Drawing.Size(100, 20);
            this.cena.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 24);
            this.button3.TabIndex = 9;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодТовараDataGridViewTextBoxColumn,
            this.отделаDataGridViewTextBoxColumn,
            this.наименованиеТовараDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.кодПродавцаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.товарыBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 151);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // кодТовараDataGridViewTextBoxColumn
            // 
            this.кодТовараDataGridViewTextBoxColumn.DataPropertyName = "код товара";
            this.кодТовараDataGridViewTextBoxColumn.HeaderText = "код товара";
            this.кодТовараDataGridViewTextBoxColumn.Name = "кодТовараDataGridViewTextBoxColumn";
            this.кодТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отделаDataGridViewTextBoxColumn
            // 
            this.отделаDataGridViewTextBoxColumn.DataPropertyName = "№ отдела";
            this.отделаDataGridViewTextBoxColumn.HeaderText = "№ отдела";
            this.отделаDataGridViewTextBoxColumn.Name = "отделаDataGridViewTextBoxColumn";
            this.отделаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеТовараDataGridViewTextBoxColumn
            // 
            this.наименованиеТовараDataGridViewTextBoxColumn.DataPropertyName = "наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.HeaderText = "наименование товара";
            this.наименованиеТовараDataGridViewTextBoxColumn.Name = "наименованиеТовараDataGridViewTextBoxColumn";
            this.наименованиеТовараDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // кодПродавцаDataGridViewTextBoxColumn
            // 
            this.кодПродавцаDataGridViewTextBoxColumn.DataPropertyName = "код продавца";
            this.кодПродавцаDataGridViewTextBoxColumn.HeaderText = "код продавца";
            this.кодПродавцаDataGridViewTextBoxColumn.Name = "кодПродавцаDataGridViewTextBoxColumn";
            this.кодПродавцаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // товарыBindingSource1
            // 
            this.товарыBindingSource1.DataMember = "товары";
            this.товарыBindingSource1.DataSource = this.магазинDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поЦенеToolStripMenuItem,
            this.поНазваниюТовараToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.поискToolStripMenuItem.Text = "Сортировка";
            // 
            // поЦенеToolStripMenuItem
            // 
            this.поЦенеToolStripMenuItem.Name = "поЦенеToolStripMenuItem";
            this.поЦенеToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.поЦенеToolStripMenuItem.Text = "По цене";
            this.поЦенеToolStripMenuItem.Click += new System.EventHandler(this.поЦенеToolStripMenuItem_Click);
            // 
            // поНазваниюТовараToolStripMenuItem
            // 
            this.поНазваниюТовараToolStripMenuItem.Name = "поНазваниюТовараToolStripMenuItem";
            this.поНазваниюТовараToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.поНазваниюТовараToolStripMenuItem.Text = "По названию товара";
            this.поНазваниюТовараToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюТовараToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::pr.Properties.Resources.pngegg__3_;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(593, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 34);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 92);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Экспорт";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(716, 287);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "VC#";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(716, 319);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Mysql";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // otdel
            // 
            this.otdel.Location = new System.Drawing.Point(285, 47);
            this.otdel.Name = "otdel";
            this.otdel.Size = new System.Drawing.Size(100, 20);
            this.otdel.TabIndex = 18;
            // 
            // nametov
            // 
            this.nametov.Location = new System.Drawing.Point(285, 73);
            this.nametov.Name = "nametov";
            this.nametov.Size = new System.Drawing.Size(100, 20);
            this.nametov.TabIndex = 19;
            // 
            // prodavec
            // 
            this.prodavec.Location = new System.Drawing.Point(285, 125);
            this.prodavec.Name = "prodavec";
            this.prodavec.Size = new System.Drawing.Size(100, 20);
            this.prodavec.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.prodavec);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nametov);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.otdel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.cena);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 167);
            this.panel1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Дата работы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(73, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Запись:";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(3, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 56);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Рейтинг качества";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ИНН";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Тип поставщика";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(173, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Поставщик";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(449, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 126);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Controls.Add(this.delete_btn);
            this.panel3.Controls.Add(this.update_btn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(12, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 62);
            this.panel3.TabIndex = 24;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(643, 34);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(89, 20);
            this.textBox_search.TabIndex = 7;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete_btn.BackgroundImage")));
            this.delete_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.delete_btn.Location = new System.Drawing.Point(493, 20);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(44, 34);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.Transparent;
            this.update_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("update_btn.BackgroundImage")));
            this.update_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update_btn.Location = new System.Drawing.Point(543, 20);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(44, 34);
            this.update_btn.TabIndex = 2;
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "это через АКСЕС";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(462, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Управление записями";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(605, 252);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(605, 277);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 20);
            this.textBox3.TabIndex = 27;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(602, 303);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.магазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарыBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private магазинDataSet магазинDataSet;
        private System.Windows.Forms.BindingSource товарыBindingSource;
        private магазинDataSetTableAdapters.товарыTableAdapter товарыTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox cena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource товарыBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отделаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеТовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПродавцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поЦенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюТовараToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox otdel;
        private System.Windows.Forms.TextBox nametov;
        private System.Windows.Forms.TextBox prodavec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
    }
}

