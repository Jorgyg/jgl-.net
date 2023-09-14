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
            dgvCientificos = new DataGridView();
            dgvProyectos = new DataGridView();
            dgvAsignaciones = new DataGridView();
            btnAsignar = new Button();
            btnEliminarAsignacion = new Button();
            btnCrearCientifico = new Button();
            txtNuevoCientifico = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCientificos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).BeginInit();
            SuspendLayout();
            // 
            // dgvCientificos
            // 
            dgvCientificos.ColumnHeadersHeight = 29;
            dgvCientificos.Location = new Point(140, 20);
            dgvCientificos.Name = "dgvCientificos";
            dgvCientificos.RowHeadersWidth = 51;
            dgvCientificos.Size = new Size(300, 200);
            dgvCientificos.TabIndex = 0;
            // 
            // dgvProyectos
            // 
            dgvProyectos.ColumnHeadersHeight = 29;
            dgvProyectos.Location = new Point(140, 241);
            dgvProyectos.Name = "dgvProyectos";
            dgvProyectos.RowHeadersWidth = 51;
            dgvProyectos.Size = new Size(630, 150);
            dgvProyectos.TabIndex = 1;
            // 
            // dgvAsignaciones
            // 
            dgvAsignaciones.ColumnHeadersHeight = 29;
            dgvAsignaciones.Location = new Point(470, 20);
            dgvAsignaciones.Name = "dgvAsignaciones";
            dgvAsignaciones.RowHeadersWidth = 51;
            dgvAsignaciones.Size = new Size(300, 200);
            dgvAsignaciones.TabIndex = 2;
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(801, 45);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(100, 30);
            btnAsignar.TabIndex = 3;
            btnAsignar.Text = "Asignar";
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnEliminarAsignacion
            // 
            btnEliminarAsignacion.Location = new Point(801, 107);
            btnEliminarAsignacion.Name = "btnEliminarAsignacion";
            btnEliminarAsignacion.Size = new Size(100, 30);
            btnEliminarAsignacion.TabIndex = 4;
            btnEliminarAsignacion.Text = "Eliminar";
            btnEliminarAsignacion.Click += btnEliminarAsignacion_Click;
            // 
            // btnCrearCientifico
            // 
            btnCrearCientifico.Location = new Point(171, 542);
            btnCrearCientifico.Name = "btnCrearCientifico";
            btnCrearCientifico.Size = new Size(100, 30);
            btnCrearCientifico.TabIndex = 5;
            btnCrearCientifico.Text = "Crear";
            btnCrearCientifico.Click += btnCrearCientifico_Click;
            // 
            // txtNuevoCientifico
            // 
            txtNuevoCientifico.Location = new Point(140, 454);
            txtNuevoCientifico.Name = "txtNuevoCientifico";
            txtNuevoCientifico.Size = new Size(180, 27);
            txtNuevoCientifico.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 509);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 457);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 10;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 422);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 11;
            label2.Text = "Crear cientifico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 514);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(528, 514);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 18;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(638, 422);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 17;
            label5.Text = "Crear proyecto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 454);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 16;
            label6.Text = "Horas";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(598, 509);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 15;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(638, 542);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 13;
            button1.Text = "Crear";
            button1.Click += btnCrearProyecto_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(598, 454);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 590);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvCientificos);
            Controls.Add(dgvProyectos);
            Controls.Add(dgvAsignaciones);
            Controls.Add(btnAsignar);
            Controls.Add(btnEliminarAsignacion);
            Controls.Add(btnCrearCientifico);
            Controls.Add(txtNuevoCientifico);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCientificos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProyectos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsignaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvCientificos;
        private DataGridView dgvProyectos;
        private DataGridView dgvAsignaciones;
        private Button btnAsignar;
        private Button btnEliminarAsignacion;
        private Button btnCrearCientifico;
        private TextBox txtNuevoCientifico;
        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private EventHandler textBox2_TextChanged;
        private EventHandler textBox3_TextChanged;
        private EventHandler txtNuevoCientifico_TextChanged;
    }
}