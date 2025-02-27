using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float movementSpeed = 3;
    private float timer = 0;
    
    private void Update()
    {
        // LAB 1 ZADANIE 2 ZMIENNE
        transform.position += transform.up * Time.deltaTime;
        
        // LAB 2 ZADANIE 1 ZMIENNE
        timer += Time.deltaTime;
        if (timer < 0) return;
        
        Destroy(gameObject);
        timer = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") == true)
        {
            Asteroid hitAsteroid = other.GetComponent<Asteroid>();
            hitAsteroid.Hit();
            Destroy(gameObject);
        }
    }
}