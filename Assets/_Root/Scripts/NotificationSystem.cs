using System;
using Unity.Notifications.Android;
using UnityEngine;

namespace _Root.Scripts
{
    public class NotificationSystem : MonoBehaviour
    {
        private AndroidNotificationChannel _androidSettingsChannel;
        private const string AndroidChannelID = "AndroidNotificationID";
        private int _id;
        private AndroidNotification _notification;

        private void Start()
        {
            var ctorNotificationChannel = new AndroidNotificationChannel("TestID", "TestName", "TestDesc", Importance.High);
            _androidSettingsChannel = new AndroidNotificationChannel()
            {
                Id = AndroidChannelID,
                Name = "Lesson Notifier",
                Description = "Test notification",
                Importance = Importance.High,
                CanBypassDnd = true,
                CanShowBadge = true,
                EnableLights = true,
                EnableVibration = true,
                LockScreenVisibility = LockScreenVisibility.Public
            };
            AndroidNotificationCenter.RegisterNotificationChannel(_androidSettingsChannel);

            _notification = new AndroidNotification()
            {
                RepeatInterval = TimeSpan.FromSeconds(2)
            }; 
            
        }
        public void SendNotification()
        {
            var ctorNotificationChannel = new AndroidNotificationChannel("TestID", "TestName", "TestDesc", Importance.High);
            _androidSettingsChannel = new AndroidNotificationChannel()
            {
                Id = AndroidChannelID,
                Name = "Lesson Notifier",
                Description = "Test notification",
                Importance = Importance.High,
                CanBypassDnd = true,
                CanShowBadge = true,
                EnableLights = true,
                EnableVibration = true,
                LockScreenVisibility = LockScreenVisibility.Public
            };
            AndroidNotificationCenter.RegisterNotificationChannel(_androidSettingsChannel);

            _notification = new AndroidNotification()
            {
                RepeatInterval = TimeSpan.FromSeconds(2)
            }; 
            print(_id);
            _id = AndroidNotificationCenter.SendNotification(_notification, AndroidChannelID);
            print(_id);
            _id = AndroidNotificationCenter.SendNotification(_notification, "TestID");
            print(_id);
        }
    }
}