using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    public float boostForceMagnitude;
    
    public Rigidbody2D rigidbody2D;
    public GameObject bulletPrefab;
    public Transform hitPosition;

    public float playAreaX;
    public float playAreaY;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, hitPosition.position, transform.rotation);
        }

        // LAB 1 ZADANIE 1 OPERACJE LOGICZNE
        if (false)
        {
            rigidbody2D.AddForce(transform.up * (boostForceMagnitude * Time.deltaTime), ForceMode2D.Impulse);
        }
        
        if (false)
        {
            rigidbody2D.AddForce(-rigidbody2D.velocity * Time.deltaTime, ForceMode2D.Impulse);
        }
        
        if (false)
        {
            transform.Rotate(new Vector3(0, 0, 1), 90 * Time.deltaTime);
        }
        
        if (false)
        {
            transform.Rotate(new Vector3(0, 0, 1), -90 * Time.deltaTime);
        }
        

        CheckIfOutOfScene();
    }

    private void CheckIfOutOfScene()
    {
        Vector2 newPosition = transform.position;
        if (transform.position.x > playAreaX) newPosition.x = -playAreaX;
        if (transform.position.x < -playAreaX) newPosition.x = playAreaX;
        // LAB 1 ZADANIE 3 OPERACJE LOGICZNE
        transform.position = newPosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject hitObject = other.gameObject;
        return;
        
        // LAB 1 ZADANIE 2 OPERACJE LOGICZNE

        Destroy(gameObject);
    }
}
