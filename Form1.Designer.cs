namespace MaxiALARMA
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
            Puertos = new ComboBox();
            label1 = new Label();
            btnAbrirPurto = new Button();
            EstadoPuerto = new Label();
            CerrarPuerto = new Button();
            ActivarSemaforo = new Button();
            btnDesactivar = new Button();
            label2 = new Label();
            comboBt = new ComboBox();
            testDatos = new Label();
            ArirPuertoBt = new Button();
            EstadoPuerto1 = new Label();
            SuspendLayout();
            // 
            // Puertos
            // 
            Puertos.FlatStyle = FlatStyle.Flat;
            Puertos.FormattingEnabled = true;
            Puertos.Location = new Point(160, 38);
            Puertos.Name = "Puertos";
            Puertos.Size = new Size(306, 23);
            Puertos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 38);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Seleccione el puerto: ";
            // 
            // btnAbrirPurto
            // 
            btnAbrirPurto.Location = new Point(535, 42);
            btnAbrirPurto.Name = "btnAbrirPurto";
            btnAbrirPurto.Size = new Size(107, 23);
            btnAbrirPurto.TabIndex = 2;
            btnAbrirPurto.Text = "Abrir puerto";
            btnAbrirPurto.UseVisualStyleBackColor = true;
            btnAbrirPurto.Click += btnAbrirPurto_Click;
            // 
            // EstadoPuerto
            // 
            EstadoPuerto.Location = new Point(86, 99);
            EstadoPuerto.Name = "EstadoPuerto";
            EstadoPuerto.Size = new Size(380, 35);
            EstadoPuerto.TabIndex = 3;
            // 
            // CerrarPuerto
            // 
            CerrarPuerto.Location = new Point(535, 95);
            CerrarPuerto.Name = "CerrarPuerto";
            CerrarPuerto.Size = new Size(75, 23);
            CerrarPuerto.TabIndex = 4;
            CerrarPuerto.Text = "cerrar puerto";
            CerrarPuerto.UseVisualStyleBackColor = true;
            CerrarPuerto.Click += CerrarPuerto_Click;
            // 
            // ActivarSemaforo
            // 
            ActivarSemaforo.Location = new Point(535, 142);
            ActivarSemaforo.Name = "ActivarSemaforo";
            ActivarSemaforo.Size = new Size(75, 23);
            ActivarSemaforo.TabIndex = 5;
            ActivarSemaforo.Text = "semaforo";
            ActivarSemaforo.UseVisualStyleBackColor = true;
            ActivarSemaforo.Click += ActivarSemaforo_Click;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Location = new Point(653, 142);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(75, 23);
            btnDesactivar.TabIndex = 6;
            btnDesactivar.Text = "Desactivar";
            btnDesactivar.UseVisualStyleBackColor = true;
            btnDesactivar.Click += btnDesactivar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 192);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 8;
            label2.Text = "Seleccione el puerto: ";
            // 
            // comboBt
            // 
            comboBt.FlatStyle = FlatStyle.Flat;
            comboBt.FormattingEnabled = true;
            comboBt.Location = new Point(160, 192);
            comboBt.Name = "comboBt";
            comboBt.Size = new Size(306, 23);
            comboBt.TabIndex = 7;
            // 
            // testDatos
            // 
            testDatos.Location = new Point(160, 320);
            testDatos.Name = "testDatos";
            testDatos.Size = new Size(380, 35);
            testDatos.TabIndex = 9;
            // 
            // ArirPuertoBt
            // 
            ArirPuertoBt.Location = new Point(503, 192);
            ArirPuertoBt.Name = "ArirPuertoBt";
            ArirPuertoBt.Size = new Size(107, 23);
            ArirPuertoBt.TabIndex = 10;
            ArirPuertoBt.Text = "Abrir puerto Bt";
            ArirPuertoBt.UseVisualStyleBackColor = true;
            ArirPuertoBt.Click += ArirPuertoBt_Click;
            // 
            // EstadoPuerto1
            // 
            EstadoPuerto1.Location = new Point(160, 249);
            EstadoPuerto1.Name = "EstadoPuerto1";
            EstadoPuerto1.Size = new Size(380, 35);
            EstadoPuerto1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(EstadoPuerto1);
            Controls.Add(ArirPuertoBt);
            Controls.Add(testDatos);
            Controls.Add(label2);
            Controls.Add(comboBt);
            Controls.Add(btnDesactivar);
            Controls.Add(ActivarSemaforo);
            Controls.Add(CerrarPuerto);
            Controls.Add(EstadoPuerto);
            Controls.Add(btnAbrirPurto);
            Controls.Add(label1);
            Controls.Add(Puertos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Puertos;
        private Label label1;
        private Button btnAbrirPurto;
        private Label EstadoPuerto;
        private Button CerrarPuerto;
        private Button ActivarSemaforo;
        private Button btnDesactivar;
        private Label label2;
        private ComboBox comboBox1;
        private Label testDatos;
        private ComboBox comboBt;
        private Button ArirPuertoBt;
        private Label EstadoPuerto1;
    }
}
