using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{   
    [Header("Panels")]
    [SerializeField] private GameObject _main;
    [SerializeField] private GameObject _settings;
    [SerializeField] private GameObject _shop;

    public void OpenMain()
    {
        _shop.SetActive(false);
        _settings.SetActive(false);
        _main.SetActive(true);
    }

    public void OpenSettings()
    {
        _main.SetActive(false);
        _settings.SetActive(true);
    }

    public void CloseSettings()
    {
        _main.SetActive(true);
        _settings.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OpenShop()
    {
        _shop.SetActive(true);
    }

}
