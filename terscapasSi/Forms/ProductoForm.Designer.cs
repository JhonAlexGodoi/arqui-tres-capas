namespace terscapasSi.UI
{
    partial class ProductoForm
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
            lblId = new Label();
            nubId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCodigoDeBarras = new Label();
            txtCodigoDeBarras = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            lblStock = new Label();
            nubStock = new NumericUpDown();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)nubId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nubStock).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(42, 76);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // nubId
            // 
            nubId.Location = new Point(116, 71);
            nubId.Margin = new Padding(3, 2, 3, 2);
            nubId.Name = "nubId";
            nubId.Size = new Size(131, 23);
            nubId.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 117);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 112);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblCodigoDeBarras
            // 
            lblCodigoDeBarras.AutoSize = true;
            lblCodigoDeBarras.Location = new Point(42, 155);
            lblCodigoDeBarras.Name = "lblCodigoDeBarras";
            lblCodigoDeBarras.Size = new Size(97, 15);
            lblCodigoDeBarras.TabIndex = 4;
            lblCodigoDeBarras.Text = "Codigo de barras";
            // 
            // txtCodigoDeBarras
            // 
            txtCodigoDeBarras.Location = new Point(172, 150);
            txtCodigoDeBarras.Margin = new Padding(3, 2, 3, 2);
            txtCodigoDeBarras.Name = "txtCodigoDeBarras";
            txtCodigoDeBarras.Size = new Size(110, 23);
            txtCodigoDeBarras.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(42, 186);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 6;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(172, 184);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(243, 84);
            txtDescripcion.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(46, 284);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(161, 278);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(110, 23);
            txtPrecio.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(41, 321);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += label1_Click;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(158, 324);
            cbCategoria.Margin = new Padding(3, 2, 3, 2);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(133, 23);
            cbCategoria.TabIndex = 11;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(48, 358);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // nubStock
            // 
            nubStock.Location = new Point(152, 358);
            nubStock.Margin = new Padding(3, 2, 3, 2);
            nubStock.Name = "nubStock";
            nubStock.Size = new Size(131, 23);
            nubStock.TabIndex = 13;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(28, 461);
            btnCrear.Margin = new Padding(3, 2, 3, 2);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(108, 49);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(169, 461);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(108, 49);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(304, 461);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 49);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(520, 464);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(154, 44);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // ProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 540);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(nubStock);
            Controls.Add(lblStock);
            Controls.Add(cbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(txtCodigoDeBarras);
            Controls.Add(lblCodigoDeBarras);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(nubId);
            Controls.Add(lblId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductoForm";
            Text = "ProductoForm";
            ((System.ComponentModel.ISupportInitialize)nubId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nubStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private NumericUpDown nubId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCodigoDeBarras;
        private TextBox txtCodigoDeBarras;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private Label lblStock;
        private NumericUpDown nubStock;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
    }
}