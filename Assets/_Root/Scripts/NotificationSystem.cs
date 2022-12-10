using System;
using Unity.Notifications.Android;
using UnityEngine;

namespace _Root.Scripts
{
    public class NotificationSystem : MonoBehaviour
    {
        private AndroidNotificationChannel _defaultNotificationChanel;

        private int _id;
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

            AndroidNotification notification = new AndroidNotification()
            {
                Title = "Test",
                Text = "test text",
                SmallIcon = "default",
                LargeIcon = "default",
                FireTime = DateTime.Now.AddSeconds(10),
            };

            _id = AndroidNotificationCenter.SendNotification(notification, "default_channel");
        }
    }
}