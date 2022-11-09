using _Root.CodeBase.Services.Input;

namespace _Root.CodeBase.Infrastructure
{
    internal class Game
    {
        private static IInputService _inputInputService;

        public Game()
        {
            _inputInputService ??= RegisterInputService();
        }

        public static IInputService InputService => _inputInputService;

        private IInputService RegisterInputService() => new DefaultInputService();
    }
}   