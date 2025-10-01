using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private PlayerData _playerData;
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private TextMeshProUGUI _coinsText;
    [SerializeField] private TextMeshProUGUI _coinsText2;
    [SerializeField] private TextMeshProUGUI _livesText;
    [Header("Image")]
    [SerializeField] private Image _levelProgress;

    private void Update()
    {
        UpdateText();
        UpdateLevelProgress();
    }

    private void UpdateText()
    {
        _levelText.text = _playerData.playerLevel.ToString();

        _coinsText.text = _playerData.coins.ToString();
        _coinsText2.text = _playerData.coins.ToString();

        _livesText.text = _playerData.lives.ToString();
    } 

    private void UpdateLevelProgress()
    {
        _levelProgress.fillAmount = (float)_playerData.collectedItems / 10;
    }

}
