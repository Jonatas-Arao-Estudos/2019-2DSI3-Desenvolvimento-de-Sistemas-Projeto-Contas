namespace ProjetoContas
{
    partial class frmPesquisaUsuario
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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tbUsuarioTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.tbUsuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(226, 331);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(121, 42);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(112, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(407, 40);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.contasDataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbContasPagarTableAdapter = null;
            this.tableAdapterManager.tbContasReceberTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbUsuarioDataGridView
            // 
            this.tbUsuarioDataGridView.AllowUserToAddRows = false;
            this.tbUsuarioDataGridView.AllowUserToDeleteRows = false;
            this.tbUsuarioDataGridView.AutoGenerateColumns = false;
            this.tbUsuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbUsuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tbUsuarioDataGridView.DataSource = this.tbUsuarioBindingSource;
            this.tbUsuarioDataGridView.Location = new System.Drawing.Point(66, 94);
            this.tbUsuarioDataGridView.Name = "tbUsuarioDataGridView";
            this.tbUsuarioDataGridView.ReadOnly = true;
            this.tbUsuarioDataGridView.Size = new System.Drawing.Size(417, 220);
            this.tbUsuarioDataGridView.TabIndex = 4;
            this.tbUsuarioDataGridView.DoubleClick += new System.EventHandler(this.tbUsuarioDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // frmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 405);
            this.ControlBox = false;
            this.Controls.Add(this.tbUsuarioDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPesquisaUsuario";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FrmPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private contasDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tbUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}