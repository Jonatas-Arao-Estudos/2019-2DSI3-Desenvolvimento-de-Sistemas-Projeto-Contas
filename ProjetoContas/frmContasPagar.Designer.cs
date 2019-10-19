namespace ProjetoContas
{
    partial class frmContasPagar
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
            System.Windows.Forms.Label cd_contaLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label vl_contaLabel;
            System.Windows.Forms.Label id_fornecedorLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label ds_obsLabel;
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tbContasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbContasPagarTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tbContasPagarTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_contaTextBox = new System.Windows.Forms.TextBox();
            this.id_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.ds_obsTextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            cd_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            vl_contaLabel = new System.Windows.Forms.Label();
            id_fornecedorLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            ds_obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Location = new System.Drawing.Point(163, 37);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(91, 29);
            cd_contaLabel.TabIndex = 1;
            cd_contaLabel.Text = "Código:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Location = new System.Drawing.Point(68, 83);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(186, 29);
            dt_emissaoLabel.TabIndex = 3;
            dt_emissaoLabel.Text = "Data de Emissão:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Location = new System.Drawing.Point(32, 128);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(222, 29);
            dt_vencimentoLabel.TabIndex = 5;
            dt_vencimentoLabel.Text = "Data de Vencimento:";
            // 
            // vl_contaLabel
            // 
            vl_contaLabel.AutoSize = true;
            vl_contaLabel.Location = new System.Drawing.Point(181, 166);
            vl_contaLabel.Name = "vl_contaLabel";
            vl_contaLabel.Size = new System.Drawing.Size(73, 29);
            vl_contaLabel.TabIndex = 7;
            vl_contaLabel.Text = "Valor:";
            // 
            // id_fornecedorLabel
            // 
            id_fornecedorLabel.AutoSize = true;
            id_fornecedorLabel.Location = new System.Drawing.Point(12, 210);
            id_fornecedorLabel.Name = "id_fornecedorLabel";
            id_fornecedorLabel.Size = new System.Drawing.Size(242, 29);
            id_fornecedorLabel.TabIndex = 9;
            id_fornecedorLabel.Text = "Código do Fornecedor:";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Location = new System.Drawing.Point(35, 256);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(219, 29);
            dt_pagamentoLabel.TabIndex = 11;
            dt_pagamentoLabel.Text = "Data de Pagamento:";
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Location = new System.Drawing.Point(124, 296);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(130, 29);
            vl_pagoLabel.TabIndex = 13;
            vl_pagoLabel.Text = "Valor Pago:";
            // 
            // ds_obsLabel
            // 
            ds_obsLabel.AutoSize = true;
            ds_obsLabel.Location = new System.Drawing.Point(105, 339);
            ds_obsLabel.Name = "ds_obsLabel";
            ds_obsLabel.Size = new System.Drawing.Size(149, 29);
            ds_obsLabel.TabIndex = 15;
            ds_obsLabel.Text = "Observações:";
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
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Location = new System.Drawing.Point(260, 34);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(63, 37);
            this.cd_contaTextBox.TabIndex = 2;
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbContasPagarBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(260, 77);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(456, 37);
            this.dt_emissaoDateTimePicker.TabIndex = 4;
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbContasPagarBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(260, 120);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(456, 37);
            this.dt_vencimentoDateTimePicker.TabIndex = 6;
            // 
            // vl_contaTextBox
            // 
            this.vl_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "vl_conta", true));
            this.vl_contaTextBox.Location = new System.Drawing.Point(260, 163);
            this.vl_contaTextBox.Name = "vl_contaTextBox";
            this.vl_contaTextBox.Size = new System.Drawing.Size(151, 37);
            this.vl_contaTextBox.TabIndex = 8;
            // 
            // id_fornecedorTextBox
            // 
            this.id_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "id_fornecedor", true));
            this.id_fornecedorTextBox.Location = new System.Drawing.Point(260, 207);
            this.id_fornecedorTextBox.Name = "id_fornecedorTextBox";
            this.id_fornecedorTextBox.Size = new System.Drawing.Size(63, 37);
            this.id_fornecedorTextBox.TabIndex = 10;
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tbContasPagarBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(260, 250);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(456, 37);
            this.dt_pagamentoDateTimePicker.TabIndex = 12;
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(260, 293);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(200, 37);
            this.vl_pagoTextBox.TabIndex = 14;
            // 
            // ds_obsTextBox
            // 
            this.ds_obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbContasPagarBindingSource, "ds_obs", true));
            this.ds_obsTextBox.Location = new System.Drawing.Point(260, 336);
            this.ds_obsTextBox.Multiline = true;
            this.ds_obsTextBox.Name = "ds_obsTextBox";
            this.ds_obsTextBox.Size = new System.Drawing.Size(456, 95);
            this.ds_obsTextBox.TabIndex = 16;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(397, 544);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(271, 544);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 40);
            this.btnImprimir.TabIndex = 57;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(271, 498);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(120, 40);
            this.btnAlterar.TabIndex = 56;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(145, 498);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(120, 40);
            this.btnNovo.TabIndex = 55;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(523, 544);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 40);
            this.btnSair.TabIndex = 54;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(523, 498);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 40);
            this.btnSalvar.TabIndex = 53;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(145, 544);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(120, 40);
            this.btnPesquisar.TabIndex = 52;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(397, 498);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(120, 40);
            this.btnExcluir.TabIndex = 51;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(397, 452);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(120, 40);
            this.btnProximo.TabIndex = 50;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(271, 452);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(120, 40);
            this.btnAnterior.TabIndex = 49;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // frmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 612);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(vl_contaLabel);
            this.Controls.Add(this.vl_contaTextBox);
            this.Controls.Add(id_fornecedorLabel);
            this.Controls.Add(this.id_fornecedorTextBox);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(ds_obsLabel);
            this.Controls.Add(this.ds_obsTextBox);
            this.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frmContasPagar";
            this.Text = "Contas a Pagar";
            this.Load += new System.EventHandler(this.frmContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbContasPagarBindingSource;
        private contasDataSetTableAdapters.tbContasPagarTableAdapter tbContasPagarTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_contaTextBox;
        private System.Windows.Forms.TextBox id_fornecedorTextBox;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox ds_obsTextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
    }
}