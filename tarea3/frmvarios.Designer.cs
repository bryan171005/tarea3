namespace MiPrimerApp2025C
{
    partial class frmvarios
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
            dtpNacimiento = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtpcalculo = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(3, 27);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(231, 23);
            dtpNacimiento.TabIndex = 0;
            dtpNacimiento.ValueChanged += dtpNacimiento_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "fecha de nacimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 71);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 3;
            label2.Text = "fecha de calculo";
            // 
            // dtpcalculo
            // 
            dtpcalculo.Location = new Point(3, 105);
            dtpcalculo.Name = "dtpcalculo";
            dtpcalculo.Size = new Size(231, 23);
            dtpcalculo.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpNacimiento, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpcalculo, 0, 3);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Location = new Point(88, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.80282F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 66.19718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.Size = new Size(615, 228);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(310, 157);
            button1.Name = "button1";
            button1.Size = new Size(302, 41);
            button1.TabIndex = 4;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(88, 349);
            button2.Name = "button2";
            button2.Size = new Size(156, 23);
            button2.TabIndex = 5;
            button2.Text = "MOSTRAR DATOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 301);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 265);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "CURP";
            // 
            // frmvarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(tableLayoutPanel1);
            Name = "frmvarios";
            Text = "frmvarios";
            Load += frmvarios_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpNacimiento;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpcalculo;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label3;
    }
}