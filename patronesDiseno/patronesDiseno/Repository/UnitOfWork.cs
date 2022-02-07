using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private DesignPatternsContext _context;
        public IRepository<Beer> _beers;
        public IRepository<Beer> _brands;
        public IRepository<Beer> Beers {
            get {
                return _beers == null ? _beers = new Repository<Beer>(_context) : _beers;
            }
        }

        IRepository<Brand> IUnitOfWork.Beers => throw new NotImplementedException();

        public UnitOfWork(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
