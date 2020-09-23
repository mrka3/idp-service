using System;
using System.Linq;
using IDP.DataLayer.Infrastructure;

namespace IDP.DataLayer.Entities.People.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IEntityRepository<IIdpEntity> entityRepository;

        public PersonRepository(IEntityRepository<IIdpEntity> entityRepository)
        {
            this.entityRepository = entityRepository;
        }

        public Person Find(Guid id)
        {
            return entityRepository.GetTable<Person>().FirstOrDefault(p => p.Id == id);
        }

        public float? GetIndex(Guid id)
        {
            return entityRepository.GetTable<Person>().FirstOrDefault(p => p.Id == id)?.IndexOfTrust;
        }
    }
}