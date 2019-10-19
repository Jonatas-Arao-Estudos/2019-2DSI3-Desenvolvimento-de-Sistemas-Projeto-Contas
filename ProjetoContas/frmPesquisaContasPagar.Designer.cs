namespace ProjetoContas
{
    partial class frmPesquisaContasPagar
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
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tbContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContasPagarTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tbContasPagarTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.tbContasPagarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbContasPagarBindingSource
            // 
            this.tbContasPagarBindingSource.DataMember = "tbContasPagar";
            this.tbContasPagarBindingSource.DataSource = this.contasDataSet;
            // 
            // tbContasPagarTableAdapter
            // 
            this.tbContasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbContasPagarTableAdapter = this.tbContasPagarTableAdapter;
            this.tableAdapterManager.tbContasReceberTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbContasPagarDataGridView
            // 
            this.tbContasPagarDataGridView.AllowUserToAddRows = false;
            this.tbContasPagarDataGridView.AllowUserToDeleteRows = false;
            this.tbContasPagarDataGridView.AutoGenerateColumns = false;
            this.tbContasPagarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbContasPagarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.tbContasPagarDataGridView.DataSource = this.tbContasPagarBindingSource;
            this.tbContasPagarDataGridView.Location = new System.Drawing.Point(214, 98);
            this.tbContasPagarDataGridView.Name = "tbContasPagarDataGridView";
            this.tbContasPagarDataGridView.ReadOnly = true;
            this.tbContasPagarDataGridView.Size = new System.Drawing.Size(316, 220);
            this.tbContasPagarDataGridView.TabIndex = 24;
            this.tbContasPagarDataGridView.DoubleClick += new System.EventHandler(this.tbContasPagarDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_conta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_fornecedor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código do Fornecedor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "vl_conta";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Código do Fornecedor";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(275, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(407, 40);
            this.txtCodigo.TabIndex = 33;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(311, 334);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 42);
            this.btnSair.TabIndex = 32;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPesquisaContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 405);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tbContasPagarDataGridView);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPesquisaContasPagar";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmPesquisaContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbContasPagarBindingSource;
        private contasDataSetTableAdapters.tbContasPagarTableAdapter tbContasPagarTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbContasPagarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSair;
    }
}