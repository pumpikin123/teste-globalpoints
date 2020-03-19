namespace TesteGlobal
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.globallDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globallDataSet2 = new TesteGlobal.globallDataSet2();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.globallDataSet = new TesteGlobal.globallDataSet();
            this.globallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new TesteGlobal.globallDataSetTableAdapters.produtosTableAdapter();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter1 = new TesteGlobal.globallDataSet2TableAdapters.produtosTableAdapter();
            this.codprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(321, 132);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(78, 25);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(110, 135);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(140, 20);
            this.txtVal.TabIndex = 9;
            this.txtVal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVal_KeyPress);
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(110, 107);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(140, 20);
            this.txtProd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome Produto: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codprodDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.produtosBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 145);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "produtos";
            this.produtosBindingSource2.DataSource = this.globallDataSet2BindingSource;
            // 
            // globallDataSet2BindingSource
            // 
            this.globallDataSet2BindingSource.DataSource = this.globallDataSet2;
            this.globallDataSet2BindingSource.Position = 0;
            // 
            // globallDataSet2
            // 
            this.globallDataSet2.DataSetName = "globallDataSet2";
            this.globallDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // globallDataSet
            // 
            this.globallDataSet.DataSetName = "globallDataSet";
            this.globallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // globallDataSetBindingSource
            // 
            this.globallDataSetBindingSource.DataSource = this.globallDataSet;
            this.globallDataSetBindingSource.Position = 0;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.globallDataSetBindingSource;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            this.produtosBindingSource1.DataSource = this.globallDataSetBindingSource;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // codprodDataGridViewTextBoxColumn
            // 
            this.codprodDataGridViewTextBoxColumn.DataPropertyName = "cod_prod";
            this.codprodDataGridViewTextBoxColumn.HeaderText = "cod";
            this.codprodDataGridViewTextBoxColumn.Name = "codprodDataGridViewTextBoxColumn";
            this.codprodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cadastro";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.BindingSource globallDataSetBindingSource;
        private globallDataSet globallDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private globallDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource globallDataSet2BindingSource;
        private globallDataSet2 globallDataSet2;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private globallDataSet2TableAdapters.produtosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}

