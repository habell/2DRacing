using System;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace _Root.Scripts
{
    [RequireComponent(typeof(Button))]
    public class LocalizationButton : MonoBehaviour
    {
        [SerializeField]
        private Button _changeLanguageButton;
        private int _currentIndex = 0;

        private void Start()
        {
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_currentIndex];
            _changeLanguageButton = GetComponent<Button>();
            _changeLanguageButton.onClick.AddListener(ChangeLanguage);
        }

        private void OnDestroy() => _changeLanguageButton.onClick.RemoveAllListeners();

        private void ChangeLanguage()
        {
            print(_currentIndex);
            if (_currentIndex > 0) _currentIndex = 0;
            else _currentIndex = 1;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_currentIndex];
        }
    }
}