using _Root.CodeBase.Services.Input;

namespace _Root.CodeBase.Infrastructure
{
    internal class Game
    {
        private IInputService _inputService;

        public Game()
        {
            _inputService = RegisterInputService();
        }

        private IInputService RegisterInputService() => new DefaultInputService();
    }
}   