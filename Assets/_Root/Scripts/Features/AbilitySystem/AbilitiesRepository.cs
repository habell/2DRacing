using System.Collections.Generic;
using _Root.Scripts.Features.AbilitySystem.Abilities;

namespace _Root.Scripts.Features.AbilitySystem
{
    internal interface IAbilitiesRepository : IRepository
    {
        IReadOnlyDictionary<string, IAbility> Items { get; }
    }

    internal class AbilitiesRepository : BaseRepository<string, IAbility, AbilityItemConfig>
    {
        public AbilitiesRepository(IEnumerable<AbilityItemConfig> configs) : base(configs)
        { }

        protected override string GetKey(AbilityItemConfig config) => config.Id;

        protected override IAbility CreateItem(AbilityItemConfig config)
        {
            switch (config.Type)
            {
                case AbilityType.Gun: return new GunAbility(config);
                case AbilityType.Oil: return new OilAbility(config);
                default: return null;
            }
        }
    }
}
