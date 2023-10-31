namespace Sisdef
{
    partial class frmPrincipal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableControleDefeitosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetSisdef = new Sisdef.DataSetSisdef();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnDefeitos = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbTituloLogin = new System.Windows.Forms.Label();
            this.pnDefeitos = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.mtxtHorarioFinal = new System.Windows.Forms.MaskedTextBox();
            this.mtxtHorarioInicio = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoDefeito = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEquipamento = new System.Windows.Forms.ComboBox();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableControleDefeitosTableAdapter = new Sisdef.DataSetSisdefTableAdapters.DataTableControleDefeitosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableControleDefeitosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSisdef)).BeginInit();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnLogin.SuspendLayout();
            this.pnDefeitos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableControleDefeitosBindingSource
            // 
            this.dataTableControleDefeitosBindingSource.DataMember = "DataTableControleDefeitos";
            this.dataTableControleDefeitosBindingSource.DataSource = this.dataSetSisdef;
            // 
            // dataSetSisdef
            // 
            this.dataSetSisdef.DataSetName = "DataSetSisdef";
            this.dataSetSisdef.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.White;
            this.pnMenu.Controls.Add(this.btnRelatorios);
            this.pnMenu.Controls.Add(this.btnDefeitos);
            this.pnMenu.Controls.Add(this.pbLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1082, 61);
            this.pnMenu.TabIndex = 0;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.White;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Location = new System.Drawing.Point(370, 14);
            this.btnRelatorios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(114, 34);
            this.btnRelatorios.TabIndex = 2;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnDefeitos
            // 
            this.btnDefeitos.BackColor = System.Drawing.Color.White;
            this.btnDefeitos.FlatAppearance.BorderSize = 0;
            this.btnDefeitos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDefeitos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnDefeitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefeitos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefeitos.Location = new System.Drawing.Point(208, 14);
            this.btnDefeitos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDefeitos.Name = "btnDefeitos";
            this.btnDefeitos.Size = new System.Drawing.Size(114, 34);
            this.btnDefeitos.TabIndex = 1;
            this.btnDefeitos.Text = "Defeitos";
            this.btnDefeitos.UseVisualStyleBackColor = false;
            this.btnDefeitos.Click += new System.EventHandler(this.btnDefeitos_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Sisdef.Properties.Resources.logo;
            this.pbLogo.Location = new System.Drawing.Point(9, 10);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(124, 41);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.White;
            this.pnLogin.Controls.Add(this.btnEntrar);
            this.pnLogin.Controls.Add(this.txtSenha);
            this.pnLogin.Controls.Add(this.txtLogin);
            this.pnLogin.Controls.Add(this.lbTituloLogin);
            this.pnLogin.Location = new System.Drawing.Point(403, 148);
            this.pnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(252, 297);
            this.pnLogin.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(61)))));
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(62, 204);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(133, 26);
            this.btnEntrar.TabIndex = 3;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(16, 133);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(221, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtLogin.Location = new System.Drawing.Point(16, 91);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(221, 23);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Login";
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // lbTituloLogin
            // 
            this.lbTituloLogin.AutoSize = true;
            this.lbTituloLogin.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloLogin.Location = new System.Drawing.Point(110, 32);
            this.lbTituloLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTituloLogin.Name = "lbTituloLogin";
            this.lbTituloLogin.Size = new System.Drawing.Size(43, 18);
            this.lbTituloLogin.TabIndex = 0;
            this.lbTituloLogin.Text = "Login";
            // 
            // pnDefeitos
            // 
            this.pnDefeitos.Controls.Add(this.btnLimpar);
            this.pnDefeitos.Controls.Add(this.mtxtHorarioFinal);
            this.pnDefeitos.Controls.Add(this.mtxtHorarioInicio);
            this.pnDefeitos.Controls.Add(this.cbTipoDefeito);
            this.pnDefeitos.Controls.Add(this.label5);
            this.pnDefeitos.Controls.Add(this.label4);
            this.pnDefeitos.Controls.Add(this.label3);
            this.pnDefeitos.Controls.Add(this.label2);
            this.pnDefeitos.Controls.Add(this.cbEquipamento);
            this.pnDefeitos.Controls.Add(this.mtxtData);
            this.pnDefeitos.Controls.Add(this.label1);
            this.pnDefeitos.Controls.Add(this.btnSalvar);
            this.pnDefeitos.Location = new System.Drawing.Point(116, 87);
            this.pnDefeitos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnDefeitos.Name = "pnDefeitos";
            this.pnDefeitos.Size = new System.Drawing.Size(801, 431);
            this.pnDefeitos.TabIndex = 2;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(632, 343);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(138, 37);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // mtxtHorarioFinal
            // 
            this.mtxtHorarioFinal.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtHorarioFinal.Location = new System.Drawing.Point(544, 232);
            this.mtxtHorarioFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtHorarioFinal.Mask = "00:00";
            this.mtxtHorarioFinal.Name = "mtxtHorarioFinal";
            this.mtxtHorarioFinal.Size = new System.Drawing.Size(76, 23);
            this.mtxtHorarioFinal.TabIndex = 12;
            this.mtxtHorarioFinal.ValidatingType = typeof(System.DateTime);
            // 
            // mtxtHorarioInicio
            // 
            this.mtxtHorarioInicio.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtHorarioInicio.Location = new System.Drawing.Point(151, 231);
            this.mtxtHorarioInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtHorarioInicio.Mask = "00:00";
            this.mtxtHorarioInicio.Name = "mtxtHorarioInicio";
            this.mtxtHorarioInicio.Size = new System.Drawing.Size(76, 23);
            this.mtxtHorarioInicio.TabIndex = 11;
            this.mtxtHorarioInicio.ValidatingType = typeof(System.DateTime);
            // 
            // cbTipoDefeito
            // 
            this.cbTipoDefeito.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDefeito.FormattingEnabled = true;
            this.cbTipoDefeito.Location = new System.Drawing.Point(544, 137);
            this.cbTipoDefeito.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoDefeito.Name = "cbTipoDefeito";
            this.cbTipoDefeito.Size = new System.Drawing.Size(236, 26);
            this.cbTipoDefeito.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horário Final Defeito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Defeito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horário Início Defeito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Equipamento";
            // 
            // cbEquipamento
            // 
            this.cbEquipamento.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEquipamento.FormattingEnabled = true;
            this.cbEquipamento.Location = new System.Drawing.Point(151, 141);
            this.cbEquipamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEquipamento.Name = "cbEquipamento";
            this.cbEquipamento.Size = new System.Drawing.Size(236, 26);
            this.cbEquipamento.TabIndex = 5;
            // 
            // mtxtData
            // 
            this.mtxtData.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtData.Location = new System.Drawing.Point(151, 50);
            this.mtxtData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(76, 23);
            this.mtxtData.TabIndex = 4;
            this.mtxtData.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(133)))), ((int)(((byte)(199)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(481, 343);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 37);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // reportViewer
            // 
            reportDataSource6.Name = "DataSetControleDefeitos";
            reportDataSource6.Value = this.dataTableControleDefeitosBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Sisdef.rltControleDefeitos.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(9, 98);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1064, 378);
            this.reportViewer.TabIndex = 3;
            this.reportViewer.Visible = false;
            // 
            // dataTableControleDefeitosTableAdapter
            // 
            this.dataTableControleDefeitosTableAdapter.ClearBeforeFill = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 564);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.pnDefeitos);
            this.Controls.Add(this.reportViewer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableControleDefeitosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetSisdef)).EndInit();
            this.pnMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.pnDefeitos.ResumeLayout(false);
            this.pnDefeitos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnDefeitos;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lbTituloLogin;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Panel pnDefeitos;
        private System.Windows.Forms.MaskedTextBox mtxtHorarioFinal;
        private System.Windows.Forms.MaskedTextBox mtxtHorarioInicio;
        private System.Windows.Forms.ComboBox cbTipoDefeito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEquipamento;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private DataSetSisdef dataSetSisdef;
        private System.Windows.Forms.BindingSource dataTableControleDefeitosBindingSource;
        private DataSetSisdefTableAdapters.DataTableControleDefeitosTableAdapter dataTableControleDefeitosTableAdapter;
    }
}

