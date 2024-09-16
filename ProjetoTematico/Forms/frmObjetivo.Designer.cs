﻿namespace NutriFlow.Forms
{
    partial class frmObjetivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjetivo));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHidratacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCalorias = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudPesoAtual = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudPesoDesejado = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudExercicio = new System.Windows.Forms.NumericUpDown();
            this.ckbPerda = new System.Windows.Forms.CheckBox();
            this.ckbGanho = new System.Windows.Forms.CheckBox();
            this.ckbSono = new System.Windows.Forms.CheckBox();
            this.ckbHidratacao = new System.Windows.Forms.CheckBox();
            this.ckbHabitos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoAtual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoDesejado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExercicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Metas Pessoais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(235, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Objetivo de Hidratação:";
            // 
            // txbHidratacao
            // 
            this.txbHidratacao.Location = new System.Drawing.Point(265, 88);
            this.txbHidratacao.Name = "txbHidratacao";
            this.txbHidratacao.Size = new System.Drawing.Size(152, 20);
            this.txbHidratacao.TabIndex = 6;
            this.txbHidratacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHidratacao_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kcals";
            // 
            // txbCalorias
            // 
            this.txbCalorias.Location = new System.Drawing.Point(265, 133);
            this.txbCalorias.Name = "txbCalorias";
            this.txbCalorias.Size = new System.Drawing.Size(152, 20);
            this.txbCalorias.TabIndex = 9;
            this.txbCalorias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCalorias_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Objetivo de Consumo Calórico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Meta de Tempo de Exercício:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(252, 451);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightPink;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(333, 451);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudPesoAtual
            // 
            this.nudPesoAtual.Location = new System.Drawing.Point(266, 218);
            this.nudPesoAtual.Name = "nudPesoAtual";
            this.nudPesoAtual.Size = new System.Drawing.Size(152, 20);
            this.nudPesoAtual.TabIndex = 19;
            this.nudPesoAtual.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Peso Atual:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "KG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "KG";
            // 
            // nudPesoDesejado
            // 
            this.nudPesoDesejado.Location = new System.Drawing.Point(265, 260);
            this.nudPesoDesejado.Name = "nudPesoDesejado";
            this.nudPesoDesejado.Size = new System.Drawing.Size(152, 20);
            this.nudPesoDesejado.TabIndex = 22;
            this.nudPesoDesejado.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(263, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Peso Desejado:";
            // 
            // nudExercicio
            // 
            this.nudExercicio.Location = new System.Drawing.Point(266, 178);
            this.nudExercicio.Name = "nudExercicio";
            this.nudExercicio.Size = new System.Drawing.Size(152, 20);
            this.nudExercicio.TabIndex = 24;
            this.nudExercicio.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ckbPerda
            // 
            this.ckbPerda.AutoSize = true;
            this.ckbPerda.BackColor = System.Drawing.SystemColors.Control;
            this.ckbPerda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbPerda.ForeColor = System.Drawing.Color.Black;
            this.ckbPerda.Location = new System.Drawing.Point(19, 24);
            this.ckbPerda.Name = "ckbPerda";
            this.ckbPerda.Size = new System.Drawing.Size(95, 17);
            this.ckbPerda.TabIndex = 26;
            this.ckbPerda.Text = "Perda de peso";
            this.ckbPerda.UseVisualStyleBackColor = false;
            this.ckbPerda.CheckedChanged += new System.EventHandler(this.ckbPerda_CheckedChanged);
            // 
            // ckbGanho
            // 
            this.ckbGanho.AutoSize = true;
            this.ckbGanho.BackColor = System.Drawing.SystemColors.Control;
            this.ckbGanho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbGanho.ForeColor = System.Drawing.Color.Black;
            this.ckbGanho.Location = new System.Drawing.Point(19, 47);
            this.ckbGanho.Name = "ckbGanho";
            this.ckbGanho.Size = new System.Drawing.Size(99, 17);
            this.ckbGanho.TabIndex = 27;
            this.ckbGanho.Text = "Ganho de peso";
            this.ckbGanho.UseVisualStyleBackColor = false;
            this.ckbGanho.CheckedChanged += new System.EventHandler(this.ckbGanho_CheckedChanged);
            // 
            // ckbSono
            // 
            this.ckbSono.AutoSize = true;
            this.ckbSono.BackColor = System.Drawing.SystemColors.Control;
            this.ckbSono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbSono.ForeColor = System.Drawing.Color.Black;
            this.ckbSono.Location = new System.Drawing.Point(19, 70);
            this.ckbSono.Name = "ckbSono";
            this.ckbSono.Size = new System.Drawing.Size(105, 17);
            this.ckbSono.TabIndex = 28;
            this.ckbSono.Text = "Melhora do sono";
            this.ckbSono.UseVisualStyleBackColor = false;
            this.ckbSono.CheckedChanged += new System.EventHandler(this.ckbSono_CheckedChanged);
            // 
            // ckbHidratacao
            // 
            this.ckbHidratacao.AutoSize = true;
            this.ckbHidratacao.BackColor = System.Drawing.SystemColors.Control;
            this.ckbHidratacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHidratacao.ForeColor = System.Drawing.Color.Black;
            this.ckbHidratacao.Location = new System.Drawing.Point(19, 93);
            this.ckbHidratacao.Name = "ckbHidratacao";
            this.ckbHidratacao.Size = new System.Drawing.Size(134, 17);
            this.ckbHidratacao.TabIndex = 29;
            this.ckbHidratacao.Text = "Melhora da Hidratação";
            this.ckbHidratacao.UseVisualStyleBackColor = false;
            this.ckbHidratacao.CheckedChanged += new System.EventHandler(this.ckbHidratacao_CheckedChanged);
            // 
            // ckbHabitos
            // 
            this.ckbHabitos.AutoSize = true;
            this.ckbHabitos.BackColor = System.Drawing.SystemColors.Control;
            this.ckbHabitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbHabitos.ForeColor = System.Drawing.Color.Black;
            this.ckbHabitos.Location = new System.Drawing.Point(19, 117);
            this.ckbHabitos.Name = "ckbHabitos";
            this.ckbHabitos.Size = new System.Drawing.Size(172, 17);
            this.ckbHabitos.TabIndex = 30;
            this.ckbHabitos.Text = "Melhora de hábitos alimentares";
            this.ckbHabitos.UseVisualStyleBackColor = false;
            this.ckbHabitos.CheckedChanged += new System.EventHandler(this.ckbHabitos_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbHabitos);
            this.groupBox1.Controls.Add(this.ckbHidratacao);
            this.groupBox1.Controls.Add(this.ckbSono);
            this.groupBox1.Controls.Add(this.ckbGanho);
            this.groupBox1.Controls.Add(this.ckbPerda);
            this.groupBox1.Location = new System.Drawing.Point(232, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 143);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetivos";
            // 
            // frmObjetivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(704, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudExercicio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nudPesoDesejado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPesoAtual);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCalorias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbHidratacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmObjetivo";
            this.Text = ",";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoAtual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPesoDesejado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExercicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHidratacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbCalorias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudPesoAtual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudPesoDesejado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudExercicio;
        private System.Windows.Forms.CheckBox ckbPerda;
        private System.Windows.Forms.CheckBox ckbGanho;
        private System.Windows.Forms.CheckBox ckbSono;
        private System.Windows.Forms.CheckBox ckbHidratacao;
        private System.Windows.Forms.CheckBox ckbHabitos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}