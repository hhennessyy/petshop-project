using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository
{
    public class SoldMedicineRepository : GenericRepository<SoldMedicine>, ISoldMedicine
    {
        private readonly PetshopDbContext _context;

        public SoldMedicineRepository(PetshopDbContext context) : base (context)
        {
            _context = context;
        }
    }
}