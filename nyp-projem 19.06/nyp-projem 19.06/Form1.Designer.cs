namespace nyp_projem_19._06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanıcıadtxt = new System.Windows.Forms.Label();
            this.sifretxt = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.giristxt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.kullanicisifretxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullaniciaditxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kullanıcıadtxt
            // 
            this.kullanıcıadtxt.AutoSize = true;
            this.kullanıcıadtxt.Location = new System.Drawing.Point(156, 72);
            this.kullanıcıadtxt.Name = "kullanıcıadtxt";
            this.kullanıcıadtxt.Size = new System.Drawing.Size(73, 15);
            this.kullanıcıadtxt.TabIndex = 0;
            this.kullanıcıadtxt.Text = "Kullanıcı Adı";
            // 
            // sifretxt
            // 
            this.sifretxt.AutoSize = true;
            this.sifretxt.Location = new System.Drawing.Point(156, 114);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.Size = new System.Drawing.Size(30, 15);
            this.sifretxt.TabIndex = 0;
            this.sifretxt.Text = "Şifre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(239, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // giristxt
            // 
            this.giristxt.Location = new System.Drawing.Point(207, 156);
            this.giristxt.Name = "giristxt";
            this.giristxt.Size = new System.Drawing.Size(75, 23);
            this.giristxt.TabIndex = 2;
            this.giristxt.Text = "GİRİŞ";
            this.giristxt.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(222, 70);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 23);
            this.idtxt.TabIndex = 1;
            this.idtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // kullanicisifretxt
            // 
            this.kullanicisifretxt.Location = new System.Drawing.Point(222, 141);
            this.kullanicisifretxt.Name = "kullanicisifretxt";
            this.kullanicisifretxt.Size = new System.Drawing.Size(100, 23);
            this.kullanicisifretxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "kullanıcı adı";
            // 
            // kullaniciaditxt
            // 
            this.kullaniciaditxt.Location = new System.Drawing.Point(222, 99);
            this.kullaniciaditxt.Name = "kullaniciaditxt";
            this.kullaniciaditxt.Size = new System.Drawing.Size(100, 23);
            this.kullaniciaditxt.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(494, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanicisifretxt);
            this.Controls.Add(this.kullaniciaditxt);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kullanıcıadtxt;
        private Label sifretxt;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button giristxt;
        private Button button1;
        private TextBox idtxt;
        private TextBox kullanicisifretxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox kullaniciaditxt;
    }
}