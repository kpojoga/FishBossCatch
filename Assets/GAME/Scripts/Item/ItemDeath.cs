using UnityEngine;

public class ItemDeath : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _playerData.collectedDeathItems++;

            _playerData.lives -= 1;
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (_playerData.collectedDeathItems == 3)
        {
            _playerData.isLose = true;
            _playerData.collectedDeathItems = 0;
        }
    }
}
