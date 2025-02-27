using UnityEngine;

public class Cursor : MonoBehaviour
{
    private void Awake()
    {
        UnityEngine.Cursor.visible = false;
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }
}