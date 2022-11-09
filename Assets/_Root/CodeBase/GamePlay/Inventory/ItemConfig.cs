using UnityEngine;

namespace _Root.CodeBase.GamePlay.Inventory
{
    [CreateAssetMenu(fileName = nameof(ItemConfig))]
    public class ItemConfig : ScriptableObject
    {
        [field: SerializeField]
        public int ID { get; private set; } 

        [field: SerializeField]
        public string Title { get; private set; }
        
        //TODO ::: Some property;
    }
}