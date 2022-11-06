using UnityEngine;

namespace _Root.CodeBase.Services.Input
{
    public abstract class InputService : IInputService
    {
        public abstract Vector2 Axis { get; }

        public abstract bool IsActionButtonUp();
    }
}