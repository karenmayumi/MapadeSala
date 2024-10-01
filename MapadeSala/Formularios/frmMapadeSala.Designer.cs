
namespace MapadeSala.Formularios
{
    partial class frmMapadeSala
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtGridCursoDisciplina = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDiaDaSemana = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursoDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Pesquisa";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(467, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(302, 20);
            this.txtSearch.TabIndex = 68;
            // 
            // dtGridCursoDisciplina
            // 
            this.dtGridCursoDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursoDisciplina.Location = new System.Drawing.Point(306, 87);
            this.dtGridCursoDisciplina.Name = "dtGridCursoDisciplina";
            this.dtGridCursoDisciplina.Size = new System.Drawing.Size(463, 347);
            this.dtGridCursoDisciplina.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Dia da Semana";
            // 
            // cbDiaDaSemana
            // 
            this.cbDiaDaSemana.FormattingEnabled = true;
            this.cbDiaDaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.cbDiaDaSemana.Location = new System.Drawing.Point(37, 218);
            this.cbDiaDaSemana.Name = "cbDiaDaSemana";
            this.cbDiaDaSemana.Size = new System.Drawing.Size(169, 21);
            this.cbDiaDaSemana.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Horario";
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "07:10 - 08:00",
            "08:00 - 08:50",
            "08:50 - 09:40",
            "10:00 - 10:50",
            "10:50 - 11:40",
            "13:00 - 13:50",
            "13:50 - 14:40",
            "14:40 - 15:30",
            "15:50 - 16:40",
            "16:40 - 17:30"});
            this.cbHorario.Location = new System.Drawing.Point(37, 161);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(169, 21);
            this.cbHorario.TabIndex = 63;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(225, 411);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 62;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(37, 100);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(169, 21);
            this.cbSala.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(37, 41);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(169, 21);
            this.cbId.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Curso Disciplina Período";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.comboBox1.Location = new System.Drawing.Point(37, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 72;
            // 
            // frmMapadeSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtGridCursoDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDiaDaSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSala);
            this.Name = "frmMapadeSala";
            this.Text = "frmMapadeSala";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursoDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtGridCursoDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDiaDaSemana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}