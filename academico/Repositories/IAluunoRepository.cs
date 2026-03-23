using academico.Models;

namespace academico.Repositories
{
    public interface IAluunoRepository
    {
        Task<IEnumerable<Aluno>> GetAll(CancellationToken cancellationToken = default);
        Task<Aluno?> GetById(CancellationToken cancellationToken = default);
        Task Create(CancellationToken cancellationToken = default);
        Task Edit(CancellationToken cancellationToken = default);
        Task Delete(CancellationToken cancellationToken = default);
        Task<bool> Exists(CancellationToken cancellationToken = default);
    }
}
