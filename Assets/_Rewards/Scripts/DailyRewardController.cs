using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Text;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Rewards
{
    internal class DailyRewardController
    {
        private readonly DailyRewardView _view;

        private List<ContainerSlotRewardView> _slots;
        private Coroutine _coroutine;

        private bool _isGetReward;
        private bool _isInitialized;

        private StringBuilder _simpleProgressBar;


        public DailyRewardController(DailyRewardView view) =>
            _view = view;


        public void Init()
        {
            if (_isInitialized)
                return;

            _simpleProgressBar = new StringBuilder();

            InitSlots();
            RefreshUi();
            StartRewardsUpdating();
            SubscribeButtons();

            _isInitialized = true;
        }

        public void Deinit()
        {
            if (!_isInitialized)
                return;

            DeinitSlots();
            StopRewardsUpdating();
            UnsubscribeButtons();

            _isInitialized = false;
        }


        private void InitSlots()
        {
            _slots = new List<ContainerSlotRewardView>();

            for (int i = 0; i < _view.Rewards.Count; i++)
            {
                ContainerSlotRewardView instanceSlot = CreateSlotRewardView();
                _slots.Add(instanceSlot);
            }
        }

        private ContainerSlotRewardView CreateSlotRewardView() =>
            Object.Instantiate
            (
                _view.ContainerSlotRewardPrefab,
                _view.MountRootSlotsReward,
                false
            );

        private void DeinitSlots()
        {
            foreach (ContainerSlotRewardView slot in _slots)
                Object.Destroy(slot.gameObject);

            _slots.Clear();
        }


        private void StartRewardsUpdating() =>
            _coroutine = _view.StartCoroutine(RewardsStateUpdater());

        private void StopRewardsUpdating()
        {
            if (_coroutine == null)
                return;

            _view.StopCoroutine(_coroutine);
            _coroutine = null;
        }

        private IEnumerator RewardsStateUpdater()
        {
            WaitForSeconds waitForSecond = new WaitForSeconds(1);

            while (true)
            {
                RefreshRewardsState();
                RefreshUi();
                yield return waitForSecond;
            }
        }


        private void SubscribeButtons()
        {
            _view.GetRewardButton.onClick.AddListener(ClaimReward);
            _view.ResetButton.onClick.AddListener(ResetRewardsState);
        }

        private void UnsubscribeButtons()
        {
            _view.GetRewardButton.onClick.RemoveListener(ClaimReward);
            _view.ResetButton.onClick.RemoveListener(ResetRewardsState);
        }

        private void ClaimReward()
        {
            if (!_isGetReward)
                return;

            Reward reward = _view.Rewards[_view.CurrentSlotInActive];

            switch (reward.RewardType)
            {
                case RewardType.Wood:
                    CurrencyView.Instance.AddWood(reward.CountCurrency);
                    break;
                case RewardType.Diamond:
                    CurrencyView.Instance.AddDiamond(reward.CountCurrency);
                    break;
            }

            _view.TimeGetReward = DateTime.UtcNow;
            _view.CurrentSlotInActive++;

            RefreshRewardsState();
        }


        private void RefreshRewardsState()
        {
            bool gotRewardEarlier = _view.TimeGetReward.HasValue;
            if (!gotRewardEarlier)
            {
                _isGetReward = true;
                return;
            }

            TimeSpan timeFromLastRewardGetting =
                DateTime.UtcNow - _view.TimeGetReward.Value;

            bool isDeadlineElapsed =
                timeFromLastRewardGetting.Seconds >= _view.TimeDeadline;

            bool isTimeToGetNewReward =
                timeFromLastRewardGetting.Seconds >= _view.TimeCooldown;

            if (isDeadlineElapsed)
                ResetRewardsState();

            _isGetReward = isTimeToGetNewReward;
        }

        private void ResetRewardsState()
        {
            _view.TimeGetReward = null;
            _view.CurrentSlotInActive = 0;
        }


        private void RefreshUi()
        {
            _view.GetRewardButton.interactable = _isGetReward;
            _view.TimerNewReward.text = GetTimerNewRewardText();
            RefreshSlots();
        }

        private string GetTimerNewRewardText()
        {
            if (_isGetReward)
                return "The reward is ready to be received!";

            if (_view.TimeGetReward.HasValue)
            {
                DateTime nextClaimTime = _view.TimeGetReward.Value.AddSeconds(_view.TimeCooldown);
                TimeSpan currentClaimCooldown = nextClaimTime - DateTime.UtcNow;

                var timeRow =  _view.TimeCooldown / 10;
                var secondsPassed = _view.TimeCooldown - currentClaimCooldown.TotalSeconds;
                _simpleProgressBar.Clear();
                for (int i = 0; i < 10; i++)
                {
                    if ((timeRow * i) < secondsPassed)
                        _simpleProgressBar.Append(" |");
                    else
                        _simpleProgressBar.Append("_"); 
                }
                return $"Next reward progress bar: [{_simpleProgressBar} ]";
            }

            return string.Empty;
        }

        private void RefreshSlots()
        {
            for (var i = 0; i < _slots.Count; i++)
            {
                Reward reward = _view.Rewards[i];
                int countDay = i + 1;
                bool isSelected = i == _view.CurrentSlotInActive;

                _slots[i].SetData(reward, countDay, isSelected);
            }
        }
    }
}