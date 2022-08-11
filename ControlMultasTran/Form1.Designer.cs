namespace ControlMultasTran
{
    partial class FrmMultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.txtVelocidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.lvMultas = new System.Windows.Forms.ListView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.buttobtnEliminar = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control de regitro de multas de transito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero de placa";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(750, 81);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(38, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Actual";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(750, 154);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(616, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Actual";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(138, 99);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 6;
            // 
            // txtVelocidad
            // 
            this.txtVelocidad.Location = new System.Drawing.Point(138, 185);
            this.txtVelocidad.Name = "txtVelocidad";
            this.txtVelocidad.Size = new System.Drawing.Size(100, 23);
            this.txtVelocidad.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingrese velocidad (km/h)";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(281, 219);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(75, 23);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // lvMultas
            // 
            this.lvMultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvMultas.Location = new System.Drawing.Point(116, 262);
            this.lvMultas.Name = "lvMultas";
            this.lvMultas.Size = new System.Drawing.Size(593, 136);
            this.lvMultas.TabIndex = 10;
            this.lvMultas.UseCompatibleStateImageBehavior = false;
            this.lvMultas.View = System.Windows.Forms.View.Details;
            this.lvMultas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMultas_MouseClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(545, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // buttobtnEliminar
            // 
            this.buttobtnEliminar.Location = new System.Drawing.Point(690, 415);
            this.buttobtnEliminar.Name = "buttobtnEliminar";
            this.buttobtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttobtnEliminar.TabIndex = 12;
            this.buttobtnEliminar.Text = "Eliminar";
            this.buttobtnEliminar.UseVisualStyleBackColor = true;
            this.buttobtnEliminar.Click += new System.EventHandler(this.buttobtnEliminar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Velocidad";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Multa";
            this.columnHeader5.Width = 120;
            // 
            // FrmMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttobtnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvMultas);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtVelocidad);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMultas";
            this.Text = "Control de registro de multas de transito";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFecha;
        private Label label4;
        private Label lblHora;
        private Label label6;
        private TextBox txtPlaca;
        private TextBox txtVelocidad;
        private Label label7;
        private Button btnregistrar;
        private ListView lvMultas;
        private Button btnSalir;
        private Button buttobtnEliminar;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}