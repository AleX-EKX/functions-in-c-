namespace _15pr
{
    partial class Form10
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисункиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рис1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рис2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рис3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисункиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // рисункиToolStripMenuItem
            // 
            this.рисункиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рис1ToolStripMenuItem,
            this.рис2ToolStripMenuItem,
            this.рис3ToolStripMenuItem});
            this.рисункиToolStripMenuItem.Name = "рисункиToolStripMenuItem";
            this.рисункиToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисункиToolStripMenuItem.Text = "Рисунки";
            // 
            // рис1ToolStripMenuItem
            // 
            this.рис1ToolStripMenuItem.Name = "рис1ToolStripMenuItem";
            this.рис1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рис1ToolStripMenuItem.Text = "рис 1";
            this.рис1ToolStripMenuItem.Click += new System.EventHandler(this.рис1ToolStripMenuItem_Click);
            // 
            // рис2ToolStripMenuItem
            // 
            this.рис2ToolStripMenuItem.Name = "рис2ToolStripMenuItem";
            this.рис2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рис2ToolStripMenuItem.Text = "рис 2";
            // 
            // рис3ToolStripMenuItem
            // 
            this.рис3ToolStripMenuItem.Name = "рис3ToolStripMenuItem";
            this.рис3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рис3ToolStripMenuItem.Text = "рис 3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 497);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 536);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form10";
            this.Text = "Form10";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисункиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рис1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рис2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рис3ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}