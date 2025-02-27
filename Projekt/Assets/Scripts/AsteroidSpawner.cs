using TMPro;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    
    public float playAreaX;
    public float playAreaY;

    public float centerSpawnOffset = 4;

    private float currentSpawnRate = 0;
    private float timer = 0;

    private int score = 0;

    private bool canSpawn = true;

    private void Awake()
    {
        currentSpawnRate = 0.1f;
    }

    private void Update()
    {
        Debug.Log("SPAWN RATE: " + currentSpawnRate);

        if (canSpawn == false) return;

        currentSpawnRate = currentSpawnRate; // LAB 1 ZADANIE 5 ZMIENNE
        currentSpawnRate = Mathf.Clamp(currentSpawnRate, 0.1f, 2); // wartośc nigdy nie jest większa od 2 oraz mniejsza od 0.1f, dzięki temu zawsze spawn rate ma sens

        timer += Time.deltaTime;
        if (timer < 1f / currentSpawnRate) return;
        timer = 0;

        SpawnAsteroid();
        SpawnAsteroid();
        SpawnAsteroid();
        SpawnAsteroid();
    }

    private void SpawnAsteroid()
    {
        GameObject asteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
        Asteroid asteroidScript = asteroid.GetComponent<Asteroid>();
        
        // LAB 1 ZADANIE 3 ZMIENNE
        int randomSize = Random.Range(1, 1);
        asteroidScript.Setup(this, randomSize, false);

        Vector2 spawnPosition;
        bool spawnHorizontal = RandomExtensions.RandomBool();
        if (spawnHorizontal == true)
        {
            spawnPosition = GetVerticalSpawnPosition();
        }
        else
        {
            // LAB 2 ZADANIE 1 METODY
            //spawnPosition = GetHorizontalSpawnPosition();
            spawnPosition = GetVerticalSpawnPosition();
        }
        asteroid.transform.position = spawnPosition;

        Vector2 randomPosition = RandomPositionAroundCenter();
        asteroid.transform.RotateTowards(randomPosition);
    }

    private Vector2 GetVerticalSpawnPosition()
    {
        Vector2 position = new Vector2();
        position.x = Random.Range(-playAreaX, playAreaX);
        bool bottom = RandomExtensions.RandomBool();
        if (bottom == true)
        {
            position.y = -playAreaY;
        }
        else
        {
            position.y = playAreaY;
        }
        return position;
    }

    private Vector2 RandomPositionAroundCenter()
    {
        Vector2 position = new Vector2();
        position.x = Random.Range(-centerSpawnOffset * 2, centerSpawnOffset * 2);
        position.y = Random.Range(-centerSpawnOffset, centerSpawnOffset);
        return position;
    }

    public void StopSpawning()
    {
        canSpawn = false;
    }

    public void AddScore()
    {
        score++;
    }
}