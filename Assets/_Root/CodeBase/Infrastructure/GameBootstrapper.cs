using System;
using UnityEngine;

namespace _Root.CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        [Tooltip("Test tooltip")]
        [field: SerializeField]
        private string _testSerializebleFieldWithTooltip { get; set; }

        [Header("Test Header")]
        [Tooltip("Test tooltip")]
        [SerializeField]
        private string _testSerializeblePropertyWithHeaderAndTooltip;
        
        private Game _game;

        private void Awake()
        {
            _game = new Game();
        }

        private void Update()
        {
            if (Input.GetMouseButtonUp(0))
            {
                print(Input.mousePosition);
            }
        }
    }
}