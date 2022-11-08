using UnityEngine;

namespace _Root.CodeBase.Services.Input
{
    public interface IInputService
    {
        Vector2 Axis { get; }

        bool IsActionButtonUp();
        bool IsActionButton();
    }
}