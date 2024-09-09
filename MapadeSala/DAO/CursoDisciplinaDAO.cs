﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entidades;

namespace MapaSala.DAO
{
    public class CursoDisciplinaDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CursoDisciplinaDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(CursoDisciplinaEntidade objeto)
        {
            Conexao.Open();
            string query = "Insert into Curso_Disciplina (Curso_Id , Disciplina_Id, Periodo) Values (@Curso_Id, @Disciplina_Id, @Periodo) ";
            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlParameter parametro1 = new SqlParameter("@Curso_Id", objeto.CursoId);
            SqlParameter parametro2 = new SqlParameter("@Disciplina_Id", objeto.DisciplinaId);
            SqlParameter parametro3 = new SqlParameter("@Periodo", objeto.Periodo);

            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.ExecuteNonQuery();
            Conexao.Close();

        }
        public DataTable ObterCursoDisciplina()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT  FROM   Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(CursoDisciplinaEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows)
            {
                while (Leitura.Read())
                {
                    CursoDisciplinaEntidade p = new CursoDisciplinaEntidade();
                    p.Id = Convert.ToInt32(Leitura[0]);
                    p.DisciplinaId = Convert.ToInt64(Leitura[1]);
                    p.CursoId = Convert.ToInt64(Leitura[2]);
                    p.NomeCurso = Leitura[3].ToString();
                    p.NomeDisciplina = Leitura[4].ToString();
                    dt.Rows.Add(p.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}
