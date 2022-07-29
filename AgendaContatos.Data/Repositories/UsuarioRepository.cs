using AgendaContatos.Data.Configurations;
using AgendaContatos.Data.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Data.Repositories
{
    public class UsuarioRepository
    {
        //método para inserir um usuário no banco de dados
        public void Create(Usuario usuario)
        {
            var sql = @"
                INSERT INTO USUARIO(
                    IDUSUARIO,
                    NOME,
                    EMAIL,
                    SENHA,
                    DATACADASTRO)   
                VALUES(
                    @IdUsuario,
                    @Nome,
                    @Email,
                    CONVERT(VARCHAR(32), HASHBYTES('MD5', @Senha), 2),
                    @DataCadastro)
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                connection.Execute(sql, usuario);
            }
        }
        public void Delete(Usuario usuario)
        {
            var sql = @"
                DELETE USUARIO
                WHERE IDUSUARIO = @idUsuario
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                connection.Execute(sql, usuario);
            }

        }
        public void Update(Usuario usuario)
        {
            var sql = @"
                SELECT * FROM USARIO
                SET
                    NOME = @Nome,
                    SENHA = @Senha,
                    DATACADASTRO = @DataCadastro
                WHERE IDUSUARIO
            ";

            using (var connection = new SqlConnection(SqlServerConfiguration.GetConnectionString()))
            {
                connection.Execute(sql, usuario);
            }

        }

    }
}
