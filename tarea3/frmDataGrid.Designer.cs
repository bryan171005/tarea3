namespace MiPrimerApp2025C
{
    partial class frmDataGrid
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
            dgvDatos = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnGuardar = new Button();
            saveFileDialogDataGrid = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            abrirarchivo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(2, 2);
            dgvDatos.Margin = new Padding(2);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 62;
            dgvDatos.Size = new Size(959, 295);
            dgvDatos.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(abrirarchivo, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvDatos, 0, 0);
            tableLayoutPanel1.Location = new Point(39, 11);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.1167F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8833F));
            tableLayoutPanel1.Size = new Size(963, 348);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnGuardar.Location = new Point(57, 375);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(959, 20);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // saveFileDialogDataGrid
            // 
            saveFileDialogDataGrid.Filter = "Archivo CSV|*.csv";
            saveFileDialogDataGrid.FileOk += saveFileDialogDataGrid_FileOk;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Archivo CSV|*csv";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // abrirarchivo
            // 
            abrirarchivo.Location = new Point(3, 302);
            abrirarchivo.Name = "abrirarchivo";
            abrirarchivo.Size = new Size(957, 23);
            abrirarchivo.TabIndex = 2;
            abrirarchivo.Text = "Abrir archivos";
            abrirarchivo.UseVisualStyleBackColor = true;
            abrirarchivo.Click += button1_Click;
            // 
            // frmDataGrid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 445);
            Controls.Add(btnGuardar);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "frmDataGrid";
            Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnGuardar;
        private SaveFileDialog saveFileDialogDataGrid;
        private OpenFileDialog openFileDialog1;
        private Button abrirarchivo;
    }
}