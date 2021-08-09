
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox_Esedekes_befejezes = new System.Windows.Forms.ListBox();
            this.button_Esedekes_befejezesek_listat_frissit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Epuletek
            // 
            this.listBox_Epuletek.FormattingEnabled = true;
            this.listBox_Epuletek.Location = new System.Drawing.Point(0, 28);
            this.listBox_Epuletek.Name = "listBox_Epuletek";
            this.listBox_Epuletek.Size = new System.Drawing.Size(130, 238);
            this.listBox_Epuletek.TabIndex = 0;
            this.listBox_Epuletek.SelectedIndexChanged += new System.EventHandler(this.listBox_Epuletek_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
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
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Az épület címe";
            // 
            // textBox_Epulet_cime
            // 
            this.textBox_Epulet_cime.Location = new System.Drawing.Point(160, 45);
            this.textBox_Epulet_cime.Name = "textBox_Epulet_cime";
            this.textBox_Epulet_cime.Size = new System.Drawing.Size(187, 20);
            this.textBox_Epulet_cime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Becsült felújítási költsége";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBox_Esedekes_befejezes
            // 
            this.listBox_Esedekes_befejezes.FormattingEnabled = true;
            this.listBox_Esedekes_befejezes.Location = new System.Drawing.Point(424, 28);
            this.listBox_Esedekes_befejezes.Name = "listBox_Esedekes_befejezes";
            this.listBox_Esedekes_befejezes.Size = new System.Drawing.Size(129, 160);
            this.listBox_Esedekes_befejezes.TabIndex = 6;
            // 
            // button_Esedekes_befejezesek_listat_frissit
            // 
            this.button_Esedekes_befejezesek_listat_frissit.Location = new System.Drawing.Point(424, 209);
            this.button_Esedekes_befejezesek_listat_frissit.Name = "button_Esedekes_befejezesek_listat_frissit";
            this.button_Esedekes_befejezesek_listat_frissit.Size = new System.Drawing.Size(129, 23);
            this.button_Esedekes_befejezesek_listat_frissit.TabIndex = 7;
            this.button_Esedekes_befejezesek_listat_frissit.Text = "Frissít";
            this.button_Esedekes_befejezesek_listat_frissit.UseVisualStyleBackColor = true;
            // 
            // Form_Nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 290);
            this.Controls.Add(this.button_Esedekes_befejezesek_listat_frissit);
            this.Controls.Add(this.listBox_Esedekes_befejezes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Epulet_cime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Epuletek);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Nyito";
            this.Text = "épület felújítási karbantartó alkalmazás";
            this.Load += new System.EventHandler(this.Form_Nyito_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox_Esedekes_befejezes;
        private System.Windows.Forms.Button button_Esedekes_befejezesek_listat_frissit;
    }
}

