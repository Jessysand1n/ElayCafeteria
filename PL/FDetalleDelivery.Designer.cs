namespace PL
{
    partial class FDetalleDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.seleccion = new System.Windows.Forms.ComboBox();
            this.especificaciondeliveri = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.horallegada = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.horapedido = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.totalpago = new System.Windows.Forms.NumericUpDown();
            this.fechaderegistro = new System.Windows.Forms.DateTimePicker();
            this.correo = new System.Windows.Forms.Label();
            this.telefono = new System.Windows.Forms.Label();
            this.apellido = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDelivery = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.totalpago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // seleccion
            // 
            this.seleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccion.FormattingEnabled = true;
            this.seleccion.Location = new System.Drawing.Point(-329, -177);
            this.seleccion.Margin = new System.Windows.Forms.Padding(4);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(329, 38);
            this.seleccion.TabIndex = 40;
            this.seleccion.Text = "Selecciona un usuario";
            // 
            // especificaciondeliveri
            // 
            this.especificaciondeliveri.AutoSize = true;
            this.especificaciondeliveri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especificaciondeliveri.Location = new System.Drawing.Point(-336, 437);
            this.especificaciondeliveri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.especificaciondeliveri.Name = "especificaciondeliveri";
            this.especificaciondeliveri.Size = new System.Drawing.Size(343, 31);
            this.especificaciondeliveri.TabIndex = 39;
            this.especificaciondeliveri.Text = "Especificacion para deliveri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(603, -95);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(233, 31);
            this.label11.TabIndex = 38;
            this.label11.Text = "Fecha de registro:";
            // 
            // horallegada
            // 
            this.horallegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horallegada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horallegada.Location = new System.Drawing.Point(668, 335);
            this.horallegada.Margin = new System.Windows.Forms.Padding(4);
            this.horallegada.Name = "horallegada";
            this.horallegada.Size = new System.Drawing.Size(212, 37);
            this.horallegada.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(662, 301);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(321, 31);
            this.label10.TabIndex = 36;
            this.label10.Text = "Hora estimada de llegada";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(897, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 31);
            this.label9.TabIndex = 35;
            this.label9.Text = "Hora de pedido:";
            // 
            // horapedido
            // 
            this.horapedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horapedido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horapedido.Location = new System.Drawing.Point(668, 218);
            this.horapedido.Margin = new System.Windows.Forms.Padding(4);
            this.horapedido.Name = "horapedido";
            this.horapedido.Size = new System.Drawing.Size(212, 37);
            this.horapedido.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(640, 503);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 39);
            this.label8.TabIndex = 33;
            this.label8.Text = "Total a pagar:";
            // 
            // totalpago
            // 
            this.totalpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpago.Location = new System.Drawing.Point(890, 503);
            this.totalpago.Margin = new System.Windows.Forms.Padding(4);
            this.totalpago.Name = "totalpago";
            this.totalpago.ReadOnly = true;
            this.totalpago.Size = new System.Drawing.Size(136, 46);
            this.totalpago.TabIndex = 32;
            // 
            // fechaderegistro
            // 
            this.fechaderegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaderegistro.Location = new System.Drawing.Point(610, -55);
            this.fechaderegistro.Margin = new System.Windows.Forms.Padding(4);
            this.fechaderegistro.Name = "fechaderegistro";
            this.fechaderegistro.Size = new System.Drawing.Size(527, 37);
            this.fechaderegistro.TabIndex = 31;
            // 
            // correo
            // 
            this.correo.AutoSize = true;
            this.correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correo.Location = new System.Drawing.Point(230, -55);
            this.correo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(121, 39);
            this.correo.TabIndex = 30;
            this.correo.Text = "Correo";
            // 
            // telefono
            // 
            this.telefono.AutoSize = true;
            this.telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono.Location = new System.Drawing.Point(230, -102);
            this.telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(150, 39);
            this.telefono.TabIndex = 29;
            this.telefono.Text = "Telefono";
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(-337, -55);
            this.apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(140, 39);
            this.apellido.TabIndex = 28;
            this.apellido.Text = "Apellido";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(-337, -102);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(138, 39);
            this.nombre.TabIndex = 27;
            this.nombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 635);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(458, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "Deseas hacer algun cambio?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(720, 674);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "Listo para seguir?";
            // 
            // btnvolver
            // 
            this.btnvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolver.Location = new System.Drawing.Point(-241, 558);
            this.btnvolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(213, 89);
            this.btnvolver.TabIndex = 24;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(764, 716);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(213, 89);
            this.btnguardar.TabIndex = 23;
            this.btnguardar.Text = "Guardar y continuar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, -196);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "Detalles del pedido";
            // 
            // dgvDelivery
            // 
            this.dgvDelivery.BackgroundColor = System.Drawing.Color.White;
            this.dgvDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDelivery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelivery.EnableHeadersVisualStyles = false;
            this.dgvDelivery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvDelivery.Location = new System.Drawing.Point(40, 231);
            this.dgvDelivery.Name = "dgvDelivery";
            this.dgvDelivery.RowHeadersVisible = false;
            this.dgvDelivery.RowHeadersWidth = 51;
            this.dgvDelivery.RowTemplate.Height = 24;
            this.dgvDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelivery.Size = new System.Drawing.Size(426, 318);
            this.dgvDelivery.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(329, 38);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.Text = "Selecciona un usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(600, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 39);
            this.label4.TabIndex = 46;
            this.label4.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(600, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 39);
            this.label5.TabIndex = 45;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 170);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 39);
            this.label6.TabIndex = 44;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 39);
            this.label7.TabIndex = 43;
            this.label7.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 578);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(343, 31);
            this.label13.TabIndex = 48;
            this.label13.Text = "Especificacion para deliveri";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(562, 612);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 89);
            this.button1.TabIndex = 49;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(505, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(461, 50);
            this.label14.TabIndex = 50;
            this.label14.Text = "DETALLES DEL PEDIDO";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(980, 148);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(290, 150);
            this.gMapControl1.TabIndex = 51;
            this.gMapControl1.Zoom = 0D;
            // 
            // FDetalleDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1452, 850);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDelivery);
            this.Controls.Add(this.seleccion);
            this.Controls.Add(this.especificaciondeliveri);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.horallegada);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.horapedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.totalpago);
            this.Controls.Add(this.fechaderegistro);
            this.Controls.Add(this.correo);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDetalleDelivery";
            this.Text = "FDetalleDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.totalpago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelivery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox seleccion;
        private System.Windows.Forms.Label especificaciondeliveri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker horallegada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker horapedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown totalpago;
        private System.Windows.Forms.DateTimePicker fechaderegistro;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label telefono;
        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDelivery;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}