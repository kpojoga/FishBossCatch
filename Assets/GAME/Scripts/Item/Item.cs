using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] public int _itemLevel;
    [SerializeField] private PlayerData _playerData;
    public Rigidbody _itemRigidbody;
    
    
    public GameObject planet; 
    public float radius = 15.0f;
    public float speed = 3.0f; 
    private Vector3 direction;

    void Awake()
    {
        _itemRigidbody = GetComponent<Rigidbody>();
    }

    
    void Start()
    {
        direction = transform.forward;
    }
    
    private void Update()
    {
        UnlockItem();
        
        Vector3 planetCenter = planet.transform.position;
        Vector3 currentPos = transform.position;

        Vector3 normalizedPos = (currentPos - planetCenter).normalized;

        Vector3 newPos = currentPos + direction * speed * Time.deltaTime;

        Vector3 newNormalizedPos = (newPos - planetCenter).normalized;
        transform.position = planetCenter + newNormalizedPos * radius;

        direction = Vector3.ProjectOnPlane(direction, newNormalizedPos).normalized;

        transform.rotation = Quaternion.LookRotation(direction, newNormalizedPos);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(_itemLevel <= _playerData.playerLevel && collision.gameObject.tag == "Player")
        {
            _playerData.collectedItems++;
            Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Planet")
        {
            _itemRigidbody.constraints = RigidbodyConstraints.FreezePosition;

            _itemRigidbody.constraints = RigidbodyConstraints.FreezeRotation;

        }
    }
    
    public void UnlockItem()
    {
        Transform chield = gameObject.transform.GetChild(0);

        if (chield != null && _itemLevel <= _playerData.playerLevel)
        {
            chield.gameObject.SetActive(false);
        }
    }
}
