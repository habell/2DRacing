using System;

namespace _Root.Scripts.Tool.Reactive
{
    internal interface ISubscriptionProperty<out TValue>
    {
        TValue Value { get; }
        void SubscribeOnChange(Action<TValue> subscriptionAction);
        void UnSubscribeOnChange(Action<TValue> unsubscriptionAction);
    }
}
