using UnityEngine;

public static class TransformExtensions
{
    public static void RotateTowardsMouse(this Transform transform)
    {
        if (Camera.main == null) return;
        
        var currentPos = transform.position;
        var mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        var angle = Mathf.Atan2(mousePos.y - currentPos.y, mousePos.x - currentPos.x ) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    
    public static void RotateTowards(this Transform transform, Vector2 targetPos)
    {
        if (Camera.main == null) return;
        
        var currentPos = transform.position;
        var angle = Mathf.Atan2(targetPos.y - currentPos.y, targetPos.x - currentPos.x ) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}