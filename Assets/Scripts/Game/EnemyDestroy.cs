using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField]private DeathScreen deathScreen;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Boundary")
        {
            GameObject player = GameObject.FindWithTag("Player");

            if (player != null)
            {
                PlayerLives playerLives = player.GetComponent<PlayerLives>();

                if (playerLives != null)
                {
                    Destroy(gameObject);
                    playerLives.lives--;
                    for (int i = 0; i < playerLives.livesUI.Length; i++)
                    {
                        if (i < playerLives.lives)
                        {
                            playerLives.livesUI[i].enabled = true;
                        }
                        else
                        {
                            playerLives.livesUI[i].enabled = false;
                        }
                    }
                    if (playerLives.lives <= 0)
                    {
                        Destroy(player);
                        deathScreen.Setup();
                    }
                }
            }
        }
    }
}
