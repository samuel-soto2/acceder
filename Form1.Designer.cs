namespace acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            cerrar = new Button();
            pictureBox1 = new PictureBox();
            user = new TextBox();
            pass = new TextBox();
            muestra = new CheckBox();
            entrar = new Button();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 39);
            panel1.TabIndex = 0;
            // 
            // cerrar
            // 
            cerrar.FlatAppearance.BorderColor = Color.White;
            cerrar.FlatAppearance.BorderSize = 0;
            cerrar.FlatAppearance.MouseDownBackColor = Color.White;
            cerrar.FlatAppearance.MouseOverBackColor = Color.White;
            cerrar.FlatStyle = FlatStyle.Flat;
            cerrar.Image = (Image)resources.GetObject("cerrar.Image");
            cerrar.Location = new Point(384, 3);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(35, 33);
            cerrar.TabIndex = 0;
            cerrar.UseVisualStyleBackColor = true;
            cerrar.Click += cerrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // user
            // 
            user.BorderStyle = BorderStyle.None;
            user.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user.Location = new Point(105, 203);
            user.Name = "user";
            user.Size = new Size(228, 21);
            user.TabIndex = 2;
            user.Text = "ingrese su usuario";
            user.TextAlign = HorizontalAlignment.Center;
            // 
            // pass
            // 
            pass.BorderStyle = BorderStyle.None;
            pass.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(105, 275);
            pass.Name = "pass";
            pass.Size = new Size(228, 21);
            pass.TabIndex = 3;
            pass.Text = "ingrese su contraseña";
            pass.TextAlign = HorizontalAlignment.Center;
            // 
            // muestra
            // 
            muestra.AutoSize = true;
            muestra.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            muestra.Location = new Point(274, 319);
            muestra.Name = "muestra";
            muestra.Size = new Size(69, 20);
            muestra.TabIndex = 4;
            muestra.Text = "Mostrar";
            muestra.UseVisualStyleBackColor = true;
            // 
            // entrar
            // 
            entrar.BackColor = Color.OrangeRed;
            entrar.FlatAppearance.BorderColor = Color.Blue;
            entrar.FlatAppearance.BorderSize = 0;
            entrar.FlatAppearance.MouseDownBackColor = Color.Blue;
            entrar.FlatAppearance.MouseOverBackColor = Color.Blue;
            entrar.FlatStyle = FlatStyle.Flat;
            entrar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            entrar.Location = new Point(166, 372);
            entrar.Name = "entrar";
            entrar.Size = new Size(98, 36);
            entrar.TabIndex = 5;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(133, 439);
            label1.Name = "label1";
            label1.Size = new Size(158, 18);
            label1.TabIndex = 6;
            label1.Text = "¿ No estas registrado?";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.OrangeRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            button1.FlatAppearance.MouseOverBackColor = Color.OrangeRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(166, 482);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 7;
            button1.Text = "Registrarme";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 540);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(entrar);
            Controls.Add(muestra);
            Controls.Add(pass);
            Controls.Add(user);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cerrar;
        private PictureBox pictureBox1;
        private TextBox user;
        private TextBox pass;
        private CheckBox muestra;
        private Button entrar;
        private Label label1;
        private Button button1;
    }
}