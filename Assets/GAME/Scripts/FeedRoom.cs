using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FeedRoom : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;

    public GameObject[] foodItems;
    public Button feedButton; 
    public TextMeshProUGUI outOfFoodText; 
    public TextMeshProUGUI nodroneText;

    private int feedCount = 0;
    private bool outOfFood = false;
    private float lastFeedTime;

    void Start()
    {
        lastFeedTime = Time.time;
        feedButton.onClick.AddListener(FeedHero);
        UpdateFoodPanel();
    }

    void Update()
    {
        if (_playerData.hasDrone1 ||
          _playerData.hasDrone2 ||
          _playerData.hasDrone3 ||
          _playerData.hasDrone4 ||
          _playerData.hasDrone5)
        {
            nodroneText.text = "";
        }
        if (feedCount >= 3 && !outOfFood)
        {
            outOfFood = true;
            outOfFoodText.gameObject.SetActive(true);
            StartCoroutine(ResetFood());
        }
    }

    
    void FeedHero()
    {
        if (_playerData.hasDrone1 ||
          _playerData.hasDrone2 ||
          _playerData.hasDrone3 ||
          _playerData.hasDrone4 ||
          _playerData.hasDrone5)
        {
           
            if (foodItems.Length > 0 && Time.time - lastFeedTime >= 3600f)
            {
                lastFeedTime = Time.time;
                feedCount++; 
                UpdateFoodPanel();
            }
            else if (feedCount < 3) 
            {
                feedCount++;
                UpdateFoodPanel();
            }
        }
    }
    
    void UpdateFoodPanel()
    {
        for (int i = 0; i < foodItems.Length; i++)
        {
            foodItems[i].SetActive(i < 3 - feedCount);
        }
    }
  
    IEnumerator ResetFood()
    {
        yield return new WaitForSeconds(3600f); 
        feedCount = 0;
        outOfFood = false;
        outOfFoodText.gameObject.SetActive(false);
        UpdateFoodPanel();
    }
}
