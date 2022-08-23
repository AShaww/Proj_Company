using Data;

namespace Services.Implementations
{
    public class BaseService
    {
        protected readonly CompanyContext _db;
        public BaseService(CompanyContext db)
        {
            _db = db;
        }
    }
}
