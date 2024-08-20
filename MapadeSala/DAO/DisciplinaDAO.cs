﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using Model.Entidades;
using System.Data;

namespace MapadeSala.DAO
{
    public class DisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=Aula_DS;User Id=SA;Password=admsasql;"; //LS05M020
        private SqlConnection Conexao;
        public DisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void InserirDisciplina(DisciplinaEntidade disciplina)
        {
            Conexao.Open();
            string Query = "INSERT into Disciplinas (Nome, Sigla, Ativo) VALUES (@nome,@sigla,@ativo); ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@nome", disciplina.Nome);
            SqlParameter par2 = new SqlParameter("@sigla", disciplina.Sigla);
            SqlParameter par3 = new SqlParameter("@ativo", disciplina.Ativo);

            Comando.Parameters.Add(par1);
            Comando.Parameters.Add(par2);
            Comando.Parameters.Add(par3);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterDisciplina()
        {
            DataTable retorno = new DataTable();
            Conexao.Open();
            string query = "SELECT ID, NOME, SIGLA, ATIVO FROM CURSOS ORDER BY ID DESC";
            SqlCommand Comando = new SqlCommand(query, Conexao);

            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(DisciplinaEntidade).GetProperties())
            {
                retorno.Columns.Add(atributos.Name);
            }

            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursosEntidade c = new CursosEntidade();
                    c.Id = Convert.ToInt32(Leitura[0]);
                    c.Nome = Leitura[1].ToString();
                    c.Sigla = Leitura[2].ToString();
                    c.Ativo = Convert.ToBoolean(Leitura[3]);
                    retorno.Rows.Add(c.Linha());
                }
            }
            Conexao.Close();
            return retorno;
        }
        public void ExcluirDisciplina(int indexDisciplina)
        {
            Conexao.Open();
            string Query = "DELETE FROM Cursos WHERE id = @id; ";
            SqlCommand Comando = new SqlCommand(Query, Conexao);
            SqlParameter par1 = new SqlParameter("@id", indexDisciplina);

            Comando.Parameters.Add(par1);
            Comando.ExecuteNonQuery();
            Conexao.Close();
        }
    }
}