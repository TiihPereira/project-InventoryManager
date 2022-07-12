namespace InventoryManager.Forms
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pb_Pecas = new System.Windows.Forms.PictureBox();
            this.pb_Fornecedores = new System.Windows.Forms.PictureBox();
            this.btn_Pecas = new System.Windows.Forms.Button();
            this.btn_Forncedores = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Titulo);
            this.panel1.Location = new System.Drawing.Point(21, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 119);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Lucida Sans Unicode", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Titulo.Location = new System.Drawing.Point(220, 37);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(348, 42);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Inventory Manager";
            // 
            // pb_Pecas
            // 
            this.pb_Pecas.BackColor = System.Drawing.Color.White;
            this.pb_Pecas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Pecas.Image = ((System.Drawing.Image)(resources.GetObject("pb_Pecas.Image")));
            this.pb_Pecas.Location = new System.Drawing.Point(66, 152);
            this.pb_Pecas.Name = "pb_Pecas";
            this.pb_Pecas.Size = new System.Drawing.Size(276, 197);
            this.pb_Pecas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Pecas.TabIndex = 2;
            this.pb_Pecas.TabStop = false;
            // 
            // pb_Fornecedores
            // 
            this.pb_Fornecedores.BackColor = System.Drawing.Color.White;
            this.pb_Fornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Fornecedores.Image = ((System.Drawing.Image)(resources.GetObject("pb_Fornecedores.Image")));
            this.pb_Fornecedores.Location = new System.Drawing.Point(480, 152);
            this.pb_Fornecedores.Name = "pb_Fornecedores";
            this.pb_Fornecedores.Size = new System.Drawing.Size(276, 197);
            this.pb_Fornecedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Fornecedores.TabIndex = 3;
            this.pb_Fornecedores.TabStop = false;
            // 
            // btn_Pecas
            // 
            this.btn_Pecas.BackColor = System.Drawing.Color.White;
            this.btn_Pecas.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Pecas.Location = new System.Drawing.Point(122, 365);
            this.btn_Pecas.Name = "btn_Pecas";
            this.btn_Pecas.Size = new System.Drawing.Size(155, 57);
            this.btn_Pecas.TabIndex = 5;
            this.btn_Pecas.Text = "Peças";
            this.btn_Pecas.UseVisualStyleBackColor = false;
            this.btn_Pecas.Click += new System.EventHandler(this.btn_Pecas_Click);
            // 
            // btn_Forncedores
            // 
            this.btn_Forncedores.BackColor = System.Drawing.Color.White;
            this.btn_Forncedores.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Forncedores.Location = new System.Drawing.Point(545, 365);
            this.btn_Forncedores.Name = "btn_Forncedores";
            this.btn_Forncedores.Size = new System.Drawing.Size(155, 57);
            this.btn_Forncedores.TabIndex = 6;
            this.btn_Forncedores.Text = "Fornecedores";
            this.btn_Forncedores.UseVisualStyleBackColor = false;
            this.btn_Forncedores.Click += new System.EventHandler(this.btn_Forncedores_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sair.Location = new System.Drawing.Point(332, 439);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(155, 57);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(825, 508);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Forncedores);
            this.Controls.Add(this.btn_Pecas);
            this.Controls.Add(this.pb_Fornecedores);
            this.Controls.Add(this.pb_Pecas);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Fornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label lbl_Titulo;
        private PictureBox pb_Pecas;
        private PictureBox pb_Fornecedores;
        private Button btn_Pecas;
        private Button btn_Forncedores;
        private Button btn_Sair;
    }
}