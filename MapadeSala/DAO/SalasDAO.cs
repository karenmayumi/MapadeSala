﻿using Model.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapadeSala.DAO
{
    public class SalasDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";// link do site
        private SqlConnection Conexao; //comunicacao programa/banco

        public SalasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(SalasEntidade sala)
        {
            Conexao.Open();
            string query = "insert into Salas(Nome, NumeroCadeiras, NumeroComputadores, IsLab, Disponivel) Values (@nome, @numerocadeiras, @numerocomputadores, @islab, @disponivel)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", sala.Nome);
            SqlParameter parametro2 = new SqlParameter("@numerocadeiras", sala.NumCadeiras);
            SqlParameter parametro3 = new SqlParameter("@numerocomputadores", sala.NumComputadores);
            SqlParameter parametro4 = new SqlParameter("@islab", sala.IsLab);
            SqlParameter parametro5 = new SqlParameter("@disponivel", sala.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterSalas()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "SELECT * FROM SALAS ORDER BY Id desc";
            SqlCommand Comando = new SqlCommand(query, Conexao);


            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    SalasEntidade sala = new SalasEntidade();
                    sala.Id = Convert.ToInt32(Leitura[0]);
                    sala.Nome = Leitura[1].ToString();
                    sala.NumComputadores = Convert.ToInt32(Leitura[2]);
                    sala.NumCadeiras = Convert.ToInt32(Leitura[3]);
                    sala.IsLab = Convert.ToBoolean(Leitura[4]);
                    sala.Disponivel = Convert.ToBoolean(Leitura[5]);
                    dt.Rows.Add(sala.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
        public DataTable PesquisarSalas(string pesquisa)
        {
            DataTable dt = new DataTable();
            Conexao.Open();

            string query = "";
            if (string.IsNullOrEmpty(pesquisa))
            {
                query = "SELECT * FROM SALAS ORDER BY ID desc";
            }
            else
            {
                query = "SELECT * FROM SALAS WHERE NOME LIKE '%" + pesquisa + "%' ORDER BY ID desc"; //concatenação
            }

            SqlCommand Comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = Comando.ExecuteReader();

            foreach (var atributos in typeof(SalasEntidade).GetProperties())//laço de reoetição para ler listas
            {
                dt.Columns.Add(atributos.Name);
            }
            if (Leitura.HasRows) //a linha existe? true or false
            {
                while (Leitura.Read())//para pegar mais de um registro, faz uma consulta
                {
                    SalasEntidade sala = new SalasEntidade();
                    sala.Id = Convert.ToInt32(Leitura[0]);
                    sala.Nome = Leitura[1].ToString();
                    sala.NumComputadores = Convert.ToInt32(Leitura[2]);
                    sala.NumCadeiras = Convert.ToInt32(Leitura[3]);
                    sala.IsLab = Convert.ToBoolean(Leitura[4]);
                    sala.Disponivel = Convert.ToBoolean(Leitura[5]);
                    dt.Rows.Add(sala.Linha());
                }
            }
            Conexao.Close();
            return dt;
        }
    }
}