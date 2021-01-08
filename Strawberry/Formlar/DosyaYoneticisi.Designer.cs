
namespace Strawberry.Formlar
{
    partial class DosyaYoneticisi
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dosyayoneticisidatagrid = new System.Windows.Forms.DataGridView();
            this.dosyaadicolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyagirdisicolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosyayolucolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dosyayoneticisidatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(654, 409);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dosya Yükle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Yenile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dosyayoneticisidatagrid
            // 
            this.dosyayoneticisidatagrid.AllowUserToAddRows = false;
            this.dosyayoneticisidatagrid.AllowUserToDeleteRows = false;
            this.dosyayoneticisidatagrid.BackgroundColor = System.Drawing.Color.White;
            this.dosyayoneticisidatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dosyayoneticisidatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dosyaadicolumn,
            this.dosyagirdisicolumn,
            this.dosyayolucolumn});
            this.dosyayoneticisidatagrid.Location = new System.Drawing.Point(12, 12);
            this.dosyayoneticisidatagrid.MultiSelect = false;
            this.dosyayoneticisidatagrid.Name = "dosyayoneticisidatagrid";
            this.dosyayoneticisidatagrid.ReadOnly = true;
            this.dosyayoneticisidatagrid.Size = new System.Drawing.Size(776, 391);
            this.dosyayoneticisidatagrid.TabIndex = 4;
            this.dosyayoneticisidatagrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dosyayoneticisidatagrid_CellMouseDoubleClick);
            // 
            // dosyaadicolumn
            // 
            this.dosyaadicolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dosyaadicolumn.HeaderText = "Dosya Adı";
            this.dosyaadicolumn.Name = "dosyaadicolumn";
            this.dosyaadicolumn.ReadOnly = true;
            // 
            // dosyagirdisicolumn
            // 
            this.dosyagirdisicolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dosyagirdisicolumn.HeaderText = "Dosya Girdisi";
            this.dosyagirdisicolumn.Name = "dosyagirdisicolumn";
            this.dosyagirdisicolumn.ReadOnly = true;
            // 
            // dosyayolucolumn
            // 
            this.dosyayolucolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dosyayolucolumn.HeaderText = "Dosya Yolu";
            this.dosyayolucolumn.Name = "dosyayolucolumn";
            this.dosyayolucolumn.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 435);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 28);
            this.button4.TabIndex = 5;
            this.button4.Text = "Yeniden Adlandır";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 409);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Yeni Dosya Adı";
            // 
            // DosyaYoneticisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dosyayoneticisidatagrid);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DosyaYoneticisi";
            this.Text = "Dosya Yöneticisi";
            this.Load += new System.EventHandler(this.DosyaYoneticisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dosyayoneticisidatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dosyayoneticisidatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyaadicolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyagirdisicolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosyayolucolumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
    }
}