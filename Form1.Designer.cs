namespace Paint
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkaPlanDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkSeçmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şekilÇizmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yuvarlakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sürprizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyasızRasgeleYuvarlakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(984, 124);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(132, 117);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(997, 73);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Renk Değiştirme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(993, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Harflerin renkleri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaPlanDeğiştirToolStripMenuItem,
            this.renkSeçmeToolStripMenuItem,
            this.şekilÇizmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1168, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // arkaPlanDeğiştirToolStripMenuItem
            // 
            this.arkaPlanDeğiştirToolStripMenuItem.Name = "arkaPlanDeğiştirToolStripMenuItem";
            this.arkaPlanDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.arkaPlanDeğiştirToolStripMenuItem.Text = "Arka Plan Değiştir";
            this.arkaPlanDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.arkaPlanDeğiştirToolStripMenuItem_Click);
            // 
            // renkSeçmeToolStripMenuItem
            // 
            this.renkSeçmeToolStripMenuItem.Name = "renkSeçmeToolStripMenuItem";
            this.renkSeçmeToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.renkSeçmeToolStripMenuItem.Text = "Renk Seçme";
            this.renkSeçmeToolStripMenuItem.Click += new System.EventHandler(this.renkSeçmeToolStripMenuItem_Click);
            // 
            // şekilÇizmeToolStripMenuItem
            // 
            this.şekilÇizmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yuvarlakToolStripMenuItem,
            this.sürprizToolStripMenuItem,
            this.boyasızRasgeleYuvarlakToolStripMenuItem});
            this.şekilÇizmeToolStripMenuItem.Name = "şekilÇizmeToolStripMenuItem";
            this.şekilÇizmeToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.şekilÇizmeToolStripMenuItem.Text = "Şekil Çizme";
            this.şekilÇizmeToolStripMenuItem.Click += new System.EventHandler(this.şekilÇizmeToolStripMenuItem_Click);
            // 
            // yuvarlakToolStripMenuItem
            // 
            this.yuvarlakToolStripMenuItem.Name = "yuvarlakToolStripMenuItem";
            this.yuvarlakToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.yuvarlakToolStripMenuItem.Text = "Yuvarlak";
            this.yuvarlakToolStripMenuItem.Click += new System.EventHandler(this.yuvarlakToolStripMenuItem_Click);
            // 
            // sürprizToolStripMenuItem
            // 
            this.sürprizToolStripMenuItem.Name = "sürprizToolStripMenuItem";
            this.sürprizToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.sürprizToolStripMenuItem.Text = "Rasgele boyalı yuvarlak";
            this.sürprizToolStripMenuItem.Click += new System.EventHandler(this.sürprizToolStripMenuItem_Click);
            // 
            // boyasızRasgeleYuvarlakToolStripMenuItem
            // 
            this.boyasızRasgeleYuvarlakToolStripMenuItem.Name = "boyasızRasgeleYuvarlakToolStripMenuItem";
            this.boyasızRasgeleYuvarlakToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.boyasızRasgeleYuvarlakToolStripMenuItem.Text = "Kare";
            this.boyasızRasgeleYuvarlakToolStripMenuItem.Click += new System.EventHandler(this.boyasızRasgeleYuvarlakToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "8",
            "10",
            "12",
            "15",
            "20",
            "25",
            "32"});
            this.comboBox1.Location = new System.Drawing.Point(119, 47);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kalınlık:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 42);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mehmet Berkay"});
            this.comboBox2.Location = new System.Drawing.Point(605, 240);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 581);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem renkSeçmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şekilÇizmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yuvarlakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sürprizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyasızRasgeleYuvarlakToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

