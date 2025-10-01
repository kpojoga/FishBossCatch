using UnityEngine;
using TMPro;

public class ShopDrones : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private PlayerData _playerData;
    [Header("Drone in game")]
    [SerializeField] private GameObject _drone1;
    [SerializeField] private GameObject _drone2;
    [SerializeField] private GameObject _drone3;
    [SerializeField] private GameObject _drone4;
    [SerializeField] private GameObject _drone5;
    [Header("Drone in feed Room")]
    [SerializeField] private GameObject _droneInRoom1;
    [SerializeField] private GameObject _droneInRoom2;
    [SerializeField] private GameObject _droneInRoom3;
    [SerializeField] private GameObject _droneInRoom4;
    [SerializeField] private GameObject _droneInRoom5;
    [Header("Text Buy")]
    [SerializeField] private TextMeshProUGUI _buyText1;
    [SerializeField] private TextMeshProUGUI _buyText2;
    [SerializeField] private TextMeshProUGUI _buyText3;
    [SerializeField] private TextMeshProUGUI _buyText4;
    [SerializeField] private TextMeshProUGUI _buyText5;
    [Header("Text price")]
    [SerializeField] private TextMeshProUGUI _priceText1;
    [SerializeField] private TextMeshProUGUI _priceText2;
    [SerializeField] private TextMeshProUGUI _priceText3;
    [SerializeField] private TextMeshProUGUI _priceText4;
    [SerializeField] private TextMeshProUGUI _priceText5;
    [Header("Coin Image")]
    [SerializeField] private GameObject _coin1;
    [SerializeField] private GameObject _coin2;
    [SerializeField] private GameObject _coin3;
    [SerializeField] private GameObject _coin4;
    [SerializeField] private GameObject _coin5;
    
    public void BuyDrone1()
    {
        if (_playerData.hasDrone1 == false && _playerData.coins >= 100)
        {
            _playerData.coins -= 100;
            _playerData.hasDrone1 = true;
        }
        if (_playerData.hasDrone1 == true)
        {
            _buyText1.text = "set";
            _priceText1.text = "";
            _coin1.SetActive(false);

            _drone1.SetActive(true);
            _drone2.SetActive(false);
            _drone3.SetActive(false);
            _drone4.SetActive(false);
            _drone5.SetActive(false);

            _droneInRoom1.SetActive(true);
            _droneInRoom2.SetActive(false);
            _droneInRoom3.SetActive(false);
            _droneInRoom4.SetActive(false);
            _droneInRoom5.SetActive(false);
        }
    }
    
    public void BuyDrone2()
    {
        if(_playerData.hasDrone2 == false && _playerData.coins >= 150)
        {
            _playerData.coins -= 150;
            _playerData.hasDrone2 = true;
        }
        if (_playerData.hasDrone2 == true)
        {
            _buyText2.text = "set";
            _priceText2.text = "";
            _coin2.SetActive(false);

            _drone1.SetActive(false);
            _drone2.SetActive(true);
            _drone3.SetActive(false);
            _drone4.SetActive(false);
            _drone5.SetActive(false);

            _droneInRoom1.SetActive(false);
            _droneInRoom2.SetActive(true);
            _droneInRoom3.SetActive(false);
            _droneInRoom4.SetActive(false);
            _droneInRoom5.SetActive(false);
        }
    }
    
    public void BuyDrone3()
    {
        if (_playerData.hasDrone3 == false && _playerData.coins >= 250)
        {
            _playerData.coins -= 250;
            _playerData.hasDrone3 = true;
        }
        if (_playerData.hasDrone3 == true)
        {
            _buyText3.text = "set";
            _priceText3.text = "";
            _coin3.SetActive(false);

            _drone1.SetActive(false);
            _drone2.SetActive(false);
            _drone3.SetActive(true);
            _drone4.SetActive(false);
            _drone5.SetActive(false);

            _droneInRoom1.SetActive(false);
            _droneInRoom2.SetActive(false);
            _droneInRoom3.SetActive(true);
            _droneInRoom4.SetActive(false);
            _droneInRoom5.SetActive(false);
        }
    }
    
    public void BuyDrone4()
    {
        if (_playerData.hasDrone4 == false && _playerData.coins >= 350)
        {
            _playerData.coins -= 350;
            _playerData.hasDrone4 = true;
        }
        if (_playerData.hasDrone4 == true)
        {
            _buyText4.text = "set";
            _priceText4.text = "";
            _coin4.SetActive(false);

            _drone1.SetActive(false);
            _drone2.SetActive(false);
            _drone3.SetActive(false);
            _drone4.SetActive(true);
            _drone5.SetActive(false);

            _droneInRoom1.SetActive(false);
            _droneInRoom2.SetActive(false);
            _droneInRoom3.SetActive(false);
            _droneInRoom4.SetActive(true);
            _droneInRoom5.SetActive(false);
        }
    }
    
    public void BuyDrone5()
    {
        if (_playerData.hasDrone5 == false && _playerData.coins >= 450)
        {
            _playerData.coins -= 450;
            _playerData.hasDrone5 = true;

        }
        if(_playerData.hasDrone5 == true)
        {
            _buyText5.text = "set";
            _priceText5.text = "";
            _coin5.SetActive(false);

            _drone1.SetActive(false);
            _drone2.SetActive(false);
            _drone3.SetActive(false);
            _drone4.SetActive(false);
            _drone5.SetActive(true);

            _droneInRoom1.SetActive(false);
            _droneInRoom2.SetActive(false);
            _droneInRoom3.SetActive(false);
            _droneInRoom4.SetActive(false);
            _droneInRoom5.SetActive(true);
        }
    }
}
