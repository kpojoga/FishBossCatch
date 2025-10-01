using UnityEngine;

public class SkyboxRotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _speed);
    }
}
