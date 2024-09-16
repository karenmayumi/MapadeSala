
namespace MapadeSala.Formularios
{
    partial class frmCursoDisciplina
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
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.dtGridCursoDisciplina = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursoDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(37, 56);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(169, 21);
            this.cbDisciplina.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disciplina";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(697, 56);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cursos";
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(218, 56);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(138, 21);
            this.cbCursos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Período";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Items.AddRange(new object[] {
            "1° Ano",
            "2° Ano",
            "3° Ano",
            "1° Semestre",
            "2° Semestre",
            "3° Semestre"});
            this.cbPeriodo.Location = new System.Drawing.Point(369, 56);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(138, 21);
            this.cbPeriodo.TabIndex = 5;
            // 
            // dtGridCursoDisciplina
            // 
            this.dtGridCursoDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursoDisciplina.Location = new System.Drawing.Point(37, 186);
            this.dtGridCursoDisciplina.Name = "dtGridCursoDisciplina";
            this.dtGridCursoDisciplina.Size = new System.Drawing.Size(735, 260);
            this.dtGridCursoDisciplina.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Pesquisa";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(37, 142);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(183, 20);
            this.txtSearch.TabIndex = 58;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmCursoDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 506);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtGridCursoDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDisciplina);
            this.Name = "frmCursoDisciplina";
            this.Text = "FrmCursoDisciplina";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursoDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPeriodo;
        private System.Windows.Forms.DataGridView dtGridCursoDisciplina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
    }
}