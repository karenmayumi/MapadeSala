
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TercaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuartaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuintaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SextaFeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDaSemanaEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoDisciplinaPeriodoEach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursoDisciplina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridCursoDisciplina
            // 
            this.dtGridCursoDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridCursoDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridCursoDisciplina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Horario,
            this.SegundaFeira,
            this.TercaFeira,
            this.QuartaFeira,
            this.QuintaFeira,
            this.SextaFeira});
            this.dtGridCursoDisciplina.Location = new System.Drawing.Point(288, 413);
            this.dtGridCursoDisciplina.Name = "dtGridCursoDisciplina";
            this.dtGridCursoDisciplina.Size = new System.Drawing.Size(694, 212);
            this.dtGridCursoDisciplina.TabIndex = 67;
            this.dtGridCursoDisciplina.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 283);
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
            this.cbDiaDaSemana.Location = new System.Drawing.Point(31, 299);
            this.cbDiaDaSemana.Name = "cbDiaDaSemana";
            this.cbDiaDaSemana.Size = new System.Drawing.Size(222, 21);
            this.cbDiaDaSemana.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 226);
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
            this.cbHorario.Location = new System.Drawing.Point(31, 242);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(222, 21);
            this.cbHorario.TabIndex = 63;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(178, 389);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 62;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Sala";
            // 
            // cbSala
            // 
            this.cbSala.FormattingEnabled = true;
            this.cbSala.Location = new System.Drawing.Point(31, 181);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(222, 21);
            this.cbSala.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "ID";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(31, 122);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(222, 21);
            this.cbId.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 343);
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
            this.comboBox1.Location = new System.Drawing.Point(31, 359);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Pesquisa";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(659, 83);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(511, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 25);
            this.label7.TabIndex = 76;
            this.label7.Text = "Pesquisa por Mapa de Sala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 77;
            this.label8.Text = "Inserir";
            // 
            // Horario
            // 
            this.Horario.HeaderText = "Horário";
            this.Horario.Name = "Horario";
            // 
            // SegundaFeira
            // 
            this.SegundaFeira.HeaderText = "Segunda-Feira";
            this.SegundaFeira.Name = "SegundaFeira";
            // 
            // TercaFeira
            // 
            this.TercaFeira.HeaderText = "Terça-Feira";
            this.TercaFeira.Name = "TercaFeira";
            // 
            // QuartaFeira
            // 
            this.QuartaFeira.HeaderText = "Quarta-Feira";
            this.QuartaFeira.Name = "QuartaFeira";
            // 
            // QuintaFeira
            // 
            this.QuintaFeira.HeaderText = "Quinta-Feira";
            this.QuintaFeira.Name = "QuintaFeira";
            // 
            // SextaFeira
            // 
            this.SextaFeira.HeaderText = "Sexta-Feira";
            this.SextaFeira.Name = "SextaFeira";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEach,
            this.SalaEach,
            this.HorarioEach,
            this.DiaDaSemanaEach,
            this.CursoDisciplinaPeriodoEach});
            this.dataGridView1.Location = new System.Drawing.Point(288, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 234);
            this.dataGridView1.TabIndex = 86;
            // 
            // IDEach
            // 
            this.IDEach.HeaderText = "ID";
            this.IDEach.Name = "IDEach";
            // 
            // SalaEach
            // 
            this.SalaEach.HeaderText = "Sala";
            this.SalaEach.Name = "SalaEach";
            // 
            // HorarioEach
            // 
            this.HorarioEach.HeaderText = "Horario";
            this.HorarioEach.Name = "HorarioEach";
            // 
            // DiaDaSemanaEach
            // 
            this.DiaDaSemanaEach.HeaderText = "Dia da Semana";
            this.DiaDaSemanaEach.Name = "DiaDaSemanaEach";
            // 
            // CursoDisciplinaPeriodoEach
            // 
            this.CursoDisciplinaPeriodoEach.HeaderText = "Curso Disciplina Periodo";
            this.CursoDisciplinaPeriodoEach.Name = "CursoDisciplinaPeriodoEach";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 25);
            this.label10.TabIndex = 87;
            this.label10.Text = "Pesquisa por CursoPeriodo:";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 383);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "*adicionar checkbox";
            // 
            // frmMapadeSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 637);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbId);
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
            this.Load += new System.EventHandler(this.frmMapadeSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridCursoDisciplina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn TercaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuartaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuintaFeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn SextaFeira;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDaSemanaEach;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoDisciplinaPeriodoEach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}