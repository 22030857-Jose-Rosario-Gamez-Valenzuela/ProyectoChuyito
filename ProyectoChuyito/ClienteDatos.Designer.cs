namespace ProyectoChuyito
{
    partial class ClienteDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCurp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDomicilio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RdbCasado = new System.Windows.Forms.RadioButton();
            this.RdbSoltero = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.NupIngresosMen = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NupHijos = new System.Windows.Forms.NumericUpDown();
            this.LblIngresos = new System.Windows.Forms.Label();
            this.LblPlanSug = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PicBasicoMr = new System.Windows.Forms.PictureBox();
            this.PicOroMr = new System.Windows.Forms.PictureBox();
            this.PicPlatinumMr = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NupIngresosMen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupHijos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBasicoMr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOroMr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlatinumMr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(308, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CURP:";
            // 
            // TxtCurp
            // 
            this.TxtCurp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtCurp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurp.Location = new System.Drawing.Point(413, 256);
            this.TxtCurp.Name = "TxtCurp";
            this.TxtCurp.Size = new System.Drawing.Size(517, 38);
            this.TxtCurp.TabIndex = 0;
            this.TxtCurp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TxtCurp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCurp_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(308, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL CLIENTE:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.Silver;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(647, 311);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(436, 38);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(308, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "DOMICILIO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtDomicilio
            // 
            this.TxtDomicilio.BackColor = System.Drawing.Color.Silver;
            this.TxtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDomicilio.Location = new System.Drawing.Point(478, 357);
            this.TxtDomicilio.Name = "TxtDomicilio";
            this.TxtDomicilio.Size = new System.Drawing.Size(508, 38);
            this.TxtDomicilio.TabIndex = 2;
            this.TxtDomicilio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(308, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "ESTADO CIVIL:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // RdbCasado
            // 
            this.RdbCasado.AutoSize = true;
            this.RdbCasado.BackColor = System.Drawing.Color.Transparent;
            this.RdbCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCasado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RdbCasado.Location = new System.Drawing.Point(537, 409);
            this.RdbCasado.Name = "RdbCasado";
            this.RdbCasado.Size = new System.Drawing.Size(153, 35);
            this.RdbCasado.TabIndex = 3;
            this.RdbCasado.TabStop = true;
            this.RdbCasado.Text = "CASADO";
            this.RdbCasado.UseVisualStyleBackColor = false;
            this.RdbCasado.CheckedChanged += new System.EventHandler(this.RdbCasado_CheckedChanged);
            // 
            // RdbSoltero
            // 
            this.RdbSoltero.AutoSize = true;
            this.RdbSoltero.BackColor = System.Drawing.Color.Transparent;
            this.RdbSoltero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSoltero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RdbSoltero.Location = new System.Drawing.Point(700, 409);
            this.RdbSoltero.Name = "RdbSoltero";
            this.RdbSoltero.Size = new System.Drawing.Size(169, 35);
            this.RdbSoltero.TabIndex = 4;
            this.RdbSoltero.TabStop = true;
            this.RdbSoltero.Text = "SOLTERO";
            this.RdbSoltero.UseVisualStyleBackColor = false;
            this.RdbSoltero.CheckedChanged += new System.EventHandler(this.RdbSoltero_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(308, 504);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(359, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "INGRESOS MENSUALES:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // NupIngresosMen
            // 
            this.NupIngresosMen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NupIngresosMen.DecimalPlaces = 2;
            this.NupIngresosMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NupIngresosMen.Location = new System.Drawing.Point(673, 502);
            this.NupIngresosMen.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.NupIngresosMen.Name = "NupIngresosMen";
            this.NupIngresosMen.Size = new System.Drawing.Size(120, 38);
            this.NupIngresosMen.TabIndex = 6;
            this.NupIngresosMen.ValueChanged += new System.EventHandler(this.NupIngresosMen_ValueChanged);
            this.NupIngresosMen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NupIngresosMen_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(308, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "HIJOS:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // NupHijos
            // 
            this.NupHijos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NupHijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NupHijos.Location = new System.Drawing.Point(423, 450);
            this.NupHijos.Name = "NupHijos";
            this.NupHijos.Size = new System.Drawing.Size(120, 38);
            this.NupHijos.TabIndex = 5;
            // 
            // LblIngresos
            // 
            this.LblIngresos.AutoSize = true;
            this.LblIngresos.BackColor = System.Drawing.Color.Transparent;
            this.LblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngresos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblIngresos.Location = new System.Drawing.Point(308, 543);
            this.LblIngresos.Name = "LblIngresos";
            this.LblIngresos.Size = new System.Drawing.Size(404, 31);
            this.LblIngresos.TabIndex = 5;
            this.LblIngresos.Text = "INGRESOS ACUMULABLES: ";
            // 
            // LblPlanSug
            // 
            this.LblPlanSug.AutoSize = true;
            this.LblPlanSug.BackColor = System.Drawing.Color.Transparent;
            this.LblPlanSug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlanSug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPlanSug.Location = new System.Drawing.Point(308, 586);
            this.LblPlanSug.Name = "LblPlanSug";
            this.LblPlanSug.Size = new System.Drawing.Size(632, 31);
            this.LblPlanSug.TabIndex = 5;
            this.LblPlanSug.Text = "PLAN DE TARJETA DE CREDITO SUGERIDO:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(937, 633);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 87);
            this.button1.TabIndex = 7;
            this.button1.Text = "Continuar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PicBasicoMr
            // 
            this.PicBasicoMr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBasicoMr.Cursor = System.Windows.Forms.Cursors.No;
            this.PicBasicoMr.Image = ((System.Drawing.Image)(resources.GetObject("PicBasicoMr.Image")));
            this.PicBasicoMr.Location = new System.Drawing.Point(111, 633);
            this.PicBasicoMr.Name = "PicBasicoMr";
            this.PicBasicoMr.Size = new System.Drawing.Size(263, 330);
            this.PicBasicoMr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBasicoMr.TabIndex = 9;
            this.PicBasicoMr.TabStop = false;
            // 
            // PicOroMr
            // 
            this.PicOroMr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicOroMr.Cursor = System.Windows.Forms.Cursors.No;
            this.PicOroMr.Image = ((System.Drawing.Image)(resources.GetObject("PicOroMr.Image")));
            this.PicOroMr.Location = new System.Drawing.Point(380, 633);
            this.PicOroMr.Name = "PicOroMr";
            this.PicOroMr.Size = new System.Drawing.Size(263, 330);
            this.PicOroMr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicOroMr.TabIndex = 10;
            this.PicOroMr.TabStop = false;
            // 
            // PicPlatinumMr
            // 
            this.PicPlatinumMr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicPlatinumMr.Cursor = System.Windows.Forms.Cursors.No;
            this.PicPlatinumMr.Image = ((System.Drawing.Image)(resources.GetObject("PicPlatinumMr.Image")));
            this.PicPlatinumMr.Location = new System.Drawing.Point(649, 633);
            this.PicPlatinumMr.Name = "PicPlatinumMr";
            this.PicPlatinumMr.Size = new System.Drawing.Size(263, 330);
            this.PicPlatinumMr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPlatinumMr.TabIndex = 11;
            this.PicPlatinumMr.TabStop = false;
            this.PicPlatinumMr.Click += new System.EventHandler(this.PicPlatinum_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(495, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ClienteDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1935, 1100);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicPlatinumMr);
            this.Controls.Add(this.PicOroMr);
            this.Controls.Add(this.PicBasicoMr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPlanSug);
            this.Controls.Add(this.LblIngresos);
            this.Controls.Add(this.NupHijos);
            this.Controls.Add(this.NupIngresosMen);
            this.Controls.Add(this.RdbSoltero);
            this.Controls.Add(this.RdbCasado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtDomicilio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCurp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ClienteDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteDatos";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClienteDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NupIngresosMen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NupHijos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBasicoMr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicOroMr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPlatinumMr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCurp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDomicilio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton RdbCasado;
        private System.Windows.Forms.RadioButton RdbSoltero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NupIngresosMen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NupHijos;
        private System.Windows.Forms.Label LblIngresos;
        private System.Windows.Forms.Label LblPlanSug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PicBasicoMr;
        private System.Windows.Forms.PictureBox PicOroMr;
        private System.Windows.Forms.PictureBox PicPlatinumMr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}