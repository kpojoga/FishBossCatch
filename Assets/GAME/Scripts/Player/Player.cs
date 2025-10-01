using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private GameObject _player;

    private void Start()
    {
        _playerData.lives = 3;
    }

    private void Update()
    {
        UpdateData();
    }

    private void UpdateData()
    {
        var _startScale = _player.transform.localScale;
        if (_playerData.collectedItems >= 10)
        {
            _playerData.playerLevel++;
            _playerData.collectedItems = 0;
            _playerData.coins += 15;
            _player.transform.localScale = (_startScale) * 1.1f;
        }
    }
}
