
namespace MapadeSala.Formularios
{
    partial class frmDisciplinas
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
            this.dtGridDisciplina = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdicionarDisciplina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridDisciplina
            // 
            this.dtGridDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDisciplina.Location = new System.Drawing.Point(41, 113);
            this.dtGridDisciplina.Name = "dtGridDisciplina";
            this.dtGridDisciplina.Size = new System.Drawing.Size(723, 362);
            this.dtGridDisciplina.TabIndex = 41;
            this.dtGridDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellClick);
            this.dtGridDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridDisciplina_CellDoubleClick);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(636, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Editar/Excluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(41, 71);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Pesquisa";
            // 
            // btnAdicionarDisciplina
            // 
            this.btnAdicionarDisciplina.Location = new System.Drawing.Point(636, 44);
            this.btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            this.btnAdicionarDisciplina.Size = new System.Drawing.Size(128, 23);
            this.btnAdicionarDisciplina.TabIndex = 57;
            this.btnAdicionarDisciplina.Text = "Adicionar Disciplina";
            this.btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            this.btnAdicionarDisciplina.Click += new System.EventHandler(this.btnAdicionarDisciplina_Click);
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnAdicionarDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridDisciplina);
            this.Name = "frmDisciplinas";
            this.Text = "frmDisciplinas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDisciplinas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridDisciplina;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdicionarDisciplina;
    }
}