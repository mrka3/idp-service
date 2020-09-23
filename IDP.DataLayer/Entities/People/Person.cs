using System;

namespace IDP.DataLayer.Entities.People
{
    public class Person : IIdpEntity
    {
        public Guid Id { get; set; }
        public float IndexOfTrust { get; set; }
    }
}