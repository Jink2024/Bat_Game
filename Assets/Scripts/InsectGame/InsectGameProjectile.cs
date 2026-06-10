using UnityEngine;

public class InsectGameProjectile : MonoBehaviour
{
    private InsectGameLauncher insectGameLauncher;
    private Rigidbody2D projectileRigidbody;
    
    protected virtual void Awake()
    {
        projectileRigidbody = GetComponent<Rigidbody2D>();
    }
    
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
            print("hit slot trigger");
            return;
        }

      
    }
}
