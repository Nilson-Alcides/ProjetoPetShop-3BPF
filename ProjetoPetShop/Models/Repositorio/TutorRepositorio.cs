
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using ProjetoPetShop.Models.Repositorio.Contrato;
using System.Collections;
using System.Data;

namespace ProjetoPetShop.Models.Repositorio
{

    public class TutorRepositorio : ITutorRepositorio
    {
        private readonly string _conexaoMySQL;
        
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
                            id = Convert.ToInt32(dr["codCli"]),
                            nome = Convert.ToString(dr["nomeCli"]),
                            telefone = Convert.ToString(dr["telCli"]),
                            email = Convert.ToString(dr["EmailCli"])
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
            throw new NotImplementedException();
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
