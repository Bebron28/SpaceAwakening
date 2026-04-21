using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    private float delayTime = 0.8f;
    private float delay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (delay > 0)
        {
            delay -= Time.deltaTime;
        }
        if (Input.GetButtonDown("Fire1") && delay <= 0)
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            delay = delayTime;
        }
    }
}
