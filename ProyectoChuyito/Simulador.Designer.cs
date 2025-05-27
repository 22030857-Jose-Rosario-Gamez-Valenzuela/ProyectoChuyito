namespace ProyectoChuyito
{
    partial class Simulador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simulador));
            this.LblPlanSug = new System.Windows.Forms.Label();
            this.LblLimit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl12Mes = new System.Windows.Forms.Label();
            this.NupSaldoDeu = new System.Windows.Forms.NumericUpDown();
            this.Lbl6Mes = new System.Windows.Forms.Label();
            this.Lbl3Mes = new System.Windows.Forms.Label();
            this.Lbl1Mes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtSaldoDeu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NupSaldoDeu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPlanSug
            // 
            this.LblPlanSug.AutoSize = true;
            this.LblPlanSug.BackColor = System.Drawing.Color.Transparent;
            this.LblPlanSug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlanSug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPlanSug.Location = new System.Drawing.Point(399, 266);
            this.LblPlanSug.Name = "LblPlanSug";
            this.LblPlanSug.Size = new System.Drawing.Size(260, 31);
            this.LblPlanSug.TabIndex = 0;
            this.LblPlanSug.Text = "PLAN SUGERIDO:";
            // 
            // LblLimit
            // 
            this.LblLimit.AutoSize = true;
            this.LblLimit.BackColor = System.Drawing.Color.Transparent;
            this.LblLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLimit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblLimit.Location = new System.Drawing.Point(399, 306);
            this.LblLimit.Name = "LblLimit";
            this.LblLimit.Size = new System.Drawing.Size(304, 31);
            this.LblLimit.TabIndex = 0;
            this.LblLimit.Text = "LIMITE DE CREDITO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(490, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "SIMULADOR DE EJECUCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(490, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "SALDO DEUDOR:";
            // 
            // Lbl12Mes
            // 
            this.Lbl12Mes.AutoSize = true;
            this.Lbl12Mes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl12Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl12Mes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl12Mes.Location = new System.Drawing.Point(490, 455);
            this.Lbl12Mes.Name = "Lbl12Mes";
            this.Lbl12Mes.Size = new System.Drawing.Size(484, 31);
            this.Lbl12Mes.TabIndex = 0;
            this.Lbl12Mes.Text = "SI PAGA EN 12 MESES PAGARIA $";
            // 
            // NupSaldoDeu
            // 
            this.NupSaldoDeu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NupSaldoDeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NupSaldoDeu.Location = new System.Drawing.Point(749, 399);
            this.NupSaldoDeu.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NupSaldoDeu.Name = "NupSaldoDeu";
            this.NupSaldoDeu.Size = new System.Drawing.Size(120, 38);
            this.NupSaldoDeu.TabIndex = 1;
            this.NupSaldoDeu.ValueChanged += new System.EventHandler(this.NupSaldoDeu_ValueChanged);
            this.NupSaldoDeu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NupSaldoDeu_KeyDown);
            // 
            // Lbl6Mes
            // 
            this.Lbl6Mes.AutoSize = true;
            this.Lbl6Mes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl6Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6Mes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl6Mes.Location = new System.Drawing.Point(490, 508);
            this.Lbl6Mes.Name = "Lbl6Mes";
            this.Lbl6Mes.Size = new System.Drawing.Size(468, 31);
            this.Lbl6Mes.TabIndex = 0;
            this.Lbl6Mes.Text = "SI PAGA EN 6 MESES PAGARIA $";
            // 
            // Lbl3Mes
            // 
            this.Lbl3Mes.AutoSize = true;
            this.Lbl3Mes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl3Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3Mes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl3Mes.Location = new System.Drawing.Point(490, 553);
            this.Lbl3Mes.Name = "Lbl3Mes";
            this.Lbl3Mes.Size = new System.Drawing.Size(468, 31);
            this.Lbl3Mes.TabIndex = 0;
            this.Lbl3Mes.Text = "SI PAGA EN 3 MESES PAGARIA $";
            // 
            // Lbl1Mes
            // 
            this.Lbl1Mes.AutoSize = true;
            this.Lbl1Mes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl1Mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1Mes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Lbl1Mes.Location = new System.Drawing.Point(490, 602);
            this.Lbl1Mes.Name = "Lbl1Mes";
            this.Lbl1Mes.Size = new System.Drawing.Size(468, 31);
            this.Lbl1Mes.TabIndex = 0;
            this.Lbl1Mes.Text = "SI PAGA EN 1 MESES PAGARIA $";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(790, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pantalla Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(1389, 644);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(442, 336);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // TxtSaldoDeu
            // 
            this.TxtSaldoDeu.Location = new System.Drawing.Point(299, 455);
            this.TxtSaldoDeu.Name = "TxtSaldoDeu";
            this.TxtSaldoDeu.Size = new System.Drawing.Size(100, 20);
            this.TxtSaldoDeu.TabIndex = 6;
            this.TxtSaldoDeu.Visible = false;
            this.TxtSaldoDeu.TextChanged += new System.EventHandler(this.TxtSaldoDeu_TextChanged);
            // 
            // Simulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1940, 1025);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSaldoDeu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NupSaldoDeu);
            this.Controls.Add(this.Lbl1Mes);
            this.Controls.Add(this.Lbl3Mes);
            this.Controls.Add(this.Lbl6Mes);
            this.Controls.Add(this.Lbl12Mes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblLimit);
            this.Controls.Add(this.LblPlanSug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Simulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Simulador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NupSaldoDeu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlanSug;
        private System.Windows.Forms.Label LblLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl12Mes;
        private System.Windows.Forms.NumericUpDown NupSaldoDeu;
        private System.Windows.Forms.Label Lbl6Mes;
        private System.Windows.Forms.Label Lbl3Mes;
        private System.Windows.Forms.Label Lbl1Mes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtSaldoDeu;
    }
}