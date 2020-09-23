using System;

namespace IDP.DataLayer.Entities.People
{
    public class ParameterType : IIdpEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Parts { get; set; } // вес, доля, которую занимает параметр
        public int Count { get; set; } // количество параметров
    }
}