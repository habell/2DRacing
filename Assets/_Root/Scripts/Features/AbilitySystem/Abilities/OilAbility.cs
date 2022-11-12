using System;
using JetBrains.Annotations;
using UnityEngine;

namespace _Root.Scripts.Features.AbilitySystem.Abilities
{
    internal class OilAbility : IAbility
    {
        private readonly AbilityItemConfig _config;
        public OilAbility([NotNull] AbilityItemConfig config) => 
            _config = config ?? throw new ArgumentNullException(nameof(config));
        public void Apply(IAbilityActivator activator)
        {
            Debug.Log("Some oil drop on road");
        }
    }
}