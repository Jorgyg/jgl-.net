namespace Cientifico.View
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lblDni;
        private TextBox txtDni;
        private Label lblNomApels;
        private TextBox txtNomApels;
        private Button btnGuardar;
        private Button btnCancelar;

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

                this.lblDni = new System.Windows.Forms.Label();
                this.txtDni = new System.Windows.Forms.TextBox();
                this.lblNomApels = new System.Windows.Forms.Label();
                this.txtNomApels = new System.Windows.Forms.TextBox();
                this.btnGuardar = new System.Windows.Forms.Button();
                this.btnCancelar = new System.Windows.Forms.Button();
                this.SuspendLayout();
 
                this.lblDni.AutoSize = true;
                this.lblDni.Location = new System.Drawing.Point(26, 29);
                this.lblDni.Name = "lblDni";
                this.lblDni.Size = new System.Drawing.Size(32, 13);
                this.lblDni.TabIndex = 0;
                this.lblDni.Text = "DNI:";

                this.txtDni.Location = new System.Drawing.Point(82, 26);
                this.txtDni.Name = "txtDni";
                this.txtDni.Size = new System.Drawing.Size(100, 20);
                this.txtDni.TabIndex = 1;

                this.lblNomApels.AutoSize = true;
                this.lblNomApels.Location = new System.Drawing.Point(26, 67);
                this.lblNomApels.Name = "lblNomApels";
                this.lblNomApels.Size = new System.Drawing.Size(50, 13);
                this.lblNomApels.TabIndex = 2;
                this.lblNomApels.Text = "Nombre:";
 
                this.txtNomApels.Location = new System.Drawing.Point(82, 64);
                this.txtNomApels.Name = "txtNomApels";
                this.txtNomApels.Size = new System.Drawing.Size(200, 20);
                this.txtNomApels.TabIndex = 3;

                this.btnGuardar.Location = new System.Drawing.Point(82, 103);
                this.btnGuardar.Name = "btnGuardar";
                this.btnGuardar.Size = new System.Drawing.Size(75, 23);
                this.btnGuardar.TabIndex = 4;
                this.btnGuardar.Text = "Guardar";
                this.btnGuardar.UseVisualStyleBackColor = true;
                this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

                this.btnCancelar.Location = new System.Drawing.Point(207, 103);
                this.btnCancelar.Name = "btnCancelar";
                this.btnCancelar.Size = new System.Drawing.Size(75, 23);
                this.btnCancelar.TabIndex = 5;
                this.btnCancelar.Text = "Cancelar";
                this.btnCancelar.UseVisualStyleBackColor = true;
                this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

                this.components.Add(this.btnCancelar);
                this.components.Add(this.btnGuardar);
                this.components.Add(this.txtNomApels);
                this.components.Add(this.lblNomApels);
                this.components.Add(this.txtDni);
                this.components.Add(this.lblDni);

            }

        private void PerformLayout()
        {
            throw new NotImplementedException();
        }

        private void ResumeLayout(bool v)
        {
            throw new NotImplementedException();
        }

        private void SuspendLayout()
        {
            throw new NotImplementedException();
        }
    }

        #endregion
    }
}