namespace ProjetoPetShop.Models.Repositorio.Contrato
{
    public interface ITutorRepositorio
    {
        // CRUD
        void Cadastrar(Tutor tutor);
        void Atualizar(Tutor tutor);
        void Excluir(int id);
        Tutor ObterTutor(int Id);
        IEnumerable<Tutor> ObterTodosTutor();            
    }
}
