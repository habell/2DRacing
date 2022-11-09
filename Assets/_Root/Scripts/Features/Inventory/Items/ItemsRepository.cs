using System.Collections.Generic;

namespace _Root.Scripts.Features.Inventory.Items
{
    internal interface IItemsRepository : IRepository
    {
        IReadOnlyDictionary<string, IItem> Items { get; }
    }

    internal class ItemsRepository : BaseRepository<string, IItem, ItemConfig>, IItemsRepository
    {
        public ItemsRepository(IEnumerable<ItemConfig> configs) : base(configs)
        { }

        protected override string GetKey(ItemConfig config) =>
            config.Id;

        protected override IItem CreateItem(ItemConfig config) =>
            new Item
            (
                config.Id,
                new ItemInfo
                (
                    config.Title,
                    config.Icon
                )
            );
    }

}
