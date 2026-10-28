
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoPetShop.Models.Repositorio.Contrato;
using System.Collections;
using System.Data;

namespace ProjetoPetShop.Models.Repositorio
{

    public class TutorRepositorio : ITutorRepositorio
    {
        private readonly string ? _conexaoMySQL;

        public TutorRepositorio(IConfiguration conf)
        {
            _conexaoMySQL = conf.GetConnectionString("ConexaoMySQL");
        }

        public IEnumerable<Tutor> ObterTodosTutor()
        {
            List<Tutor> tutorList = new List<Tutor>();

            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM TUTOR", conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                conexao.Close();

                foreach (DataRow dr in dt.Rows)
                {
                    tutorList.Add(
                        new Tutor
                        {
                            id = Convert.ToInt32(dr["id_tutor"]),
                            nome = Convert.ToString(dr["nome"]),
                            telefone = Convert.ToString(dr["telefone"]),
                            email = Convert.ToString(dr["email"])
                        }
                    );
                }
                return tutorList;
            }
        }
        public void Atualizar(Tutor tutor)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Tutor tutor)
        {
            using (var conexao = new MySqlConnection(_conexaoMySQL))
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("insert into Tutor(nome, telefone, email) " +
                "values(@nome, @telefone, @email)", conexao);

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = tutor.nome;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = tutor.telefone;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = tutor.email;

                cmd.ExecuteNonQuery();
                conexao.Close();
            }
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }
        public Tutor ObterTutor(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
