namespace ProjetoContas
{
    partial class frmPesquisaContasReceber
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
            this.tbContasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContasReceberTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tbContasReceberTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.tbContasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasReceberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbContasReceberBindingSource
            // 
            this.tbContasReceberBindingSource.DataMember = "tbContasReceber";
            this.tbContasReceberBindingSource.DataSource = this.contasDataSet;
            // 
            // tbContasReceberTableAdapter
            // 
            this.tbContasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbContasPagarTableAdapter = null;
            this.tableAdapterManager.tbContasReceberTableAdapter = this.tbContasReceberTableAdapter;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbContasReceberDataGridView
            // 
            this.tbContasReceberDataGridView.AllowUserToAddRows = false;
            this.tbContasReceberDataGridView.AllowUserToDeleteRows = false;
            this.tbContasReceberDataGridView.AutoGenerateColumns = false;
            this.tbContasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbContasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.tbContasReceberDataGridView.DataSource = this.tbContasReceberBindingSource;
            this.tbContasReceberDataGridView.Location = new System.Drawing.Point(183, 93);
            this.tbContasReceberDataGridView.Name = "tbContasReceberDataGridView";
            this.tbContasReceberDataGridView.ReadOnly = true;
            this.tbContasReceberDataGridView.Size = new System.Drawing.Size(316, 220);
            this.tbContasReceberDataGridView.TabIndex = 32;
            this.tbContasReceberDataGridView.DoubleClick += new System.EventHandler(this.tbContasReceberDataGridView_DoubleClick);
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_cliente";
            this.dataGridViewTextBoxColumn5.HeaderText = "Código do Cliente";
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
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Código do Cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(230, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(407, 40);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(283, 331);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 42);
            this.btnSair.TabIndex = 29;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmPesquisaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 405);
            this.Controls.Add(this.tbContasReceberDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPesquisaContasReceber";
            this.Text = "frmPesquisaContasReceber";
            this.Load += new System.EventHandler(this.frmPesquisaContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasReceberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbContasReceberBindingSource;
        private contasDataSetTableAdapters.tbContasReceberTableAdapter tbContasReceberTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbContasReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnSair;
    }
}