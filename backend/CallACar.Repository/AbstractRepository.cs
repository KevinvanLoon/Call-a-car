using System.Collections.Generic;
using System.Linq;
using CallACarr.Domain;

namespace CallACar.Repository
{
    public abstract class AbstractRepository<T> where T : EntityBase
    {
        private int _id = 0;
        public IList<T> Entities = new List<T>();

        public IQueryable<T> Get()
        {
            return Entities.AsQueryable<T>();
        }

        public T GetSingle(int id)
        {
            return Entities.FirstOrDefault(e => e.Id == id);
        }
        
        public void Add(T entity)
        {
            Entities.Add(entity);
            entity.Id = _id++;
        }

        public void Update(int id, T entity)
        {
            T element = Entities.FirstOrDefault(e => e.Id == id);

            if (element != null)
            {
                Entities[Entities.ToList().IndexOf(element)] = entity; // mock database UPDATE
            }
        }

        public void Delete(int id)
        {
            T element = Entities.FirstOrDefault(e => e.Id == id);

            if (element != null)
            {
                Entities.RemoveAt(Entities.IndexOf(element));
            }
        }
    }
}