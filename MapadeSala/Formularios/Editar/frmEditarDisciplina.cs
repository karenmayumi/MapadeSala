﻿
using Model.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapadeSala.DAO.Editar
{
    public partial class frmEditarDisciplina : Form
    {
        DisciplinaDAO dao = new DisciplinaDAO();

        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;

        public frmEditarDisciplina(int DisciplinaId)
        {
            InitializeComponent();

            string query = "select Id, Nome, Sigla, Ativo " +
                "from Disciplinas where Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@id", DisciplinaId));

            SqlDataReader Leitura = comando.ExecuteReader();

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    label_id.Text = Leitura[0].ToString();
                    txtNome.Text = Leitura[1].ToString();
                    txtSigla.Text = Leitura[2].ToString();
                    chkAtivo.Checked = Convert.ToBoolean(Leitura[3]);

                }
            }
            Conexao.Close();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string query = "update Disciplinas set Nome = @nome, Sigla = @sigla, Ativo = @ativo WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);

            comando.Parameters.Add(new SqlParameter("@sigla", txtSigla.Text));
            comando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
            comando.Parameters.Add(new SqlParameter("@ativo", chkAtivo.Checked));
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));

            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Atualizada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string query = "Delete from Disciplinas WHERE  Id = @id";

            Conexao = new SqlConnection(LinhaConexao);
            Conexao.Open();

            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.Parameters.Add(new SqlParameter("@id", label_id.Text));
            int resposta = comando.ExecuteNonQuery();

            if (resposta == 1)
            {
                MessageBox.Show("Disciplina Excluída com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
