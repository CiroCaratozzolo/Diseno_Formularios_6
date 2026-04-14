namespace DiseñoFormularios6
{
    partial class FrmRecepcion
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            label9 = new Label();
            comboBox3 = new ComboBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label10 = new Label();
            comboBox4 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 51);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 31);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(296, 31);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 140);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 5;
            label3.Text = "DNI";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(90, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 592);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Paciente";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 188);
            label9.Name = "label9";
            label9.Size = new Size(50, 25);
            label9.TabIndex = 23;
            label9.Text = "Sexo";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(90, 185);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(150, 33);
            comboBox3.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(424, 125);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 21;
            label8.Text = "Especialidad";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(424, 153);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 51);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 19;
            label7.Text = "Obra Social";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(424, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(224, 483);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 14;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(346, 483);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 13;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 328);
            label6.Name = "label6";
            label6.Size = new Size(150, 25);
            label6.TabIndex = 12;
            label6.Text = "Seleccionar Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(6, 356);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 31);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(90, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 283);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 9;
            label5.Text = "Teléfono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(90, 238);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 31);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 238);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 7;
            label4.Text = "Mail";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(424, 205);
            label10.Name = "label10";
            label10.Size = new Size(100, 25);
            label10.TabIndex = 25;
            label10.Text = "Profesional";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(424, 233);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 33);
            comboBox4.TabIndex = 24;
            // 
            // FrmRecepcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 616);
            Controls.Add(groupBox1);
            Name = "FrmRecepcion";
            Text = "Clínica CAI - Recepción";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button button2;
        private Button button1;
        private Label label8;
        private ComboBox comboBox2;
        private Label label7;
        private ComboBox comboBox1;
        private Label label9;
        private ComboBox comboBox3;
        private Label label10;
        private ComboBox comboBox4;
    }
}