namespace NutriFlow.Forms
{
    partial class frmExercicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExercicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbHabitos = new System.Windows.Forms.CheckBox();
            this.ckbHidratacao = new System.Windows.Forms.CheckBox();
            this.ckbSono = new System.Windows.Forms.CheckBox();
            this.ckbGanho = new System.Windows.Forms.CheckBox();
            this.ckbPerda = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planejamento de Exercícios Diários";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbHabitos);
            this.groupBox1.Controls.Add(this.ckbHidratacao);
            this.groupBox1.Controls.Add(this.ckbSono);
            this.groupBox1.Controls.Add(this.ckbGanho);
            this.groupBox1.Controls.Add(this.ckbPerda);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(139, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 143);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perda de Peso";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ckbHabitos
            // 
            this.ckbHabitos.AutoSize = true;
            this.ckbHabitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.ckbHabitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHabitos.ForeColor = System.Drawing.Color.White;
            this.ckbHabitos.Location = new System.Drawing.Point(19, 117);
            this.ckbHabitos.Name = "ckbHabitos";
            this.ckbHabitos.Size = new System.Drawing.Size(66, 17);
            this.ckbHabitos.TabIndex = 30;
            this.ckbHabitos.Text = "Prancha";
            this.ckbHabitos.UseVisualStyleBackColor = false;
            // 
            // ckbHidratacao
            // 
            this.ckbHidratacao.AutoSize = true;
            this.ckbHidratacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.ckbHidratacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHidratacao.ForeColor = System.Drawing.Color.White;
            this.ckbHidratacao.Location = new System.Drawing.Point(19, 93);
            this.ckbHidratacao.Name = "ckbHidratacao";
            this.ckbHidratacao.Size = new System.Drawing.Size(120, 17);
            this.ckbHidratacao.TabIndex = 29;
            this.ckbHidratacao.Text = "Corrida Estacionária";
            this.ckbHidratacao.UseVisualStyleBackColor = false;
            // 
            // ckbSono
            // 
            this.ckbSono.AutoSize = true;
            this.ckbSono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.ckbSono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSono.ForeColor = System.Drawing.Color.White;
            this.ckbSono.Location = new System.Drawing.Point(19, 70);
            this.ckbSono.Name = "ckbSono";
            this.ckbSono.Size = new System.Drawing.Size(140, 17);
            this.ckbSono.TabIndex = 28;
            this.ckbSono.Text = "Agachamento com salto";
            this.ckbSono.UseVisualStyleBackColor = false;
            // 
            // ckbGanho
            // 
            this.ckbGanho.AutoSize = true;
            this.ckbGanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.ckbGanho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGanho.ForeColor = System.Drawing.Color.White;
            this.ckbGanho.Location = new System.Drawing.Point(19, 47);
            this.ckbGanho.Name = "ckbGanho";
            this.ckbGanho.Size = new System.Drawing.Size(82, 17);
            this.ckbGanho.TabIndex = 27;
            this.ckbGanho.Text = "Polichinelos";
            this.ckbGanho.UseVisualStyleBackColor = false;
            // 
            // ckbPerda
            // 
            this.ckbPerda.AutoSize = true;
            this.ckbPerda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.ckbPerda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbPerda.ForeColor = System.Drawing.Color.White;
            this.ckbPerda.Location = new System.Drawing.Point(19, 24);
            this.ckbPerda.Name = "ckbPerda";
            this.ckbPerda.Size = new System.Drawing.Size(65, 17);
            this.ckbPerda.TabIndex = 26;
            this.ckbPerda.Text = "Burpees";
            this.ckbPerda.UseVisualStyleBackColor = false;
            this.ckbPerda.CheckedChanged += new System.EventHandler(this.ckbPerda_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(139, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 143);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Melhora Cardiovascular";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(19, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Melhora de hábitos alimentares";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(19, 93);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.Text = "Salto com Corda";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(19, 70);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 17);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "Saltos Laterais";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.ForeColor = System.Drawing.Color.White;
            this.checkBox4.Location = new System.Drawing.Point(19, 47);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(91, 17);
            this.checkBox4.TabIndex = 27;
            this.checkBox4.Text = "Sprints Curtos";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.ForeColor = System.Drawing.Color.White;
            this.checkBox5.Location = new System.Drawing.Point(19, 24);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 17);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "Subida de Escada";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // frmExercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(48)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(501, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExercicio";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExercicio";
            this.Load += new System.EventHandler(this.frmExercicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbHabitos;
        private System.Windows.Forms.CheckBox ckbHidratacao;
        private System.Windows.Forms.CheckBox ckbSono;
        private System.Windows.Forms.CheckBox ckbGanho;
        private System.Windows.Forms.CheckBox ckbPerda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}