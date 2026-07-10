using UnityEngine;
using UnityEngine.InputSystem;

public class InsectGameMouseFacer : MonoBehaviour
{
    public GameObject ExitPoint;
    void Update()
    {
        float angle = GetAngle();
        print("Angle0: " + angle);
        angle = ConstrainAngle(angle);
        print("    Angle: " + angle);
        ExitPoint.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private float ConstrainAngle(float angle)
    {
        
        // Remap from 0-360 into -180 to 180
        if (angle > 180f)
            angle -= 360f;
        
        if (angle < -75f)
            angle = -75f;
        else if (angle > 75f)
            angle = 75f;
        
        return angle;
    }

    private float GetAngle()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        float angle = CalculateAngle(mouseWorld);
        return angle;
    }

    private float CalculateAngle(Vector3 targetPosition)
    {
        Vector2 direction = (targetPosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        angle = angle + 90f;
        return angle;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }
}
