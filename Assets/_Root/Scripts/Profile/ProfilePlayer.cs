using _Root.Scripts.Features.Inventory;
using _Root.Scripts.Game.Car;
using _Root.Scripts.Tool.Reactive;

namespace _Root.Scripts.Profile
{
    internal class ProfilePlayer
    {
        public readonly SubscriptionProperty<GameState> CurrentState;
        public readonly CarModel CurrentCar;
        public readonly InventoryModel Inventory;


        public ProfilePlayer(float speedCar, GameState initialState) : this(speedCar)
        {
            CurrentState.Value = initialState;
        }

        public ProfilePlayer(float speedCar)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new CarModel(speedCar);
            Inventory = new InventoryModel();
        }
    }
}
