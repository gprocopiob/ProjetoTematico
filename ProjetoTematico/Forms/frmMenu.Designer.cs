namespace NutriFlow.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnExercicios = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.pnlBotoes.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.pnlBotoes.Controls.Add(this.btnExercicios);
            this.pnlBotoes.Controls.Add(this.panelTitle);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(181, 495);
            this.pnlBotoes.TabIndex = 5;
            // 
            // btnExercicios
            // 
            this.btnExercicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnExercicios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExercicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExercicios.FlatAppearance.BorderSize = 0;
            this.btnExercicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.btnExercicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnExercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercicios.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExercicios.ForeColor = System.Drawing.Color.White;
            this.btnExercicios.Image = ((System.Drawing.Image)(resources.GetObject("btnExercicios.Image")));
            this.btnExercicios.Location = new System.Drawing.Point(0, 34);
            this.btnExercicios.Name = "btnExercicios";
            this.btnExercicios.Size = new System.Drawing.Size(181, 52);
            this.btnExercicios.TabIndex = 2;
            this.btnExercicios.Text = "  EXERCÍCIOS";
            this.btnExercicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExercicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExercicios.UseVisualStyleBackColor = false;
            this.btnExercicios.Click += new System.EventHandler(this.btnExercicios_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelTitle.Controls.Add(this.pbxMenu);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(181, 34);
            this.panelTitle.TabIndex = 0;
            // 
            // pbxMenu
            // 
            this.pbxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenu.Image")));
            this.pbxMenu.Location = new System.Drawing.Point(8, 9);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(31, 24);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu.TabIndex = 0;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(181, 0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(704, 495);
            this.pnlForms.TabIndex = 6;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(885, 495);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlBotoes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NutriFlow";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlBotoes.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.Button btnExercicios;
    }
}