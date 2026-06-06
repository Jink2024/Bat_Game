using UnityEngine;

public class InsectGameProjectile : MonoBehaviour
{
    public InsectGameInsectEcho InsectGameInsectEcho;
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

        if (other.CompareTag("Insect"))
        {
            print ("hit insect");
            InsectGameInsectEcho.FireAtBat();
            return;

            // make insect shoot wave at bat
        }
    }
}
