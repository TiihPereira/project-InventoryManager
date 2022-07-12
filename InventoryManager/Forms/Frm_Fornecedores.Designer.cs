namespace InventoryManager.Forms
{
    partial class Frm_Fornecedores
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fornecedores));
            this.pc_Fornecedores = new System.Windows.Forms.PictureBox();
            this.lbl_RazaoSocial = new System.Windows.Forms.Label();
            this.lbl_Endereco = new System.Windows.Forms.Label();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_CNPJ = new System.Windows.Forms.Label();
            this.txt_RazaoSocial = new System.Windows.Forms.TextBox();
            this.txt_CNPJ = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_BuscarTodos = new System.Windows.Forms.Button();
            this.btn_BuscarCNPJ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Fornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_Fornecedores
            // 
            this.pc_Fornecedores.BackColor = System.Drawing.Color.White;
            this.pc_Fornecedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pc_Fornecedores.Image = global::InventoryManager.Properties.Resources.Fornecedor;
            this.pc_Fornecedores.Location = new System.Drawing.Point(31, 26);
            this.pc_Fornecedores.Margin = new System.Windows.Forms.Padding(4);
            this.pc_Fornecedores.Name = "pc_Fornecedores";
            this.pc_Fornecedores.Size = new System.Drawing.Size(141, 127);
            this.pc_Fornecedores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_Fornecedores.TabIndex = 0;
            this.pc_Fornecedores.TabStop = false;
            // 
            // lbl_RazaoSocial
            // 
            this.lbl_RazaoSocial.AutoSize = true;
            this.lbl_RazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_RazaoSocial.Location = new System.Drawing.Point(32, 215);
            this.lbl_RazaoSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RazaoSocial.Name = "lbl_RazaoSocial";
            this.lbl_RazaoSocial.Size = new System.Drawing.Size(115, 20);
            this.lbl_RazaoSocial.TabIndex = 3;
            this.lbl_RazaoSocial.Text = "Razão Social";
            // 
            // lbl_Endereco
            // 
            this.lbl_Endereco.AutoSize = true;
            this.lbl_Endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Endereco.Location = new System.Drawing.Point(32, 380);
            this.lbl_Endereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Endereco.Name = "lbl_Endereco";
            this.lbl_Endereco.Size = new System.Drawing.Size(86, 20);
            this.lbl_Endereco.TabIndex = 4;
            this.lbl_Endereco.Text = "Endereço";
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Telefone.Location = new System.Drawing.Point(31, 337);
            this.lbl_Telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(79, 20);
            this.lbl_Telefone.TabIndex = 5;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Email.Location = new System.Drawing.Point(32, 299);
            this.lbl_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(53, 20);
            this.lbl_Email.TabIndex = 6;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_CNPJ
            // 
            this.lbl_CNPJ.AutoSize = true;
            this.lbl_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CNPJ.Location = new System.Drawing.Point(32, 258);
            this.lbl_CNPJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CNPJ.Name = "lbl_CNPJ";
            this.lbl_CNPJ.Size = new System.Drawing.Size(53, 20);
            this.lbl_CNPJ.TabIndex = 7;
            this.lbl_CNPJ.Text = "CNPJ";
            // 
            // txt_RazaoSocial
            // 
            this.txt_RazaoSocial.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_RazaoSocial.Location = new System.Drawing.Point(210, 208);
            this.txt_RazaoSocial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_RazaoSocial.Name = "txt_RazaoSocial";
            this.txt_RazaoSocial.Size = new System.Drawing.Size(375, 27);
            this.txt_RazaoSocial.TabIndex = 8;
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_CNPJ.Location = new System.Drawing.Point(210, 251);
            this.txt_CNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(375, 27);
            this.txt_CNPJ.TabIndex = 9;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Email.Location = new System.Drawing.Point(210, 292);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(375, 27);
            this.txt_Email.TabIndex = 10;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Telefone.Location = new System.Drawing.Point(210, 330);
            this.txt_Telefone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(375, 27);
            this.txt_Telefone.TabIndex = 11;
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Endereco.Location = new System.Drawing.Point(210, 373);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(375, 27);
            this.txt_Endereco.TabIndex = 12;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(210, 65);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 44);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(349, 65);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(108, 44);
            this.btn_Editar.TabIndex = 16;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.BackColor = System.Drawing.Color.White;
            this.btn_Apagar.Location = new System.Drawing.Point(477, 65);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(108, 44);
            this.btn_Apagar.TabIndex = 17;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = false;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_BuscarTodos
            // 
            this.btn_BuscarTodos.BackColor = System.Drawing.Color.White;
            this.btn_BuscarTodos.Location = new System.Drawing.Point(210, 129);
            this.btn_BuscarTodos.Name = "btn_BuscarTodos";
            this.btn_BuscarTodos.Size = new System.Drawing.Size(177, 44);
            this.btn_BuscarTodos.TabIndex = 18;
            this.btn_BuscarTodos.Text = "Buscar Todos";
            this.btn_BuscarTodos.UseVisualStyleBackColor = false;
            this.btn_BuscarTodos.Click += new System.EventHandler(this.btn_BuscarTodos_Click);
            // 
            // btn_BuscarCNPJ
            // 
            this.btn_BuscarCNPJ.BackColor = System.Drawing.Color.White;
            this.btn_BuscarCNPJ.Location = new System.Drawing.Point(408, 129);
            this.btn_BuscarCNPJ.Name = "btn_BuscarCNPJ";
            this.btn_BuscarCNPJ.Size = new System.Drawing.Size(177, 44);
            this.btn_BuscarCNPJ.TabIndex = 19;
            this.btn_BuscarCNPJ.Text = "Buscar por CNPJ";
            this.btn_BuscarCNPJ.UseVisualStyleBackColor = false;
            this.btn_BuscarCNPJ.Click += new System.EventHandler(this.btn_BuscarCNPJ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataSource = typeof(InventoryManager.Classes.Fornecedores);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.razaoSocialDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedoresBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 420);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(669, 239);
            this.dataGridView1.TabIndex = 21;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // fornecedoresBindingSource1
            // 
            this.fornecedoresBindingSource1.DataSource = typeof(InventoryManager.Classes.Fornecedores);
            // 
            // Frm_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(694, 671);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarCNPJ);
            this.Controls.Add(this.btn_BuscarTodos);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_CNPJ);
            this.Controls.Add(this.txt_RazaoSocial);
            this.Controls.Add(this.lbl_CNPJ);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.lbl_Endereco);
            this.Controls.Add(this.lbl_RazaoSocial);
            this.Controls.Add(this.pc_Fornecedores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.pc_Fornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pc_Fornecedores;
        private Label lbl_RazaoSocial;
        private Label lbl_Endereco;
        private Label lbl_Telefone;
        private Label lbl_Email;
        private Label lbl_CNPJ;
        private TextBox txt_RazaoSocial;
        private TextBox txt_CNPJ;
        private TextBox txt_Email;
        private TextBox txt_Telefone;
        private TextBox txt_Endereco;
        private Button btn_Add;
        private Button btn_Editar;
        private Button btn_Apagar;
        private Button btn_BuscarTodos;
        private Button btn_BuscarCNPJ;
        private Label label1;
        private BindingSource fornecedoresBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private BindingSource fornecedoresBindingSource1;
    }
}