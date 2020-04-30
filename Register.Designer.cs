namespace DODO_Pitsa
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_pass = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reg_addr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_tel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.reg_tel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.reg_addr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.reg_login);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.reg_pass);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ФИО";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(50, 74);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(204, 20);
            this.fio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // reg_login
            // 
            this.reg_login.Location = new System.Drawing.Point(50, 22);
            this.reg_login.Name = "reg_login";
            this.reg_login.Size = new System.Drawing.Size(204, 20);
            this.reg_login.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // reg_pass
            // 
            this.reg_pass.Location = new System.Drawing.Point(50, 48);
            this.reg_pass.Name = "reg_pass";
            this.reg_pass.Size = new System.Drawing.Size(204, 20);
            this.reg_pass.TabIndex = 1;
            // 
            // reg_btn
            // 
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn.Location = new System.Drawing.Point(12, 219);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(260, 41);
            this.reg_btn.TabIndex = 9;
            this.reg_btn.Text = "Зарегистрироваться";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "ДОДО ПИТСА";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Адрес";
            // 
            // reg_addr
            // 
            this.reg_addr.Location = new System.Drawing.Point(50, 100);
            this.reg_addr.Name = "reg_addr";
            this.reg_addr.Size = new System.Drawing.Size(204, 20);
            this.reg_addr.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Телефон";
            // 
            // reg_tel
            // 
            this.reg_tel.Location = new System.Drawing.Point(50, 128);
            this.reg_tel.Name = "reg_tel";
            this.reg_tel.Size = new System.Drawing.Size(204, 20);
            this.reg_tel.TabIndex = 9;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reg_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "ДОДО ПИТСА: Регистрация";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reg_pass;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reg_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reg_addr;
        private System.Windows.Forms.Label label4;
    }
}