namespace ProjetoContas
{
    partial class frmPesquisaFornecedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tbFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFornecedorTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tbFornecedorTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.tbFornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(112, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 40);
            this.txtNome.TabIndex = 10;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(226, 331);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 42);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbFornecedorBindingSource
            // 
            this.tbFornecedorBindingSource.DataMember = "tbFornecedor";
            this.tbFornecedorBindingSource.DataSource = this.contasDataSet;
            // 
            // tbFornecedorTableAdapter
            // 
            this.tbFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbContasPagarTableAdapter = null;
            this.tableAdapterManager.tbContasReceberTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = this.tbFornecedorTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbFornecedorDataGridView
            // 
            this.tbFornecedorDataGridView.AllowUserToAddRows = false;
            this.tbFornecedorDataGridView.AllowUserToDeleteRows = false;
            this.tbFornecedorDataGridView.AutoGenerateColumns = false;
            this.tbFornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbFornecedorDataGridView.DataSource = this.tbFornecedorBindingSource;
            this.tbFornecedorDataGridView.Location = new System.Drawing.Point(66, 94);
            this.tbFornecedorDataGridView.Name = "tbFornecedorDataGridView";
            this.tbFornecedorDataGridView.ReadOnly = true;
            this.tbFornecedorDataGridView.Size = new System.Drawing.Size(417, 220);
            this.tbFornecedorDataGridView.TabIndex = 12;
            this.tbFornecedorDataGridView.DoubleClick += new System.EventHandler(this.tbFornecedorDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_fornecedor";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_fornecedor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // frmPesquisaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 405);
            this.ControlBox = false;
            this.Controls.Add(this.tbFornecedorDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPesquisaFornecedor";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmPesquisaFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFornecedorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSair;
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbFornecedorBindingSource;
        private contasDataSetTableAdapters.tbFornecedorTableAdapter tbFornecedorTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbFornecedorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}