
namespace MapadeSala.Formularios
{
    partial class frmUsuario
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
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.dtGridUsuario = new System.Windows.Forms.DataGridView();
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(471, 62);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 42;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // dtGridUsuario
            // 
            this.dtGridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridUsuario.Location = new System.Drawing.Point(35, 106);
            this.dtGridUsuario.Name = "dtGridUsuario";
            this.dtGridUsuario.Size = new System.Drawing.Size(727, 303);
            this.dtGridUsuario.TabIndex = 41;
            this.dtGridUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridUsuario_CellClick);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(690, 62);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 40;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(238, 68);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Senha";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(355, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "id";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(125, 68);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Nome";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(46, 68);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(73, 20);
            this.numId.TabIndex = 45;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(609, 36);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 52;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(597, 62);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 23);
            this.btnLimpar.TabIndex = 51;
            this.btnLimpar.Text = "Limpar Campo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(690, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 50;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.dtGridUsuario);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.DataGridView dtGridUsuario;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
    }
}