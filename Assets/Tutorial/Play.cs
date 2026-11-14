using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    [SerializeField] private string sceneName = "Game";

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName);
    }
  
}