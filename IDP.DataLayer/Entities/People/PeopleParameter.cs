using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IDP.DataLayer.Entities.People
{
    public class PeopleParameter : IIdpEntity
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public Guid TypeId { get; set; }
        public string Value { get; set; }
        public bool IsValid { get; set; }
        public DateTime LastUpdate { get; set; }
        [ForeignKey("PersonId")]
        protected virtual Person Person { get; set; }

        [ForeignKey("TypeId")]
        protected virtual ParameterType ParameterType { get; set; }

    }
}