
namespace WindowsForms_Modulzaro_epuletek
{
    partial class Form_Csaladihaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Csaladihaz));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Cim = new System.Windows.Forms.TextBox();
            this.numericUpDown_Alapterulet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_Munka_kezdete = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Munka_vege = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_Ottelok_szama = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_Garazs = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Epitesi_anyag = new System.Windows.Forms.ComboBox();
            this.comboBox_Teto_tipusa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Listaba_rakja_a_csaladihazat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ottelok_szama)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // textBox_Cim
            // 
            this.textBox_Cim.Location = new System.Drawing.Point(51, 21);
            this.textBox_Cim.Name = "textBox_Cim";
            this.textBox_Cim.Size = new System.Drawing.Size(204, 20);
            this.textBox_Cim.TabIndex = 1;
            // 
            // numericUpDown_Alapterulet
            // 
            this.numericUpDown_Alapterulet.Location = new System.Drawing.Point(135, 58);
            this.numericUpDown_Alapterulet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Alapterulet.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Alapterulet.Name = "numericUpDown_Alapterulet";
            this.numericUpDown_Alapterulet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Alapterulet.TabIndex = 2;
            this.numericUpDown_Alapterulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Alapterulet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alapterület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Munkakezdés kezdete ";
            // 
            // dateTimePicker_Munka_kezdete
            // 
            this.dateTimePicker_Munka_kezdete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Munka_kezdete.Location = new System.Drawing.Point(135, 126);
            this.dateTimePicker_Munka_kezdete.Name = "dateTimePicker_Munka_kezdete";
            this.dateTimePicker_Munka_kezdete.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_Munka_kezdete.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Munkavégzés vége ";
            // 
            // dateTimePicker_Munka_vege
            // 
            this.dateTimePicker_Munka_vege.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Munka_vege.Location = new System.Drawing.Point(135, 162);
            this.dateTimePicker_Munka_vege.Name = "dateTimePicker_Munka_vege";
            this.dateTimePicker_Munka_vege.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_Munka_vege.TabIndex = 5;
            // 
            // numericUpDown_Ottelok_szama
            // 
            this.numericUpDown_Ottelok_szama.Location = new System.Drawing.Point(135, 202);
            this.numericUpDown_Ottelok_szama.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Ottelok_szama.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Ottelok_szama.Name = "numericUpDown_Ottelok_szama";
            this.numericUpDown_Ottelok_szama.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Ottelok_szama.TabIndex = 2;
            this.numericUpDown_Ottelok_szama.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Ottelok_szama.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tető típusa";
            // 
            // checkBox_Garazs
            // 
            this.checkBox_Garazs.AutoSize = true;
            this.checkBox_Garazs.Location = new System.Drawing.Point(94, 240);
            this.checkBox_Garazs.Name = "checkBox_Garazs";
            this.checkBox_Garazs.Size = new System.Drawing.Size(82, 17);
            this.checkBox_Garazs.TabIndex = 7;
            this.checkBox_Garazs.Text = "Van garázs ";
            this.checkBox_Garazs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox_Garazs.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Építési anyag";
            // 
            // comboBox_Epitesi_anyag
            // 
            this.comboBox_Epitesi_anyag.FormattingEnabled = true;
            this.comboBox_Epitesi_anyag.Location = new System.Drawing.Point(99, 93);
            this.comboBox_Epitesi_anyag.Name = "comboBox_Epitesi_anyag";
            this.comboBox_Epitesi_anyag.Size = new System.Drawing.Size(156, 21);
            this.comboBox_Epitesi_anyag.TabIndex = 8;
            // 
            // comboBox_Teto_tipusa
            // 
            this.comboBox_Teto_tipusa.FormattingEnabled = true;
            this.comboBox_Teto_tipusa.Location = new System.Drawing.Point(99, 277);
            this.comboBox_Teto_tipusa.Name = "comboBox_Teto_tipusa";
            this.comboBox_Teto_tipusa.Size = new System.Drawing.Size(156, 21);
            this.comboBox_Teto_tipusa.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ott élők száma";
            // 
            // button_Listaba_rakja_a_csaladihazat
            // 
            this.button_Listaba_rakja_a_csaladihazat.Location = new System.Drawing.Point(19, 332);
            this.button_Listaba_rakja_a_csaladihazat.Name = "button_Listaba_rakja_a_csaladihazat";
            this.button_Listaba_rakja_a_csaladihazat.Size = new System.Drawing.Size(246, 23);
            this.button_Listaba_rakja_a_csaladihazat.TabIndex = 9;
            this.button_Listaba_rakja_a_csaladihazat.Text = "Hozzáadja a listához";
            this.button_Listaba_rakja_a_csaladihazat.UseVisualStyleBackColor = true;
            this.button_Listaba_rakja_a_csaladihazat.Click += new System.EventHandler(this.button_Listaba_rakja_a_csaladihazat_Click);
            // 
            // Form_Csaladihaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 395);
            this.Controls.Add(this.button_Listaba_rakja_a_csaladihazat);
            this.Controls.Add(this.comboBox_Teto_tipusa);
            this.Controls.Add(this.comboBox_Epitesi_anyag);
            this.Controls.Add(this.checkBox_Garazs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_Munka_vege);
            this.Controls.Add(this.dateTimePicker_Munka_kezdete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Ottelok_szama);
            this.Controls.Add(this.numericUpDown_Alapterulet);
            this.Controls.Add(this.textBox_Cim);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Csaladihaz";
            this.Text = "Új családiház adatai";
            this.Load += new System.EventHandler(this.Form_Csaladihaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Alapterulet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Ottelok_szama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Cim;
        private System.Windows.Forms.NumericUpDown numericUpDown_Alapterulet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Munka_kezdete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Munka_vege;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ottelok_szama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Garazs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Epitesi_anyag;
        private System.Windows.Forms.ComboBox comboBox_Teto_tipusa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Listaba_rakja_a_csaladihazat;
    }
}