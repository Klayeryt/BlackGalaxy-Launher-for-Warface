
namespace login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.registered = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passreg = new System.Windows.Forms.TextBox();
            this.loginReg = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 22);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(486, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(16, 13);
            this.close.TabIndex = 1;
            this.close.Text = "   ";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // registered
            // 
            this.registered.BackColor = System.Drawing.Color.Transparent;
            this.registered.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registered.BackgroundImage")));
            this.registered.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.registered.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.registered.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.registered.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.registered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registered.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registered.ForeColor = System.Drawing.Color.Ivory;
            this.registered.Location = new System.Drawing.Point(379, 41);
            this.registered.Name = "registered";
            this.registered.Size = new System.Drawing.Size(127, 29);
            this.registered.TabIndex = 8;
            this.registered.Text = "Зарегистрироваться";
            this.registered.UseVisualStyleBackColor = false;
            this.registered.Click += new System.EventHandler(this.registered_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.passreg);
            this.panel3.Controls.Add(this.loginReg);
            this.panel3.Controls.Add(this.registered);
            this.panel3.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 78);
            this.panel3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Ivory;
            this.button1.Location = new System.Drawing.Point(379, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Авторизация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Russo One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // passreg
            // 
            this.passreg.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.passreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passreg.ForeColor = System.Drawing.SystemColors.Info;
            this.passreg.Location = new System.Drawing.Point(99, 41);
            this.passreg.MaxLength = 20;
            this.passreg.Name = "passreg";
            this.passreg.PasswordChar = '*';
            this.passreg.Size = new System.Drawing.Size(122, 23);
            this.passreg.TabIndex = 12;
            this.passreg.TextChanged += new System.EventHandler(this.passreg_TextChanged);
            this.passreg.Enter += new System.EventHandler(this.passreg_Enter);
            this.passreg.Leave += new System.EventHandler(this.passreg_Leave);
            // 
            // loginReg
            // 
            this.loginReg.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.loginReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginReg.ForeColor = System.Drawing.SystemColors.Info;
            this.loginReg.Location = new System.Drawing.Point(99, 11);
            this.loginReg.MaxLength = 20;
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(122, 23);
            this.loginReg.TabIndex = 11;
            this.loginReg.Click += new System.EventHandler(this.loginReg_Click);
            this.loginReg.Enter += new System.EventHandler(this.loginReg_Enter);
            this.loginReg.Leave += new System.EventHandler(this.loginReg_Leave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 355);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registered;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox passreg;
        public System.Windows.Forms.TextBox loginReg;
        private System.Windows.Forms.Button button1;
    }
}