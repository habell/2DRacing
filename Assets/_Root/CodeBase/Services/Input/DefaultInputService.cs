using UnityEngine;

namespace _Root.CodeBase.Services.Input
{
    public class DefaultInputService : InputService
    {
        public override Vector2 Axis
        {
            get
            {
                var axis = GetUnityAxis();
                return axis;
            }
        }

        public override bool IsActionButtonUp() => UnityEngine.Input.GetMouseButtonUp(0);

        private Vector2 GetUnityAxis() => new(UnityEngine.Input.GetAxis("Horizontal"), UnityEngine.Input.GetAxis("Vertical"));
    }
}