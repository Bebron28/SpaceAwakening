using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public int sceneNumber;
    public void Setup()
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(sceneNumber);
        Time.timeScale = 1.0f;
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
}
