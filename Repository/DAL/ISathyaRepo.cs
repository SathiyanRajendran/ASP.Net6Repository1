using ASP.Net6Repository.Models;

namespace ASP.Net6Repository.DAL
{
    public interface ISathyaRepo
    {
        IEnumerable<Repository> GetRepositorys(); 
        Repository GetRepositoryByID(int repositoryid);
        void InsertRepository(Repository repository);
        void DeleteRepository(int repositoryid);
        void UpdateRepository(Repository repository);
        void Save();
    }
}
