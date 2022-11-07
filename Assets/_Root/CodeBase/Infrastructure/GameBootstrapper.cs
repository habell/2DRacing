using System;
using UnityEngine;

namespace _Root.CodeBase.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
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