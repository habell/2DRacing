using System;
using _Root.CodeBase.Infrastructure;
using _Root.CodeBase.Services.Input;
using Unity.VisualScripting;
using UnityEngine;

namespace _Root.CodeBase.GamePlay
{
    public class TailRender : MonoBehaviour
    {
        private IInputService _inputService;
        private RectTransform _rectTransform;

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        private void Start()
        {
            _inputService = Game.Service;
        }

        private void Update()
        {
            if(_inputService.IsActionButton()) _rectTransform.position = Input.mousePosition ; 
        }
    }
}