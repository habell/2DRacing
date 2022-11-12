using _Root.Scripts.Features.Inventory.Items;
using UnityEngine;

namespace _Root.Scripts.Features.AbilitySystem.Abilities
{
    [CreateAssetMenu(fileName = nameof(AbilityItemConfig), menuName = "Configs/" + nameof(AbilityItemConfig))]
    internal class AbilityItemConfig : ScriptableObject, IAbilityItem
    {
        [SerializeField] private ItemConfig _itemConfig;
        [field: SerializeField] public AbilityType Type { get; private set; }
        [field: SerializeField] public GameObject Projectile { get; private set; }
        [field: SerializeField] public float Value { get; private set; }

        public string Id => _itemConfig.Id;
        public Sprite Icon => _itemConfig.Icon;
    }
}
