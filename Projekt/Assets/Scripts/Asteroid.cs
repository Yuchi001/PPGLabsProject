using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Asteroid : MonoBehaviour
{
    public float hpToSizeScalingFactor = 0.5f;
    public float movementSpeed = 3.0f;
    
    public List<Sprite> asteroidSpriteList;
    public SpriteRenderer spriteRenderer;

    public GameObject asteroidPrefab;

    private bool isMinimum;
    
    private int maxHP;

    private AsteroidSpawner currentAsteroidSpawner; 

    public void Setup(AsteroidSpawner spawner, int size, bool randomRotation)
    {
        maxHP = size;
        
        spriteRenderer.sprite = asteroidSpriteList[0];

        isMinimum = size == 1;
        float scale = Math.Max(size * hpToSizeScalingFactor, 1); // zwraca większą liczbę z tych dwóch przekazanych
        transform.localScale = new Vector2(scale, scale);

        currentAsteroidSpawner = spawner;

        if (randomRotation == false) return;

        int randomAngle = Random.Range(-180, 181);
        Vector3 axis = new Vector3(0, 0, 1);
        transform.Rotate(axis, randomAngle);
    }

    private void Update()
    {
        transform.position += transform.up * (movementSpeed * Time.deltaTime);
    }

    public void Hit()
    {
        currentAsteroidSpawner.AddScore();
        
        if (isMinimum == false)
        {
            GameObject asteroid1 = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            Asteroid asteroidScript1 = asteroid1.GetComponent<Asteroid>();
            asteroidScript1.Setup(currentAsteroidSpawner, maxHP - 1, true);
            
            GameObject asteroid2 = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            Asteroid asteroidScript2 = asteroid2.GetComponent<Asteroid>();
            asteroidScript2.Setup(currentAsteroidSpawner, maxHP - 1, true);
            
            GameObject asteroid3 = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
            Asteroid asteroidScript3 = asteroid3.GetComponent<Asteroid>();
            asteroidScript3.Setup(currentAsteroidSpawner, maxHP - 1, true);
        }
        
        Destroy(gameObject);
    }
}