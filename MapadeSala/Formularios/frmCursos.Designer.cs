
namespace MapadeSala.Formularios
{
    partial class frmCursos
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
            this.btnAdicionarDisciplina = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtGridCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarDisciplina
            // 
            this.btnAdicionarDisciplina.Location = new System.Drawing.Point(635, 51);
            this.btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            this.btnAdicionarDisciplina.Size = new System.Drawing.Size(128, 23);
            this.btnAdicionarDisciplina.TabIndex = 62;
            this.btnAdicionarDisciplina.Text = "Adicionar Curso";
            this.btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            this.btnAdicionarDisciplina.Click += new System.EventHandler(this.btnAdicionarDisciplina_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Pesquisa";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(40, 78);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 20);
            this.txtSearch.TabIndex = 59;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(635, 77);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(128, 23);
            this.btnSalvar.TabIndex = 58;
            this.btnSalvar.Text = "Editar/Excluir";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtGridCursos
            // 
            this.dtGridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursos.Location = new System.Drawing.Point(40, 120);
            this.dtGridCursos.Name = "dtGridCursos";
            this.dtGridCursos.Size = new System.Drawing.Size(723, 362);
            this.dtGridCursos.TabIndex = 60;
            this.dtGridCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellClick);
            this.dtGridCursos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridCursos_CellContentDoubleClick);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.btnAdicionarDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtGridCursos);
            this.Name = "frmCursos";
            this.Text = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dtGridCursos;
    }
}