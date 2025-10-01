using UnityEngine;

public class Mascot : MonoBehaviour
{
    public GameObject[] mascotImages;
    [SerializeField] private GameObject _parentMascot;
    [SerializeField] private GameObject _welcomePanel;
    [SerializeField] private GameObject _parentCameraZoom;
    [SerializeField] private GameObject _game;
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private CameraZoom _cameraZoom;

    private int currentMascotIndex = 0; 
    private bool isActive = true;

    void Start()
    {
        _game.SetActive(false);
        _welcomePanel.SetActive(true);
    }
    
    public void CloseWelcomePanel()
    {
        _playerData.coins += 200;
        _welcomePanel.SetActive(false);
        _game.SetActive(true);
    }
    
    public void ShowNextMascot()
    {
        currentMascotIndex++;
        
        if (currentMascotIndex >= mascotImages.Length)
        {
            isActive = false;
            _parentMascot.SetActive(false);
            _game.SetActive(true);

            _cameraZoom.StartButtonPressed();

            _cameraZoom = _parentCameraZoom.GetComponent<CameraZoom>();

            if (_cameraZoom != null)
            {
                _cameraZoom.StartButtonPressed();
            }
        }
    }
}
