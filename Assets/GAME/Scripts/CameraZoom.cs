using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Transform _target; 
    public float _zoomSpeed = 2f;
    public float _minZoomDistance = 2f;

    [SerializeField] private GameObject _joystick;
    [SerializeField] private GameObject _startButton;
    [SerializeField] private PlayerData _playerData;

    private bool _isZooming = false; 
    private bool _isPressed = false; 

    void Update()
    {
        if (_isPressed)
        {
            _isZooming = true;
            _joystick.SetActive(true);
        }

        if (_isZooming)
        {
            ZoomIn();
        }
    }
 
    void ZoomIn()
    {
        Vector3 targetPosition = _target.position;
        Vector3 newPosition = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * _zoomSpeed);

        float distance = Vector3.Distance(newPosition, targetPosition);
        if (distance < _minZoomDistance)
        {
            newPosition = targetPosition + (transform.position - targetPosition).normalized * _minZoomDistance;
            _isZooming = false;
        }

        transform.position = newPosition;
    }

    public void StartButtonPressed()
    {
        _isPressed = true;
        _startButton.SetActive(false);
        
    }
}
