namespace Problema4
{
    partial class TaxeAutovehicule
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.Val = new System.Windows.Forms.TextBox();
            this.Cil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Hibride",
            "Electrice",
            "Euro 6",
            "Euro 5",
            "Euro 4",
            "Euro 3",
            "Euro 2",
            "Euro 1",
            "Non-Euro"});
            this.comboBox2.Location = new System.Drawing.Point(47, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(295, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Norma de poluare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(457, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Emisia de dioxid de carbon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(48, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Capacitatea cilindrică";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(457, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vechimea autovehiculului ";
            // 
            // Data
            // 
            this.Data.CustomFormat = "";
            this.Data.Location = new System.Drawing.Point(477, 258);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(264, 22);
            this.Data.TabIndex = 13;
            this.Data.CloseUp += new System.EventHandler(this.Data_CloseUp);
            // 
            // Val
            // 
            this.Val.AccessibleDescription = "";
            this.Val.Location = new System.Drawing.Point(511, 123);
            this.Val.Name = "Val";
            this.Val.Size = new System.Drawing.Size(241, 22);
            this.Val.TabIndex = 14;
            this.Val.Text = "0";
            this.Val.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Val_KeyPress_1);
            this.Val.Validated += new System.EventHandler(this.Val_Validated);
            // 
            // Cil
            // 
            this.Cil.AccessibleDescription = "";
            this.Cil.Location = new System.Drawing.Point(71, 260);
            this.Cil.Name = "Cil";
            this.Cil.Size = new System.Drawing.Size(241, 22);
            this.Cil.TabIndex = 15;
            this.Cil.Text = "0";
            this.Cil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cil_KeyPress);
            this.Cil.Validated += new System.EventHandler(this.Cil_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GreenYellow;
            this.button1.Location = new System.Drawing.Point(535, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Calculeaza";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rez
            // 
            this.rez.BackColor = System.Drawing.SystemColors.Info;
            this.rez.Location = new System.Drawing.Point(860, 30);
            this.rez.Multiline = true;
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(341, 327);
            this.rez.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(747, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 24);
            this.button2.TabIndex = 18;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // TaxeAutovehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1264, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Cil);
            this.Controls.Add(this.Val);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Name = "TaxeAutovehicule";
            this.Text = "TaxeAnuale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.TextBox Val;
        private System.Windows.Forms.TextBox Cil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox rez;
        private System.Windows.Forms.Button button2;
    }
}

