using UnityEngine;

namespace _Root.Scripts.Features.AbilitySystem.Abilities
{
    internal interface IAbilityItem
    {
        string Id { get; }
        Sprite Icon { get; }
        AbilityType Type { get; }
        GameObject Projectile { get; }
        float Value { get; }
    }
}