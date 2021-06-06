namespace ProjetoPSI16AFJS
{
    partial class Inserir_Filme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inserir_Filme));
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtLugaresDisponiveis = new System.Windows.Forms.TextBox();
            this.lblFilme = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(89, 32);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(221, 20);
            this.txtFilme.TabIndex = 0;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(55, 64);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(34, 20);
            this.txtSala.TabIndex = 1;
            // 
            // txtLugaresDisponiveis
            // 
            this.txtLugaresDisponiveis.Location = new System.Drawing.Point(122, 96);
            this.txtLugaresDisponiveis.Name = "txtLugaresDisponiveis";
            this.txtLugaresDisponiveis.Size = new System.Drawing.Size(25, 20);
            this.txtLugaresDisponiveis.TabIndex = 2;
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(11, 35);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(78, 13);
            this.lblFilme.TabIndex = 3;
            this.lblFilme.Text = "Titulo do Filme:";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(24, 67);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Sala:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lugares Disponiveis:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 143);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 48);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Inserir_Filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(314, 213);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblFilme);
            this.Controls.Add(this.txtLugaresDisponiveis);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.txtFilme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inserir_Filme";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inserir Filme";
            this.Load += new System.EventHandler(this.Inserir_Filme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtLugaresDisponiveis;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}