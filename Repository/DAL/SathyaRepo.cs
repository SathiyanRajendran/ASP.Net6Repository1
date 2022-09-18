using ASP.Net6Repository.Models;

namespace ASP.Net6Repository.DAL
{
    public class SathyaRepo : ISathyaRepo
    {
        private readonly RepoDbContext db;
        public SathyaRepo(RepoDbContext _db)
        {
            db = _db;
        }

        public void DeleteRepository(int repositoryid)
        {
           Repository repository = db.repositorys.Find(repositoryid);
            db.repositorys.Remove(repository);
        }

        public Repository GetRepositoryByID(int repositoryid)
        {
            return db.repositorys.Find(repositoryid);
        }

        public IEnumerable<Repository> GetRepositorys()
        {
           return db.repositorys.ToList();
        }

        public void InsertRepository(Repository repository)
        {
            db.repositorys.Add(repository);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void UpdateRepository(Repository repository)
        {
            db.repositorys.Update(repository);
            db.SaveChanges();
        }
    }
}
