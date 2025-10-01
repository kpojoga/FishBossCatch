using UnityEngine;

public class ItemPool : MonoBehaviour
{

    [SerializeField] private GameObject _itemDeath;
    [SerializeField] private Transform _parentDeathItems;

    public GameObject[] objectPrefabs;

    public Vector3 sphereSize = new Vector3(40f, 40f, 40f);

    [SerializeField] private Transform _parent;

    [SerializeField] private PlayerData _playerData;


    private void Start()
    {
        SpawnDeathItems(5);
    }

    void Update()
    {
        CheckItemCount();
        int numberOfObjects = Random.Range(10, 15);
        if (_parent.childCount < 12)
        {
            SpawnObjects(numberOfObjects);
        }

        if(_playerData.playerLevel == 35)
        {
            int childCount = _parent.transform.childCount;

            
            GameObject[] children = new GameObject[childCount];

          
            for (int i = 0; i < childCount; i++)
            {

                Debug.Log("DKWDKWN");
                children[i] = _parent.transform.GetChild(i).gameObject;
            }

           
            foreach (GameObject child in children)
            {
                Destroy(child);
            }
            _playerData.playerLevel = 0;
            SpawnObjects(numberOfObjects);
        }
    }

    void SpawnObjects(int count)
    {
        int playerLevel = _playerData.playerLevel;

        for (int i = 0; i < count; i++)
        {
            GameObject selectedPrefab = null;

            int randomIndex = Random.Range(0, objectPrefabs.Length);

            Item itemComponent = objectPrefabs[randomIndex].GetComponent<Item>();

            int prefabLevel = itemComponent != null ? itemComponent._itemLevel : 0;

            if (Mathf.Abs(prefabLevel - playerLevel) <= 1)
            {
                selectedPrefab = objectPrefabs[randomIndex];
            }
            else
            {
               
                i--; 
            }

            if (selectedPrefab != null)
            {
                Vector3 spawnPosition = Random.onUnitSphere * (sphereSize.x / 2f);

                Instantiate(selectedPrefab, spawnPosition, Quaternion.identity, _parent);
            }
        }
    }

    private void SpawnDeathItems(int count)
    {
        for(int i = 0; i < 5; i++)
        {
            Vector3 spawnPosition = Random.onUnitSphere * (sphereSize.x / 2f);
            Instantiate(_itemDeath, spawnPosition, Quaternion.identity, _parentDeathItems);
        }
    }
   
    public void CheckItemCount()
    {
        int currentItemCount = GameObject.FindGameObjectsWithTag("ItemDeath").Length;
        int itemCountToSpawn = 5 - currentItemCount;
        if (itemCountToSpawn > 0)
        {
            SpawnDeathItems(itemCountToSpawn);
        }
    }
}
