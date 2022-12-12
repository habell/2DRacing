using System;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace _Root.Scripts
{
    [RequireComponent(typeof(TextMeshPro))]
    [RequireComponent(typeof(Button))]
    public class LocalizationButton : MonoBehaviour
    {
        private Button _changeLanguageButton;
        private int _currentIndex = 0;

        private void Start()
        {
            _changeLanguageButton = GetComponent<Button>();
            _changeLanguageButton.onClick.AddListener((() => ChangeLanguage()));
        }

        private void OnDestroy() => _changeLanguageButton.onClick.RemoveAllListeners();

        private void ChangeLanguage()
        {
            if (_currentIndex > 0) _currentIndex = 1;
            else _currentIndex = 0;
            LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_currentIndex];
        }
    }
}