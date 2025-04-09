namespace terscapasSi.UI
{
    partial class CategoriaForm
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
            nudId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            chkActiva = new CheckBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            SuspendLayout();
            // 
            // nudId
            // 
            nudId.Location = new Point(175, 75);
            nudId.Name = "nudId";
            nudId.Size = new Size(150, 27);
            nudId.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(66, 138);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 27);
            txtNombre.TabIndex = 2;
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(140, 186);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(72, 24);
            chkActiva.TabIndex = 4;
            chkActiva.Text = "Activa";
            chkActiva.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(163, 424);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(176, 59);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(326, 322);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(124, 65);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(184, 322);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(124, 65);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(42, 322);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(124, 65);
            btnCrear.TabIndex = 18;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // CategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 653);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(chkActiva);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(nudId);
            Name = "CategoriaForm";
            Text = "CategoriaForm";
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label label1;
        private CheckBox chkActiva;
        private Button btnBuscar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCrear;
    }
}