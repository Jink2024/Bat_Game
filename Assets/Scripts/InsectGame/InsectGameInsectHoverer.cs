using UnityEngine;

/// <summary>
/// Moves a sprite in an organic, hovering pattern reminiscent of a small insect.
/// Attach to any GameObject with a SpriteRenderer. The sprite wanders within a
/// small radius using layered Perlin noise so the motion never quite repeats.
/// </summary>
public class InsectHoverer : MonoBehaviour
{
    [Header("Wander Area")]
    [Tooltip("How far from the origin the bug can drift, in world units.")]
    public float wanderRadius = 1.2f;

    [Tooltip("World-space center of the hover area. Defaults to the object's start position.")]
    public Vector2 origin;

    [Header("Movement Feel")]
    [Tooltip("Base speed of the drift. Higher values = more frantic.")]
    public float driftSpeed = 1.8f;

    [Tooltip("How quickly the noise time advances. Controls jitter frequency.")]
    public float noiseFrequency = 0.9f;

    [Tooltip("Small rapid jitter layered on top of the main drift.")]
    public float jitterAmount = 0.06f;

    [Tooltip("Frequency of the high-frequency jitter layer.")]
    public float jitterFrequency = 4.5f;

    [Header("Vertical Bob")]
    [Tooltip("How far the bug bobs up and down.")]
    public float bobAmplitude = 0.08f;

    [Tooltip("Speed of the vertical bob cycle.")]
    public float bobFrequency = 3.2f;

    // Perlin noise is deterministic, so we offset each axis by a large prime
    // to make X and Y feel independent.
    private float noiseOffsetX;
    private float noiseOffsetY;
    private float timeAccum;

    private void Awake()
    {
        origin = transform.position;

        // Random offsets so two bugs placed at the same spot diverge immediately.
        noiseOffsetX = Random.Range(0f, 1000f);
        noiseOffsetY = Random.Range(0f, 1000f);

        // Start time at a random point so bugs don't sync up.
        timeAccum = Random.Range(0f, 100f);
    }

    private void Update()
    {
        // evens out movwment based on fps
        timeAccum += Time.deltaTime * driftSpeed;

        // --- Main drift via Perlin noise ---
        // Perlin returns [0,1]; remap to [-1,1].
        // makes new x and y mon smooth curve (makes things pretty and smooth)
        float nx = Mathf.PerlinNoise(timeAccum * noiseFrequency + noiseOffsetX, 0f) * 2f - 1f;
        float ny = Mathf.PerlinNoise(0f, timeAccum * noiseFrequency + noiseOffsetY) * 2f - 1f;

        Vector2 drift = new Vector2(nx, ny) * wanderRadius;

        // Soft-clamp so the bug stays within the wander radius without hard bouncing.
        if (drift.magnitude > wanderRadius)
        {
            drift = drift.normalized * wanderRadius;
        }

        // --- High-frequency jitter layer ---
        float jx = Mathf.PerlinNoise(timeAccum * jitterFrequency + noiseOffsetY, 13.7f) * 2f - 1f;
        float jy = Mathf.PerlinNoise(31.4f, timeAccum * jitterFrequency + noiseOffsetX) * 2f - 1f;

        Vector2 jitter = new Vector2(jx, jy) * jitterAmount;

        // --- Vertical bob ---
        float bob = Mathf.Sin(timeAccum * bobFrequency) * bobAmplitude;

        // --- Combine and apply ---
        Vector3 target = new Vector3(
            origin.x + drift.x + jitter.x,
            origin.y + drift.y + jitter.y + bob,
            transform.position.z
        );

        transform.position = target;
    }

    /// <summary>
    /// Call this to relocate the hover area center at runtime.
    /// </summary>
    public void SetOrigin(Vector2 newOrigin)
    {
        origin = newOrigin;
    }

#if UNITY_EDITOR
    // Draw the wander area in the Scene view for easy tuning.
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0.3f, 1f, 0.4f, 0.35f);
        Vector3 center = Application.isPlaying
            ? new Vector3(origin.x, origin.y, transform.position.z)
            : transform.position;
        Gizmos.DrawWireSphere(center, wanderRadius);
    }
#endif
}