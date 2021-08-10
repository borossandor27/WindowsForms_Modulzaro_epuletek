
namespace WindowsForms_Modulzaro_epuletek
{
    partial class Form_Nyito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Nyito));
            this.listBox_Epuletek = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.újCsaládiházToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újTömbházToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Epulet_cime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_BecsultAr = new System.Windows.Forms.TextBox();
            this.listBox_Esedekes_befejezes = new System.Windows.Forms.ListBox();
            this.button_Esedekes_befejezesek_listat_frissit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Epuletek
            // 
            this.listBox_Epuletek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Epuletek.FormattingEnabled = true;
            this.listBox_Epuletek.Location = new System.Drawing.Point(3, 16);
            this.listBox_Epuletek.Name = "listBox_Epuletek";
            this.listBox_Epuletek.Size = new System.Drawing.Size(173, 215);
            this.listBox_Epuletek.TabIndex = 0;
            this.listBox_Epuletek.SelectedIndexChanged += new System.EventHandler(this.listBox_Epuletek_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újCsaládiházToolStripMenuItem,
            this.újTömbházToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(30, 20);
            this.toolStripMenuItem1.Text = "Új";
            // 
            // újCsaládiházToolStripMenuItem
            // 
            this.újCsaládiházToolStripMenuItem.Name = "újCsaládiházToolStripMenuItem";
            this.újCsaládiházToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.újCsaládiházToolStripMenuItem.Text = "Új családiház";
            this.újCsaládiházToolStripMenuItem.Click += new System.EventHandler(this.újCsaládiházToolStripMenuItem_Click);
            // 
            // újTömbházToolStripMenuItem
            // 
            this.újTömbházToolStripMenuItem.Name = "újTömbházToolStripMenuItem";
            this.újTömbházToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.újTömbházToolStripMenuItem.Text = "Új tömbház";
            this.újTömbházToolStripMenuItem.Click += new System.EventHandler(this.újTömbházToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Az épület címe";
            // 
            // textBox_Epulet_cime
            // 
            this.textBox_Epulet_cime.Location = new System.Drawing.Point(13, 32);
            this.textBox_Epulet_cime.Name = "textBox_Epulet_cime";
            this.textBox_Epulet_cime.Size = new System.Drawing.Size(187, 20);
            this.textBox_Epulet_cime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Becsült felújítási költsége";
            // 
            // textBox_BecsultAr
            // 
            this.textBox_BecsultAr.Location = new System.Drawing.Point(16, 99);
            this.textBox_BecsultAr.Name = "textBox_BecsultAr";
            this.textBox_BecsultAr.Size = new System.Drawing.Size(184, 20);
            this.textBox_BecsultAr.TabIndex = 5;
            this.textBox_BecsultAr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox_Esedekes_befejezes
            // 
            this.listBox_Esedekes_befejezes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Esedekes_befejezes.FormattingEnabled = true;
            this.listBox_Esedekes_befejezes.Location = new System.Drawing.Point(3, 16);
            this.listBox_Esedekes_befejezes.Name = "listBox_Esedekes_befejezes";
            this.listBox_Esedekes_befejezes.Size = new System.Drawing.Size(194, 173);
            this.listBox_Esedekes_befejezes.TabIndex = 6;
            // 
            // button_Esedekes_befejezesek_listat_frissit
            // 
            this.button_Esedekes_befejezesek_listat_frissit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Esedekes_befejezesek_listat_frissit.Location = new System.Drawing.Point(3, 189);
            this.button_Esedekes_befejezesek_listat_frissit.Name = "button_Esedekes_befejezesek_listat_frissit";
            this.button_Esedekes_befejezesek_listat_frissit.Size = new System.Drawing.Size(194, 23);
            this.button_Esedekes_befejezesek_listat_frissit.TabIndex = 7;
            this.button_Esedekes_befejezesek_listat_frissit.Text = "Frissít";
            this.button_Esedekes_befejezesek_listat_frissit.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Epuletek);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 234);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karbantartásra váró épületek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Epulet_cime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_BecsultAr);
            this.groupBox2.Location = new System.Drawing.Point(214, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 158);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiválasztott épület";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox_Esedekes_befejezes);
            this.groupBox3.Controls.Add(this.button_Esedekes_befejezesek_listat_frissit);
            this.groupBox3.Location = new System.Drawing.Point(490, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 215);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A mai nap befejezendő épületek";
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 290);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "épület felújítási karbantartó alkalmazás";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Nyito_FormClosing);
            this.Load += new System.EventHandler(this.Form_Nyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_Epuletek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem újCsaládiházToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újTömbházToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Epulet_cime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_BecsultAr;
        private System.Windows.Forms.ListBox listBox_Esedekes_befejezes;
        private System.Windows.Forms.Button button_Esedekes_befejezesek_listat_frissit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

