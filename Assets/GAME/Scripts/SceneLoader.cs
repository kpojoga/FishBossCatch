using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }
}
