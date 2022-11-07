using _Root.CodeBase.Services.Input;

namespace _Root.CodeBase.Infrastructure
{
    internal class Game
    {
        private static IInputService _inputService;

        public Game()
        {
            _inputService ??= RegisterInputService();
        }

        public static IInputService Service => _inputService;

        private IInputService RegisterInputService() => new DefaultInputService();
    }
}   