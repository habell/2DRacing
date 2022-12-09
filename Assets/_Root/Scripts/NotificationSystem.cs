using System;
using Unity.Notifications.Android;
using UnityEngine;

namespace _Root.Scripts
{
    public class NotificationSystem : MonoBehaviour
    {
        private AndroidNotificationChannel _defaultNotificationChanel;

        private void Start()
        {
            _defaultNotificationChanel = new AndroidNotificationChannel()
            {
                Id = "default_channel",
                Name = "Default Chanel",
                Description = "Test notification",
                Importance = Importance.Default,
            };
            AndroidNotificationCenter.RegisterNotificationChannel(_defaultNotificationChanel);
        }
    }
}