using System;
using Starter.Framework.Extensions;

namespace Starter.Data.Entities
{
    /// <summary>
    /// Implements the Cat entity
    /// </summary>
    public class Cat : Entity
    {
        public Cat()
        {
        }

        public Cat(string name, Ability abilityId)
        {
            Id = Guid.NewGuid();
            SecondaryId = Guid.NewGuid();

            PartitionKey = ((int)abilityId).ToString();
            RowKey = Id.ToString();

            Name = name;
            AbilityId = abilityId;
            Ability = abilityId.GetDescription();
        }

        public string Name { get; set; }

        public string Ability { get; set; }
        
        public Ability AbilityId { get; set; }

        public Guid SecondaryId { get; set; }
    }
}