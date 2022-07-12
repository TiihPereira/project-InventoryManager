namespace InventoryManager.Forms
{
    partial class Frm_Pecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Pecas));
            this.pb_Pecas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarCNPJ = new System.Windows.Forms.Button();
            this.btn_BuscarTodos = new System.Windows.Forms.Button();
            this.btn_Apagar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Quantidade = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Quantidade = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.txt_IdFornecedor = new System.Windows.Forms.TextBox();
            this.txt_ValorRevenda = new System.Windows.Forms.TextBox();
            this.txt_ValorCompra = new System.Windows.Forms.TextBox();
            this.lbl_ValorRevenda = new System.Windows.Forms.Label();
            this.lbl_IdFornecedor = new System.Windows.Forms.Label();
            this.lbl_ValorCompra = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorRevendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pecasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Pecas
            // 
            this.pb_Pecas.BackColor = System.Drawing.Color.White;
            this.pb_Pecas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Pecas.Image = global::InventoryManager.Properties.Resources.Pecas;
            this.pb_Pecas.Location = new System.Drawing.Point(207, 30);
            this.pb_Pecas.Name = "pb_Pecas";
            this.pb_Pecas.Size = new System.Drawing.Size(141, 127);
            this.pb_Pecas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Pecas.TabIndex = 0;
            this.pb_Pecas.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(397, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Cadastro de Peças";
            // 
            // btn_BuscarCNPJ
            // 
            this.btn_BuscarCNPJ.BackColor = System.Drawing.Color.White;
            this.btn_BuscarCNPJ.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarCNPJ.Location = new System.Drawing.Point(576, 133);
            this.btn_BuscarCNPJ.Name = "btn_BuscarCNPJ";
            this.btn_BuscarCNPJ.Size = new System.Drawing.Size(177, 44);
            this.btn_BuscarCNPJ.TabIndex = 25;
            this.btn_BuscarCNPJ.Text = "Buscar p/ Codigo";
            this.btn_BuscarCNPJ.UseVisualStyleBackColor = false;
            this.btn_BuscarCNPJ.Click += new System.EventHandler(this.btn_BuscarCNPJ_Click);
            // 
            // btn_BuscarTodos
            // 
            this.btn_BuscarTodos.BackColor = System.Drawing.Color.White;
            this.btn_BuscarTodos.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BuscarTodos.Location = new System.Drawing.Point(378, 133);
            this.btn_BuscarTodos.Name = "btn_BuscarTodos";
            this.btn_BuscarTodos.Size = new System.Drawing.Size(177, 44);
            this.btn_BuscarTodos.TabIndex = 24;
            this.btn_BuscarTodos.Text = "Buscar Todos";
            this.btn_BuscarTodos.UseVisualStyleBackColor = false;
            this.btn_BuscarTodos.Click += new System.EventHandler(this.btn_BuscarTodos_Click);
            // 
            // btn_Apagar
            // 
            this.btn_Apagar.BackColor = System.Drawing.Color.White;
            this.btn_Apagar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Apagar.Location = new System.Drawing.Point(645, 69);
            this.btn_Apagar.Name = "btn_Apagar";
            this.btn_Apagar.Size = new System.Drawing.Size(108, 44);
            this.btn_Apagar.TabIndex = 23;
            this.btn_Apagar.Text = "Apagar";
            this.btn_Apagar.UseVisualStyleBackColor = false;
            this.btn_Apagar.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.White;
            this.btn_Editar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.Location = new System.Drawing.Point(517, 69);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(108, 44);
            this.btn_Editar.TabIndex = 22;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(378, 69);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 44);
            this.btn_Add.TabIndex = 21;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Quantidade
            // 
            this.txt_Quantidade.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Quantidade.Location = new System.Drawing.Point(378, 398);
            this.txt_Quantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Quantidade.Name = "txt_Quantidade";
            this.txt_Quantidade.Size = new System.Drawing.Size(375, 26);
            this.txt_Quantidade.TabIndex = 36;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Marca.Location = new System.Drawing.Point(378, 320);
            this.txt_Marca.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(375, 26);
            this.txt_Marca.TabIndex = 35;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Descricao.Location = new System.Drawing.Point(378, 282);
            this.txt_Descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(375, 26);
            this.txt_Descricao.TabIndex = 34;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Nome.Location = new System.Drawing.Point(378, 241);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(375, 26);
            this.txt_Nome.TabIndex = 33;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Codigo.Location = new System.Drawing.Point(378, 198);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(375, 26);
            this.txt_Codigo.TabIndex = 32;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Nome.Location = new System.Drawing.Point(217, 247);
            this.lbl_Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_Nome.TabIndex = 31;
            this.lbl_Nome.Text = "Nome";
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.AutoSize = true;
            this.lbl_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Descricao.Location = new System.Drawing.Point(217, 288);
            this.lbl_Descricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(89, 20);
            this.lbl_Descricao.TabIndex = 30;
            this.lbl_Descricao.Text = "Descrição";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Modelo.Location = new System.Drawing.Point(217, 326);
            this.lbl_Modelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(58, 20);
            this.lbl_Modelo.TabIndex = 29;
            this.lbl_Modelo.Text = "Marca";
            // 
            // lbl_Quantidade
            // 
            this.lbl_Quantidade.AutoSize = true;
            this.lbl_Quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Quantidade.Location = new System.Drawing.Point(217, 404);
            this.lbl_Quantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Quantidade.Name = "lbl_Quantidade";
            this.lbl_Quantidade.Size = new System.Drawing.Size(102, 20);
            this.lbl_Quantidade.TabIndex = 28;
            this.lbl_Quantidade.Text = "Quantidade";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.AutoSize = true;
            this.lbl_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Codigo.Location = new System.Drawing.Point(217, 204);
            this.lbl_Codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(65, 20);
            this.lbl_Codigo.TabIndex = 27;
            this.lbl_Codigo.Text = "Codigo";
            // 
            // txt_IdFornecedor
            // 
            this.txt_IdFornecedor.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_IdFornecedor.Location = new System.Drawing.Point(378, 521);
            this.txt_IdFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdFornecedor.Name = "txt_IdFornecedor";
            this.txt_IdFornecedor.Size = new System.Drawing.Size(375, 26);
            this.txt_IdFornecedor.TabIndex = 44;
            // 
            // txt_ValorRevenda
            // 
            this.txt_ValorRevenda.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ValorRevenda.Location = new System.Drawing.Point(378, 480);
            this.txt_ValorRevenda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValorRevenda.Name = "txt_ValorRevenda";
            this.txt_ValorRevenda.Size = new System.Drawing.Size(375, 26);
            this.txt_ValorRevenda.TabIndex = 43;
            // 
            // txt_ValorCompra
            // 
            this.txt_ValorCompra.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ValorCompra.Location = new System.Drawing.Point(378, 437);
            this.txt_ValorCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ValorCompra.Name = "txt_ValorCompra";
            this.txt_ValorCompra.Size = new System.Drawing.Size(375, 26);
            this.txt_ValorCompra.TabIndex = 42;
            // 
            // lbl_ValorRevenda
            // 
            this.lbl_ValorRevenda.AutoSize = true;
            this.lbl_ValorRevenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorRevenda.Location = new System.Drawing.Point(217, 486);
            this.lbl_ValorRevenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValorRevenda.Name = "lbl_ValorRevenda";
            this.lbl_ValorRevenda.Size = new System.Drawing.Size(152, 20);
            this.lbl_ValorRevenda.TabIndex = 41;
            this.lbl_ValorRevenda.Text = "Valor de Revenda";
            // 
            // lbl_IdFornecedor
            // 
            this.lbl_IdFornecedor.AutoSize = true;
            this.lbl_IdFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_IdFornecedor.Location = new System.Drawing.Point(217, 527);
            this.lbl_IdFornecedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdFornecedor.Name = "lbl_IdFornecedor";
            this.lbl_IdFornecedor.Size = new System.Drawing.Size(125, 20);
            this.lbl_IdFornecedor.TabIndex = 40;
            this.lbl_IdFornecedor.Text = "ID Fornecedor";
            // 
            // lbl_ValorCompra
            // 
            this.lbl_ValorCompra.AutoSize = true;
            this.lbl_ValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ValorCompra.Location = new System.Drawing.Point(217, 443);
            this.lbl_ValorCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ValorCompra.Name = "lbl_ValorCompra";
            this.lbl_ValorCompra.Size = new System.Drawing.Size(143, 20);
            this.lbl_ValorCompra.TabIndex = 37;
            this.lbl_ValorCompra.Text = "Valor da Compra";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.valorCompraDataGridViewTextBoxColumn,
            this.valorRevendaDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pecasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 563);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(928, 280);
            this.dataGridView1.TabIndex = 46;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // valorCompraDataGridViewTextBoxColumn
            // 
            this.valorCompraDataGridViewTextBoxColumn.DataPropertyName = "ValorCompra";
            this.valorCompraDataGridViewTextBoxColumn.HeaderText = "ValorCompra";
            this.valorCompraDataGridViewTextBoxColumn.Name = "valorCompraDataGridViewTextBoxColumn";
            // 
            // valorRevendaDataGridViewTextBoxColumn
            // 
            this.valorRevendaDataGridViewTextBoxColumn.DataPropertyName = "ValorRevenda";
            this.valorRevendaDataGridViewTextBoxColumn.HeaderText = "ValorRevenda";
            this.valorRevendaDataGridViewTextBoxColumn.Name = "valorRevendaDataGridViewTextBoxColumn";
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "IdFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            // 
            // pecasBindingSource
            // 
            this.pecasBindingSource.DataSource = typeof(InventoryManager.Classes.Pecas);
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Modelo.Location = new System.Drawing.Point(378, 357);
            this.txt_Modelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(375, 26);
            this.txt_Modelo.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(217, 363);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Modelo";
            // 
            // Frm_Pecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(973, 855);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IdFornecedor);
            this.Controls.Add(this.txt_ValorRevenda);
            this.Controls.Add(this.txt_ValorCompra);
            this.Controls.Add(this.lbl_ValorRevenda);
            this.Controls.Add(this.lbl_IdFornecedor);
            this.Controls.Add(this.lbl_ValorCompra);
            this.Controls.Add(this.txt_Quantidade);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Descricao);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.lbl_Quantidade);
            this.Controls.Add(this.lbl_Codigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarCNPJ);
            this.Controls.Add(this.btn_BuscarTodos);
            this.Controls.Add(this.btn_Apagar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.pb_Pecas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Pecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Peças";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Pecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_Pecas;
        private Label label1;
        private Button btn_BuscarCNPJ;
        private Button btn_BuscarTodos;
        private Button btn_Apagar;
        private Button btn_Editar;
        private Button btn_Add;
        private TextBox txt_Quantidade;
        private TextBox txt_Marca;
        private TextBox txt_Descricao;
        private TextBox txt_Nome;
        private TextBox txt_Codigo;
        private Label lbl_Nome;
        private Label lbl_Descricao;
        private Label lbl_Modelo;
        private Label lbl_Quantidade;
        private Label lbl_Codigo;
        private TextBox txt_IdFornecedor;
        private TextBox txt_ValorRevenda;
        private TextBox txt_ValorCompra;
        private Label lbl_ValorRevenda;
        private Label lbl_IdFornecedor;
        private Label lbl_ValorCompra;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorCompraDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorRevendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private BindingSource pecasBindingSource;
        private TextBox txt_Modelo;
        private Label label2;
    }
}