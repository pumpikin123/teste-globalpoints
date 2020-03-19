namespace TesteGlobal
{
    partial class Consulta
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.gdTabela = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.globallDataSet = new TesteGlobal.globallDataSet();
            this.btnBusc = new System.Windows.Forms.Button();
            this.globallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new TesteGlobal.globallDataSetTableAdapters.produtosTableAdapter();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.globallDataSet1 = new TesteGlobal.globallDataSet1();
            this.produtosTableAdapter1 = new TesteGlobal.globallDataSet1TableAdapters.produtosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdTabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(291, 134);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Incluir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gdTabela
            // 
            this.gdTabela.AllowUserToDeleteRows = false;
            this.gdTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Quantidade,
            this.Valor});
            this.gdTabela.Location = new System.Drawing.Point(23, 162);
            this.gdTabela.Name = "gdTabela";
            this.gdTabela.ReadOnly = true;
            this.gdTabela.Size = new System.Drawing.Size(343, 164);
            this.gdTabela.TabIndex = 30;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(26, 137);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(90, 20);
            this.txtValor.TabIndex = 28;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(60, 314);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 27;
            // 
            // btnFim
            // 
            this.btnFim.Location = new System.Drawing.Point(234, 338);
            this.btnFim.Name = "btnFim";
            this.btnFim.Size = new System.Drawing.Size(132, 23);
            this.btnFim.TabIndex = 26;
            this.btnFim.Text = "Finalizar compra";
            this.btnFim.UseVisualStyleBackColor = true;
            this.btnFim.Click += new System.EventHandler(this.btnFim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Total:";
            // 
            // txtQuant
            // 
            this.txtQuant.Location = new System.Drawing.Point(154, 136);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(90, 20);
            this.txtQuant.TabIndex = 24;
            this.txtQuant.Leave += new System.EventHandler(this.txtQuant_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Produto:";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.globallDataSet;
            // 
            // globallDataSet
            // 
            this.globallDataSet.DataSetName = "globallDataSet";
            this.globallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnBusc
            // 
            this.btnBusc.Location = new System.Drawing.Point(291, 75);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(75, 23);
            this.btnBusc.TabIndex = 19;
            this.btnBusc.Text = "Buscar dados";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // globallDataSetBindingSource
            // 
            this.globallDataSetBindingSource.DataSource = this.globallDataSet;
            this.globallDataSetBindingSource.Position = 0;
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
            // produtosBindingSource2
            // 
            this.produtosBindingSource2.DataMember = "produtos";
            this.produtosBindingSource2.DataSource = this.globallDataSetBindingSource;
            // 
            // cmb1
            // 
            this.cmb1.DataSource = this.produtosBindingSource3;
            this.cmb1.DisplayMember = "nome";
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(26, 77);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(218, 21);
            this.cmb1.TabIndex = 33;
            this.cmb1.ValueMember = "valor";
            // 
            // produtosBindingSource3
            // 
            this.produtosBindingSource3.DataMember = "produtos";
            this.produtosBindingSource3.DataSource = this.globallDataSet1;
            // 
            // globallDataSet1
            // 
            this.globallDataSet1.DataSetName = "globallDataSet1";
            this.globallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter1
            // 
            this.produtosTableAdapter1.ClearBeforeFill = true;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 382);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gdTabela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBusc);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdTabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globallDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gdTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.BindingSource globallDataSetBindingSource;
        private globallDataSet globallDataSet;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private globallDataSetTableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
        private System.Windows.Forms.BindingSource produtosBindingSource2;
        private System.Windows.Forms.ComboBox cmb1;
        private globallDataSet1 globallDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource3;
        private globallDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter1;
    }
}