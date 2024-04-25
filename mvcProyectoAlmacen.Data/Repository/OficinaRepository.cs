using Microsoft.EntityFrameworkCore;
using mvcProyectoAlmacen.Data.Repository;
using mvcProyectoAlmacen.Data.Repository.IRepository;
using mvcProyectoAlmacen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoAlmacen.Data.Repository
{
    public class OficinaRepository : Repository<Oficina>, IOficinaRepository
    {
        private readonly ApplicationDbContext _db;
        public OficinaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Oficina oficina)
        {
            var objDesdeDb = _db.Oficina.FirstOrDefault(s => s.Id == oficina.Id);
            objDesdeDb.NombreOficina = oficina.NombreOficina;
            objDesdeDb.Direccion = oficina.Direccion;
        }

    }
}
