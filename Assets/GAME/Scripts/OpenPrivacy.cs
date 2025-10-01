using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPrivacy : MonoBehaviour
{
    [SerializeField] private GameObject _privacyPanel;
    
    public void OpenPrivacyPanel()
    {
        _privacyPanel.SetActive(true);
    }

    public void ClosePrivacy()
    {
        _privacyPanel.SetActive(false);
    }
}
