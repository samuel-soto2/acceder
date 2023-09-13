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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Aqua;
            panel1.Controls.Add(cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(406, 39);
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
            cerrar.Location = new Point(368, 3);
            cerrar.Name = "cerrar";
            cerrar.Size = new Size(35, 33);
            cerrar.TabIndex = 0;
            cerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(406, 440);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cerrar;
    }
}