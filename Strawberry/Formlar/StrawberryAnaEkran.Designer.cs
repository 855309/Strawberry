
namespace Strawberry
{
    partial class StrawberryAnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrawberryAnaEkran));
            this.clientdatagrid = new System.Windows.Forms.DataGridView();
            this.ipportcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kuladicolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isletimcolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sagtikmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.güçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bağlantıyıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenidenBaşlatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelMesajGönderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaüstüGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kameraGörüntülemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mikrofondanSesAlmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaYöneticisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hepsininBağlantısınıKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinlemeyeBaşlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durdurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinlemeAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strawberryRATHakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımSayfasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.durumlabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).BeginInit();
            this.sagtikmenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientdatagrid
            // 
            this.clientdatagrid.AllowUserToAddRows = false;
            this.clientdatagrid.AllowUserToDeleteRows = false;
            this.clientdatagrid.BackgroundColor = System.Drawing.Color.White;
            this.clientdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ipportcolumn,
            this.kuladicolumn,
            this.pingcolumn,
            this.isletimcolumn});
            this.clientdatagrid.ContextMenuStrip = this.sagtikmenu;
            this.clientdatagrid.Location = new System.Drawing.Point(12, 33);
            this.clientdatagrid.MultiSelect = false;
            this.clientdatagrid.Name = "clientdatagrid";
            this.clientdatagrid.ReadOnly = true;
            this.clientdatagrid.Size = new System.Drawing.Size(805, 523);
            this.clientdatagrid.TabIndex = 0;
            // 
            // ipportcolumn
            // 
            this.ipportcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ipportcolumn.HeaderText = "IP:Port";
            this.ipportcolumn.Name = "ipportcolumn";
            this.ipportcolumn.ReadOnly = true;
            // 
            // kuladicolumn
            // 
            this.kuladicolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kuladicolumn.HeaderText = "Kullanıcı Adı";
            this.kuladicolumn.Name = "kuladicolumn";
            this.kuladicolumn.ReadOnly = true;
            // 
            // pingcolumn
            // 
            this.pingcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pingcolumn.HeaderText = "Ping";
            this.pingcolumn.Name = "pingcolumn";
            this.pingcolumn.ReadOnly = true;
            // 
            // isletimcolumn
            // 
            this.isletimcolumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isletimcolumn.HeaderText = "İşletim Sistemi";
            this.isletimcolumn.Name = "isletimcolumn";
            this.isletimcolumn.ReadOnly = true;
            // 
            // sagtikmenu
            // 
            this.sagtikmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yönetimToolStripMenuItem,
            this.güçToolStripMenuItem,
            this.moderasyonToolStripMenuItem,
            this.görüntülemeToolStripMenuItem});
            this.sagtikmenu.Name = "sagtikmenu";
            this.sagtikmenu.Size = new System.Drawing.Size(145, 92);
            this.sagtikmenu.Opening += new System.ComponentModel.CancelEventHandler(this.sagtikmenu_Opening);
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programBaşlatToolStripMenuItem,
            this.bağlantıyıKesToolStripMenuItem1});
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.yönetimToolStripMenuItem.Text = "Yönetim";
            // 
            // programBaşlatToolStripMenuItem
            // 
            this.programBaşlatToolStripMenuItem.Name = "programBaşlatToolStripMenuItem";
            this.programBaşlatToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.programBaşlatToolStripMenuItem.Text = "Program Başlat";
            this.programBaşlatToolStripMenuItem.Click += new System.EventHandler(this.programBaşlatToolStripMenuItem_Click);
            // 
            // bağlantıyıKesToolStripMenuItem1
            // 
            this.bağlantıyıKesToolStripMenuItem1.Name = "bağlantıyıKesToolStripMenuItem1";
            this.bağlantıyıKesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.bağlantıyıKesToolStripMenuItem1.Text = "Bağlantıyı Kes";
            this.bağlantıyıKesToolStripMenuItem1.Click += new System.EventHandler(this.bağlantıyıKesToolStripMenuItem1_Click);
            // 
            // güçToolStripMenuItem
            // 
            this.güçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bağlantıyıKesToolStripMenuItem,
            this.kapatToolStripMenuItem,
            this.yenidenBaşlatToolStripMenuItem});
            this.güçToolStripMenuItem.Name = "güçToolStripMenuItem";
            this.güçToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.güçToolStripMenuItem.Text = "Güç";
            // 
            // bağlantıyıKesToolStripMenuItem
            // 
            this.bağlantıyıKesToolStripMenuItem.Name = "bağlantıyıKesToolStripMenuItem";
            this.bağlantıyıKesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bağlantıyıKesToolStripMenuItem.Text = "Bağlantıyı Kes";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // yenidenBaşlatToolStripMenuItem
            // 
            this.yenidenBaşlatToolStripMenuItem.Name = "yenidenBaşlatToolStripMenuItem";
            this.yenidenBaşlatToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yenidenBaşlatToolStripMenuItem.Text = "Yeniden Başlat";
            // 
            // moderasyonToolStripMenuItem
            // 
            this.moderasyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelMesajGönderToolStripMenuItem,
            this.sistemBilgisiToolStripMenuItem});
            this.moderasyonToolStripMenuItem.Name = "moderasyonToolStripMenuItem";
            this.moderasyonToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.moderasyonToolStripMenuItem.Text = "Moderasyon";
            // 
            // manuelMesajGönderToolStripMenuItem
            // 
            this.manuelMesajGönderToolStripMenuItem.Name = "manuelMesajGönderToolStripMenuItem";
            this.manuelMesajGönderToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.manuelMesajGönderToolStripMenuItem.Text = "Manuel Mesaj Gönder";
            this.manuelMesajGönderToolStripMenuItem.Click += new System.EventHandler(this.manuelMesajGönderToolStripMenuItem_Click);
            // 
            // sistemBilgisiToolStripMenuItem
            // 
            this.sistemBilgisiToolStripMenuItem.Name = "sistemBilgisiToolStripMenuItem";
            this.sistemBilgisiToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sistemBilgisiToolStripMenuItem.Text = "Sistem Bilgisi";
            this.sistemBilgisiToolStripMenuItem.Click += new System.EventHandler(this.sistemBilgisiToolStripMenuItem_Click);
            // 
            // görüntülemeToolStripMenuItem
            // 
            this.görüntülemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaüstüGörüntülemeToolStripMenuItem,
            this.kameraGörüntülemeToolStripMenuItem,
            this.mikrofondanSesAlmaToolStripMenuItem,
            this.dosyaYöneticisiToolStripMenuItem});
            this.görüntülemeToolStripMenuItem.Name = "görüntülemeToolStripMenuItem";
            this.görüntülemeToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.görüntülemeToolStripMenuItem.Text = "Görüntüleme";
            // 
            // masaüstüGörüntülemeToolStripMenuItem
            // 
            this.masaüstüGörüntülemeToolStripMenuItem.Name = "masaüstüGörüntülemeToolStripMenuItem";
            this.masaüstüGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.masaüstüGörüntülemeToolStripMenuItem.Text = "Masaüstü Görüntüleme";
            this.masaüstüGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.masaüstüGörüntülemeToolStripMenuItem_Click);
            // 
            // kameraGörüntülemeToolStripMenuItem
            // 
            this.kameraGörüntülemeToolStripMenuItem.Name = "kameraGörüntülemeToolStripMenuItem";
            this.kameraGörüntülemeToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.kameraGörüntülemeToolStripMenuItem.Text = "Kamera Görüntüleme";
            this.kameraGörüntülemeToolStripMenuItem.Click += new System.EventHandler(this.kameraGörüntülemeToolStripMenuItem_Click);
            // 
            // mikrofondanSesAlmaToolStripMenuItem
            // 
            this.mikrofondanSesAlmaToolStripMenuItem.Name = "mikrofondanSesAlmaToolStripMenuItem";
            this.mikrofondanSesAlmaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.mikrofondanSesAlmaToolStripMenuItem.Text = "Mikrofondan Ses Alma";
            // 
            // dosyaYöneticisiToolStripMenuItem
            // 
            this.dosyaYöneticisiToolStripMenuItem.Name = "dosyaYöneticisiToolStripMenuItem";
            this.dosyaYöneticisiToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dosyaYöneticisiToolStripMenuItem.Text = "Dosya Yöneticisi";
            this.dosyaYöneticisiToolStripMenuItem.Visible = false;
            this.dosyaYöneticisiToolStripMenuItem.Click += new System.EventHandler(this.dosyaYöneticisiToolStripMenuItem_Click);
            // 
            // logbox
            // 
            this.logbox.BackColor = System.Drawing.Color.White;
            this.logbox.Location = new System.Drawing.Point(823, 53);
            this.logbox.Multiline = true;
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.Size = new System.Drawing.Size(290, 503);
            this.logbox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientlarToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientlarToolStripMenuItem
            // 
            this.clientlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hepsininBağlantısınıKesToolStripMenuItem});
            this.clientlarToolStripMenuItem.Name = "clientlarToolStripMenuItem";
            this.clientlarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.clientlarToolStripMenuItem.Text = "Clientlar";
            // 
            // hepsininBağlantısınıKesToolStripMenuItem
            // 
            this.hepsininBağlantısınıKesToolStripMenuItem.Name = "hepsininBağlantısınıKesToolStripMenuItem";
            this.hepsininBağlantısınıKesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.hepsininBağlantısınıKesToolStripMenuItem.Text = "Hepsinin Bağlantısını Kes";
            this.hepsininBağlantısınıKesToolStripMenuItem.Click += new System.EventHandler(this.hepsininBağlantısınıKesToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dinlemeyeBaşlaToolStripMenuItem,
            this.durdurToolStripMenuItem,
            this.dinlemeAyarlarıToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // dinlemeyeBaşlaToolStripMenuItem
            // 
            this.dinlemeyeBaşlaToolStripMenuItem.Name = "dinlemeyeBaşlaToolStripMenuItem";
            this.dinlemeyeBaşlaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dinlemeyeBaşlaToolStripMenuItem.Text = "Dinlemeye Başla";
            this.dinlemeyeBaşlaToolStripMenuItem.Click += new System.EventHandler(this.dinlemeyeBaşlaToolStripMenuItem_Click);
            // 
            // durdurToolStripMenuItem
            // 
            this.durdurToolStripMenuItem.Name = "durdurToolStripMenuItem";
            this.durdurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durdurToolStripMenuItem.Text = "Durdur";
            this.durdurToolStripMenuItem.Click += new System.EventHandler(this.durdurToolStripMenuItem_Click);
            // 
            // dinlemeAyarlarıToolStripMenuItem
            // 
            this.dinlemeAyarlarıToolStripMenuItem.Name = "dinlemeAyarlarıToolStripMenuItem";
            this.dinlemeAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dinlemeAyarlarıToolStripMenuItem.Text = "Dinleme Ayarları";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strawberryRATHakkındaToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // strawberryRATHakkındaToolStripMenuItem
            // 
            this.strawberryRATHakkındaToolStripMenuItem.Name = "strawberryRATHakkındaToolStripMenuItem";
            this.strawberryRATHakkındaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.strawberryRATHakkındaToolStripMenuItem.Text = "StrawberryRAT Hakkında";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımSayfasıToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // yardımSayfasıToolStripMenuItem
            // 
            this.yardımSayfasıToolStripMenuItem.Name = "yardımSayfasıToolStripMenuItem";
            this.yardımSayfasıToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.yardımSayfasıToolStripMenuItem.Text = "Yardım Sayfası";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(823, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "=== Loglar ===";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.durumlabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1116, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // durumlabel
            // 
            this.durumlabel.ForeColor = System.Drawing.Color.Red;
            this.durumlabel.Name = "durumlabel";
            this.durumlabel.Size = new System.Drawing.Size(75, 17);
            this.durumlabel.Text = "Dinlenmiyor.";
            // 
            // StrawberryAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 585);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logbox);
            this.Controls.Add(this.clientdatagrid);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StrawberryAnaEkran";
            this.Text = "Strawberry Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).EndInit();
            this.sagtikmenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipportcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kuladicolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isletimcolumn;
        private System.Windows.Forms.TextBox logbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hepsininBağlantısınıKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinlemeyeBaşlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durdurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strawberryRATHakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımSayfasıToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel durumlabel;
        private System.Windows.Forms.ToolStripMenuItem dinlemeAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip sagtikmenu;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yenidenBaşlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manuelMesajGönderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaüstüGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kameraGörüntülemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mikrofondanSesAlmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programBaşlatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bağlantıyıKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaYöneticisiToolStripMenuItem;
    }
}

