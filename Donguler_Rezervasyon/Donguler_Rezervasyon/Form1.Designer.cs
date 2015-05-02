namespace Donguler_Rezervasyon
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudXSirasi = new System.Windows.Forms.NumericUpDown();
            this.nudYSirasi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKoltuklariYerlestir = new System.Windows.Forms.Button();
            this.scAnaPanel = new System.Windows.Forms.SplitContainer();
            this.pnlSecenekler = new System.Windows.Forms.Panel();
            this.cbKoltukTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHicbiri = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudXSirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYSirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).BeginInit();
            this.scAnaPanel.Panel1.SuspendLayout();
            this.scAnaPanel.Panel2.SuspendLayout();
            this.scAnaPanel.SuspendLayout();
            this.pnlSecenekler.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yan Yana Koltuk Sayısı";
            // 
            // nudXSirasi
            // 
            this.nudXSirasi.Location = new System.Drawing.Point(272, 6);
            this.nudXSirasi.Name = "nudXSirasi";
            this.nudXSirasi.Size = new System.Drawing.Size(120, 32);
            this.nudXSirasi.TabIndex = 1;
            this.nudXSirasi.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudYSirasi
            // 
            this.nudYSirasi.Location = new System.Drawing.Point(272, 44);
            this.nudYSirasi.Name = "nudYSirasi";
            this.nudYSirasi.Size = new System.Drawing.Size(120, 32);
            this.nudYSirasi.TabIndex = 3;
            this.nudYSirasi.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arka Arkaya Koltuk Sayısı";
            // 
            // btnKoltuklariYerlestir
            // 
            this.btnKoltuklariYerlestir.Location = new System.Drawing.Point(410, 6);
            this.btnKoltuklariYerlestir.Name = "btnKoltuklariYerlestir";
            this.btnKoltuklariYerlestir.Size = new System.Drawing.Size(149, 68);
            this.btnKoltuklariYerlestir.TabIndex = 4;
            this.btnKoltuklariYerlestir.Text = "Koltuklari Yerleştir";
            this.btnKoltuklariYerlestir.UseVisualStyleBackColor = true;
            this.btnKoltuklariYerlestir.Click += new System.EventHandler(this.btnKoltuklariYerlestir_Click);
            // 
            // scAnaPanel
            // 
            this.scAnaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scAnaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAnaPanel.Location = new System.Drawing.Point(0, 0);
            this.scAnaPanel.Name = "scAnaPanel";
            this.scAnaPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAnaPanel.Panel1
            // 
            this.scAnaPanel.Panel1.Controls.Add(this.label1);
            this.scAnaPanel.Panel1.Controls.Add(this.btnKoltuklariYerlestir);
            this.scAnaPanel.Panel1.Controls.Add(this.nudXSirasi);
            this.scAnaPanel.Panel1.Controls.Add(this.nudYSirasi);
            this.scAnaPanel.Panel1.Controls.Add(this.label2);
            // 
            // scAnaPanel.Panel2
            // 
            this.scAnaPanel.Panel2.Controls.Add(this.pnlSecenekler);
            this.scAnaPanel.Size = new System.Drawing.Size(568, 502);
            this.scAnaPanel.SplitterDistance = 82;
            this.scAnaPanel.TabIndex = 5;
            // 
            // pnlSecenekler
            // 
            this.pnlSecenekler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSecenekler.Controls.Add(this.cbKoltukTipi);
            this.pnlSecenekler.Controls.Add(this.label4);
            this.pnlSecenekler.Controls.Add(this.rbHicbiri);
            this.pnlSecenekler.Controls.Add(this.rbKadin);
            this.pnlSecenekler.Controls.Add(this.label3);
            this.pnlSecenekler.Controls.Add(this.rbErkek);
            this.pnlSecenekler.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSecenekler.Location = new System.Drawing.Point(366, 0);
            this.pnlSecenekler.Name = "pnlSecenekler";
            this.pnlSecenekler.Size = new System.Drawing.Size(200, 414);
            this.pnlSecenekler.TabIndex = 0;
            // 
            // cbKoltukTipi
            // 
            this.cbKoltukTipi.FormattingEnabled = true;
            this.cbKoltukTipi.Items.AddRange(new object[] {
            "Pencere",
            "Koridor"});
            this.cbKoltukTipi.Location = new System.Drawing.Point(19, 186);
            this.cbKoltukTipi.Name = "cbKoltukTipi";
            this.cbKoltukTipi.Size = new System.Drawing.Size(121, 33);
            this.cbKoltukTipi.TabIndex = 5;
            this.cbKoltukTipi.SelectedIndexChanged += new System.EventHandler(this.cbKoltukTipi_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Koltuk Tipi";
            // 
            // rbHicbiri
            // 
            this.rbHicbiri.AutoSize = true;
            this.rbHicbiri.Checked = true;
            this.rbHicbiri.Location = new System.Drawing.Point(19, 112);
            this.rbHicbiri.Name = "rbHicbiri";
            this.rbHicbiri.Size = new System.Drawing.Size(91, 30);
            this.rbHicbiri.TabIndex = 3;
            this.rbHicbiri.TabStop = true;
            this.rbHicbiri.Text = "Hiçbiri";
            this.rbHicbiri.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Location = new System.Drawing.Point(19, 76);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(86, 30);
            this.rbKadin.TabIndex = 2;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(19, 40);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(86, 30);
            this.rbErkek.TabIndex = 0;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.scAnaPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudXSirasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYSirasi)).EndInit();
            this.scAnaPanel.Panel1.ResumeLayout(false);
            this.scAnaPanel.Panel1.PerformLayout();
            this.scAnaPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scAnaPanel)).EndInit();
            this.scAnaPanel.ResumeLayout(false);
            this.pnlSecenekler.ResumeLayout(false);
            this.pnlSecenekler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudXSirasi;
        private System.Windows.Forms.NumericUpDown nudYSirasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKoltuklariYerlestir;
        private System.Windows.Forms.SplitContainer scAnaPanel;
        private System.Windows.Forms.Panel pnlSecenekler;
        private System.Windows.Forms.RadioButton rbHicbiri;
        private System.Windows.Forms.RadioButton rbKadin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.ComboBox cbKoltukTipi;
        private System.Windows.Forms.Label label4;
    }
}

