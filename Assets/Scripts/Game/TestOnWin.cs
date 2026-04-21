using UnityEngine;

public class TestOnWin : MonoBehaviour
{
    private float gameTimer = 30f;
    public WinScreen winScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameTimer -= Time.deltaTime;

        if (gameTimer <= 0)
        {
            winScreen.Setup();
            Time.timeScale = 0f;
        }
    }
}
