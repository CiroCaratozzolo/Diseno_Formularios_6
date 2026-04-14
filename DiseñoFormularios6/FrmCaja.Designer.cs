namespace DiseñoFormularios6
{
    partial class FrmCaja
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
            textBox1 = new TextBox();
            Resumen = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            Resumen.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 66);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Resumen
            // 
            Resumen.Controls.Add(label4);
            Resumen.Controls.Add(textBox4);
            Resumen.Controls.Add(label3);
            Resumen.Controls.Add(textBox3);
            Resumen.Controls.Add(label2);
            Resumen.Controls.Add(textBox2);
            Resumen.Controls.Add(label1);
            Resumen.Controls.Add(textBox1);
            Resumen.Location = new Point(12, 12);
            Resumen.Name = "Resumen";
            Resumen.Size = new Size(569, 290);
            Resumen.TabIndex = 1;
            Resumen.TabStop = false;
            Resumen.Text = "Resumen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 69);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 111);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 3;
            label2.Text = "Nombre Doctor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 108);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 151);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 5;
            label3.Text = "Concepto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 148);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 207);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 7;
            label4.Text = "Total";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(283, 204);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(12, 308);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(568, 355);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de pago";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(105, 77);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Efectivo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(210, 77);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(175, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Tarjeta de Crédito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(391, 77);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(138, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Transferencia";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 119);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 6;
            label5.Text = "Banco";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 183);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 8;
            label6.Text = "Cuotas";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(210, 211);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(189, 287);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(307, 287);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmCaja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 670);
            Controls.Add(groupBox1);
            Controls.Add(Resumen);
            Name = "FrmCaja";
            Text = "Clínica CAI - Caja";
            Resumen.ResumeLayout(false);
            Resumen.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private GroupBox Resumen;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
        private ComboBox comboBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
    }
}