using UnityEngine;

public class InsectGameProjectile : MonoBehaviour
{
    public GameObject EchoPrefab;
    public float echoSpawnInterval = 0.15f;

    private InsectGameLauncher insectGameLauncher;
    private Rigidbody2D projectileRigidbody;
    private float distanceTravelled;
    private Vector2 lastPosition;

    protected virtual void Awake()
    {
        projectileRigidbody = GetComponent<Rigidbody2D>();
        lastPosition = transform.position;
    }

    protected virtual void Update()
    {
        distanceTravelled += Vector2.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        if (distanceTravelled >= echoSpawnInterval)
        {
            distanceTravelled = 0f;
            SpawnEcho();
        }
    }

    private void SpawnEcho()
    {
        Instantiate(EchoPrefab, transform.position, transform.rotation);
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
            return;
        }
    }
}