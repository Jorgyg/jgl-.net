namespace Cientifico
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            this.dgvCientificos = new DataGridView();
            this.dgvCientificos.Location = new System.Drawing.Point(20, 20);
            this.dgvCientificos.Size = new System.Drawing.Size(300, 200);

            this.dgvProyectos = new DataGridView();
            this.dgvProyectos.Location = new System.Drawing.Point(350, 20);
            this.dgvProyectos.Size = new System.Drawing.Size(300, 200);

            this.dgvAsignaciones = new DataGridView();
            this.dgvAsignaciones.Location = new System.Drawing.Point(20, 250);
            this.dgvAsignaciones.Size = new System.Drawing.Size(630, 150);

            this.btnAsignar = new Button();
            this.btnAsignar.Location = new System.Drawing.Point(670, 50);
            this.btnAsignar.Size = new System.Drawing.Size(100, 30);
            this.btnAsignar.Text = "Asignar";

            this.btnEliminarAsignacion = new Button();
            this.btnEliminarAsignacion.Location = new System.Drawing.Point(670, 100);
            this.btnEliminarAsignacion.Size = new System.Drawing.Size(100, 30);
            this.btnEliminarAsignacion.Text = "Eliminar";

            this.btnCrearCientifico = new Button();
            this.btnCrearCientifico.Location = new System.Drawing.Point(20, 380);
            this.btnCrearCientifico.Size = new System.Drawing.Size(100, 30);
            this.btnCrearCientifico.Text = "Crear Científico";

            this.btnCrearProyecto = new Button();
            this.btnCrearProyecto.Location = new System.Drawing.Point(350, 380);
            this.btnCrearProyecto.Size = new System.Drawing.Size(100, 30);
            this.btnCrearProyecto.Text = "Crear Proyecto";

            this.txtNuevoCientifico = new TextBox();
            this.txtNuevoCientifico.Location = new System.Drawing.Point(140, 380);
            this.txtNuevoCientifico.Size = new System.Drawing.Size(180, 30);

            this.txtNuevoProyecto = new TextBox();
            this.txtNuevoProyecto.Location = new System.Drawing.Point(470, 380);
            this.txtNuevoProyecto.Size = new System.Drawing.Size(180, 30);

            this.Controls.Add(this.dgvCientificos);
            this.Controls.Add(this.dgvProyectos);
            this.Controls.Add(this.dgvAsignaciones);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnEliminarAsignacion);
            this.Controls.Add(this.btnCrearCientifico);
            this.Controls.Add(this.btnCrearProyecto);
            this.Controls.Add(this.txtNuevoCientifico);
            this.Controls.Add(this.txtNuevoProyecto);

            this.btnAsignar.Click += new EventHandler(btnAsignar_Click);
            this.btnEliminarAsignacion.Click += new EventHandler(btnEliminarAsignacion_Click);
            this.btnCrearCientifico.Click += new EventHandler(btnCrearCientifico_Click);
            this.btnCrearProyecto.Click += new EventHandler(btnCrearProyecto_Click);
        }
        private DataGridView dgvCientificos;
        private DataGridView dgvProyectos;
        private DataGridView dgvAsignaciones;
        private Button btnAsignar;
        private Button btnEliminarAsignacion;
        private Button btnCrearCientifico;
        private Button btnCrearProyecto;
        private TextBox txtNuevoCientifico;
        private TextBox txtNuevoProyecto;
        #endregion
    }
}