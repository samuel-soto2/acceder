namespace acceso
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            panel1 = new Panel();
            cerrar2 = new Button();
            n_user = new TextBox();
            n_pass = new TextBox();
            guardar = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(cerrar2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 36);
            panel1.TabIndex = 0;
            // 
            // cerrar2
            // 
            cerrar2.FlatAppearance.BorderColor = Color.White;
            cerrar2.FlatAppearance.BorderSize = 0;
            cerrar2.FlatAppearance.MouseDownBackColor = Color.White;
            cerrar2.FlatAppearance.MouseOverBackColor = Color.White;
            cerrar2.FlatStyle = FlatStyle.Flat;
            cerrar2.Image = (Image)resources.GetObject("cerrar2.Image");
            cerrar2.Location = new Point(342, 3);
            cerrar2.Name = "cerrar2";
            cerrar2.Size = new Size(37, 30);
            cerrar2.TabIndex = 0;
            cerrar2.UseVisualStyleBackColor = true;
            // 
            // n_user
            // 
            n_user.BackColor = SystemColors.Info;
            n_user.BorderStyle = BorderStyle.None;
            n_user.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n_user.Location = new Point(137, 71);
            n_user.Name = "n_user";
            n_user.Size = new Size(208, 21);
            n_user.TabIndex = 1;
            n_user.TextAlign = HorizontalAlignment.Center;
            // 
            // n_pass
            // 
            n_pass.BackColor = SystemColors.Info;
            n_pass.BorderStyle = BorderStyle.None;
            n_pass.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            n_pass.Location = new Point(137, 138);
            n_pass.Name = "n_pass";
            n_pass.Size = new Size(208, 21);
            n_pass.TabIndex = 2;
            n_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // guardar
            // 
            guardar.BackColor = Color.OrangeRed;
            guardar.FlatAppearance.BorderColor = Color.White;
            guardar.FlatAppearance.BorderSize = 0;
            guardar.FlatAppearance.MouseDownBackColor = Color.White;
            guardar.FlatAppearance.MouseOverBackColor = Color.White;
            guardar.FlatStyle = FlatStyle.Flat;
            guardar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            guardar.Location = new Point(141, 195);
            guardar.Name = "guardar";
            guardar.Size = new Size(90, 35);
            guardar.TabIndex = 3;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 139);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 263);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(guardar);
            Controls.Add(n_pass);
            Controls.Add(n_user);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registro";
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cerrar2;
        private TextBox n_user;
        private TextBox n_pass;
        private Button guardar;
        private Label label1;
        private Label label2;
    }
}