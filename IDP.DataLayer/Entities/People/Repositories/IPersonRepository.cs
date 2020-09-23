using System;

namespace IDP.DataLayer.Entities.People.Repositories
{
    public interface IPersonRepository
    {
        Person Find(Guid id);
        float? GetIndex(Guid id);
    }
}