using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStateChange : MonoBehaviour
{
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GameObject _game;
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private GameObject _player;

    private void Update()
    {
        if(_playerData.isLose == true)
        {
            _deathPanel.SetActive(true);
            _game.SetActive(false);
        }
    }

    public void Restart()
    {
        
        _game.SetActive(true);
        _deathPanel.SetActive(false);
        _playerData.isLose = false;
        _playerData.collectedItems = 0;
        _playerData.lives = 3;
        _player.transform.position = new Vector3(0f,15f,0f);
    }

}
