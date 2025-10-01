using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int playerLevel;

    public void IncreaseItemLevel()
    {
        playerLevel++;

        GameObject[] levelObjects = GameObject.FindGameObjectsWithTag("LevelObject");

        foreach (GameObject obj in levelObjects)
        {
            GameObject lockObject = obj.transform.Find("Lock").gameObject;

            lockObject.SetActive(false);
        }
    }
}
