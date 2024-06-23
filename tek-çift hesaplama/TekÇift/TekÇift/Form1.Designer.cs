
namespace TekÇift
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TekSayılar = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listtekçarpım = new System.Windows.Forms.ListView();
            this.TekÇarpım = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listtektoplam = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listtek = new System.Windows.Forms.ListView();
            this.ÇiftSayılar = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listçiftçarpım = new System.Windows.Forms.ListView();
            this.listçifttoplam = new System.Windows.Forms.ListView();
            this.listçift = new System.Windows.Forms.ListView();
            this.AsalSayılar = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listasalçarpım = new System.Windows.Forms.ListView();
            this.listasaltoplam = new System.Windows.Forms.ListView();
            this.listasal = new System.Windows.Forms.ListView();
            this.MükemmelSayılar = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listmukçarpım = new System.Windows.Forms.ListView();
            this.listmuktoplam = new System.Windows.Forms.ListView();
            this.listmuk = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btnçalıştır = new System.Windows.Forms.Button();
            this.boxbitiş = new System.Windows.Forms.MaskedTextBox();
            this.boxbaşlangıç = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.TekSayılar.SuspendLayout();
            this.ÇiftSayılar.SuspendLayout();
            this.AsalSayılar.SuspendLayout();
            this.MükemmelSayılar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.TekSayılar);
            this.tabControl1.Controls.Add(this.ÇiftSayılar);
            this.tabControl1.Controls.Add(this.AsalSayılar);
            this.tabControl1.Controls.Add(this.MükemmelSayılar);
            this.tabControl1.Location = new System.Drawing.Point(12, 128);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 277);
            this.tabControl1.TabIndex = 0;
            // 
            // TekSayılar
            // 
            this.TekSayılar.BackColor = System.Drawing.Color.Aquamarine;
            this.TekSayılar.Controls.Add(this.label5);
            this.TekSayılar.Controls.Add(this.label4);
            this.TekSayılar.Controls.Add(this.label3);
            this.TekSayılar.Controls.Add(this.listtekçarpım);
            this.TekSayılar.Controls.Add(this.listtektoplam);
            this.TekSayılar.Controls.Add(this.listtek);
            this.TekSayılar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TekSayılar.Location = new System.Drawing.Point(4, 22);
            this.TekSayılar.Name = "TekSayılar";
            this.TekSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.TekSayılar.Size = new System.Drawing.Size(783, 251);
            this.TekSayılar.TabIndex = 0;
            this.TekSayılar.Text = "Tek Sayılar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "ÇARPIM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TOPLAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "TEK SAYILAR";
            // 
            // listtekçarpım
            // 
            this.listtekçarpım.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TekÇarpım});
            this.listtekçarpım.HideSelection = false;
            this.listtekçarpım.Location = new System.Drawing.Point(543, 141);
            this.listtekçarpım.Name = "listtekçarpım";
            this.listtekçarpım.Size = new System.Drawing.Size(234, 100);
            this.listtekçarpım.TabIndex = 2;
            this.listtekçarpım.UseCompatibleStateImageBehavior = false;
            this.listtekçarpım.View = System.Windows.Forms.View.List;
            // 
            // TekÇarpım
            // 
            this.TekÇarpım.Width = 200;
            // 
            // listtektoplam
            // 
            this.listtektoplam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listtektoplam.HideSelection = false;
            this.listtektoplam.Location = new System.Drawing.Point(543, 21);
            this.listtektoplam.Name = "listtektoplam";
            this.listtektoplam.Size = new System.Drawing.Size(234, 95);
            this.listtektoplam.TabIndex = 1;
            this.listtektoplam.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            // 
            // listtek
            // 
            this.listtek.AccessibleDescription = "";
            this.listtek.AccessibleName = "";
            this.listtek.HideSelection = false;
            this.listtek.Location = new System.Drawing.Point(6, 21);
            this.listtek.Name = "listtek";
            this.listtek.Size = new System.Drawing.Size(531, 220);
            this.listtek.TabIndex = 0;
            this.listtek.UseCompatibleStateImageBehavior = false;
            // 
            // ÇiftSayılar
            // 
            this.ÇiftSayılar.BackColor = System.Drawing.Color.Aquamarine;
            this.ÇiftSayılar.Controls.Add(this.label8);
            this.ÇiftSayılar.Controls.Add(this.label7);
            this.ÇiftSayılar.Controls.Add(this.label6);
            this.ÇiftSayılar.Controls.Add(this.listçiftçarpım);
            this.ÇiftSayılar.Controls.Add(this.listçifttoplam);
            this.ÇiftSayılar.Controls.Add(this.listçift);
            this.ÇiftSayılar.Location = new System.Drawing.Point(4, 22);
            this.ÇiftSayılar.Name = "ÇiftSayılar";
            this.ÇiftSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.ÇiftSayılar.Size = new System.Drawing.Size(783, 251);
            this.ÇiftSayılar.TabIndex = 1;
            this.ÇiftSayılar.Text = "Çift Sayılar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "ÇARPIM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(622, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "TOPLAM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "ÇİFT SAYILAR";
            // 
            // listçiftçarpım
            // 
            this.listçiftçarpım.HideSelection = false;
            this.listçiftçarpım.Location = new System.Drawing.Point(544, 142);
            this.listçiftçarpım.Name = "listçiftçarpım";
            this.listçiftçarpım.Size = new System.Drawing.Size(233, 103);
            this.listçiftçarpım.TabIndex = 2;
            this.listçiftçarpım.UseCompatibleStateImageBehavior = false;
            this.listçiftçarpım.View = System.Windows.Forms.View.List;
            // 
            // listçifttoplam
            // 
            this.listçifttoplam.HideSelection = false;
            this.listçifttoplam.Location = new System.Drawing.Point(544, 20);
            this.listçifttoplam.Name = "listçifttoplam";
            this.listçifttoplam.Size = new System.Drawing.Size(233, 103);
            this.listçifttoplam.TabIndex = 1;
            this.listçifttoplam.UseCompatibleStateImageBehavior = false;
            // 
            // listçift
            // 
            this.listçift.HideSelection = false;
            this.listçift.Location = new System.Drawing.Point(6, 21);
            this.listçift.Name = "listçift";
            this.listçift.Size = new System.Drawing.Size(532, 224);
            this.listçift.TabIndex = 0;
            this.listçift.UseCompatibleStateImageBehavior = false;
            // 
            // AsalSayılar
            // 
            this.AsalSayılar.BackColor = System.Drawing.Color.Aquamarine;
            this.AsalSayılar.Controls.Add(this.label11);
            this.AsalSayılar.Controls.Add(this.label10);
            this.AsalSayılar.Controls.Add(this.label9);
            this.AsalSayılar.Controls.Add(this.listasalçarpım);
            this.AsalSayılar.Controls.Add(this.listasaltoplam);
            this.AsalSayılar.Controls.Add(this.listasal);
            this.AsalSayılar.Location = new System.Drawing.Point(4, 22);
            this.AsalSayılar.Name = "AsalSayılar";
            this.AsalSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.AsalSayılar.Size = new System.Drawing.Size(783, 251);
            this.AsalSayılar.TabIndex = 2;
            this.AsalSayılar.Text = "Asal Sayılar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(626, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "ÇARPIM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(623, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "TOPLAM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "ASAL SAYILAR";
            // 
            // listasalçarpım
            // 
            this.listasalçarpım.HideSelection = false;
            this.listasalçarpım.Location = new System.Drawing.Point(544, 142);
            this.listasalçarpım.Name = "listasalçarpım";
            this.listasalçarpım.Size = new System.Drawing.Size(232, 99);
            this.listasalçarpım.TabIndex = 2;
            this.listasalçarpım.UseCompatibleStateImageBehavior = false;
            this.listasalçarpım.View = System.Windows.Forms.View.List;
            // 
            // listasaltoplam
            // 
            this.listasaltoplam.HideSelection = false;
            this.listasaltoplam.Location = new System.Drawing.Point(545, 21);
            this.listasaltoplam.Name = "listasaltoplam";
            this.listasaltoplam.Size = new System.Drawing.Size(232, 102);
            this.listasaltoplam.TabIndex = 1;
            this.listasaltoplam.UseCompatibleStateImageBehavior = false;
            // 
            // listasal
            // 
            this.listasal.HideSelection = false;
            this.listasal.Location = new System.Drawing.Point(7, 21);
            this.listasal.Name = "listasal";
            this.listasal.Size = new System.Drawing.Size(531, 220);
            this.listasal.TabIndex = 0;
            this.listasal.UseCompatibleStateImageBehavior = false;
            // 
            // MükemmelSayılar
            // 
            this.MükemmelSayılar.BackColor = System.Drawing.Color.Aquamarine;
            this.MükemmelSayılar.Controls.Add(this.label14);
            this.MükemmelSayılar.Controls.Add(this.label13);
            this.MükemmelSayılar.Controls.Add(this.label12);
            this.MükemmelSayılar.Controls.Add(this.listmukçarpım);
            this.MükemmelSayılar.Controls.Add(this.listmuktoplam);
            this.MükemmelSayılar.Controls.Add(this.listmuk);
            this.MükemmelSayılar.Location = new System.Drawing.Point(4, 22);
            this.MükemmelSayılar.Name = "MükemmelSayılar";
            this.MükemmelSayılar.Padding = new System.Windows.Forms.Padding(3);
            this.MükemmelSayılar.Size = new System.Drawing.Size(783, 251);
            this.MükemmelSayılar.TabIndex = 3;
            this.MükemmelSayılar.Text = "Mükemmel Sayılar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(629, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "ÇARPIM";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(626, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "TOPLAM";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(66, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "MÜKEMMEL SAYILAR";
            // 
            // listmukçarpım
            // 
            this.listmukçarpım.HideSelection = false;
            this.listmukçarpım.Location = new System.Drawing.Point(545, 141);
            this.listmukçarpım.Name = "listmukçarpım";
            this.listmukçarpım.Size = new System.Drawing.Size(232, 100);
            this.listmukçarpım.TabIndex = 2;
            this.listmukçarpım.UseCompatibleStateImageBehavior = false;
            this.listmukçarpım.View = System.Windows.Forms.View.List;
            // 
            // listmuktoplam
            // 
            this.listmuktoplam.HideSelection = false;
            this.listmuktoplam.Location = new System.Drawing.Point(545, 20);
            this.listmuktoplam.Name = "listmuktoplam";
            this.listmuktoplam.Size = new System.Drawing.Size(232, 101);
            this.listmuktoplam.TabIndex = 1;
            this.listmuktoplam.UseCompatibleStateImageBehavior = false;
            // 
            // listmuk
            // 
            this.listmuk.HideSelection = false;
            this.listmuk.Location = new System.Drawing.Point(6, 20);
            this.listmuk.Name = "listmuk";
            this.listmuk.Size = new System.Drawing.Size(532, 221);
            this.listmuk.TabIndex = 0;
            this.listmuk.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntemizle);
            this.groupBox1.Controls.Add(this.btnçalıştır);
            this.groupBox1.Controls.Add(this.boxbitiş);
            this.groupBox1.Controls.Add(this.boxbaşlangıç);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş Bilgileri";
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(637, 65);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 5;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnçalıştır
            // 
            this.btnçalıştır.Location = new System.Drawing.Point(637, 19);
            this.btnçalıştır.Name = "btnçalıştır";
            this.btnçalıştır.Size = new System.Drawing.Size(75, 23);
            this.btnçalıştır.TabIndex = 4;
            this.btnçalıştır.Text = "Çalıştır";
            this.btnçalıştır.UseVisualStyleBackColor = true;
            this.btnçalıştır.Click += new System.EventHandler(this.btnçalıştır_Click);
            // 
            // boxbitiş
            // 
            this.boxbitiş.Location = new System.Drawing.Point(438, 38);
            this.boxbitiş.Name = "boxbitiş";
            this.boxbitiş.Size = new System.Drawing.Size(100, 20);
            this.boxbitiş.TabIndex = 3;
            // 
            // boxbaşlangıç
            // 
            this.boxbaşlangıç.Location = new System.Drawing.Point(142, 38);
            this.boxbaşlangıç.Name = "boxbaşlangıç";
            this.boxbaşlangıç.Size = new System.Drawing.Size(100, 20);
            this.boxbaşlangıç.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bitiş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlangıç";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(928, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.TekSayılar.ResumeLayout(false);
            this.TekSayılar.PerformLayout();
            this.ÇiftSayılar.ResumeLayout(false);
            this.ÇiftSayılar.PerformLayout();
            this.AsalSayılar.ResumeLayout(false);
            this.AsalSayılar.PerformLayout();
            this.MükemmelSayılar.ResumeLayout(false);
            this.MükemmelSayılar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TekSayılar;
        private System.Windows.Forms.ListView listtek;
        private System.Windows.Forms.TabPage ÇiftSayılar;
        private System.Windows.Forms.TabPage AsalSayılar;
        private System.Windows.Forms.TabPage MükemmelSayılar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnçalıştır;
        private System.Windows.Forms.MaskedTextBox boxbitiş;
        private System.Windows.Forms.MaskedTextBox boxbaşlangıç;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listtekçarpım;
        private System.Windows.Forms.ListView listtektoplam;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listçift;
        private System.Windows.Forms.ListView listçiftçarpım;
        private System.Windows.Forms.ListView listçifttoplam;
        private System.Windows.Forms.ListView listasalçarpım;
        private System.Windows.Forms.ListView listasaltoplam;
        private System.Windows.Forms.ListView listasal;
        private System.Windows.Forms.ListView listmukçarpım;
        private System.Windows.Forms.ListView listmuktoplam;
        private System.Windows.Forms.ListView listmuk;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader TekÇarpım;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

