using UnityEngine;

public class InsectGameLauncher : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform ProjectileSpawnPoint;

    public void Launch(Vector2 aimDirection)
    {
        GameObject projectileObject = Instantiate(ProjectilePrefab, ProjectileSpawnPoint.position, Quaternion.identity);
        
        LauchProjectile(projectileObject, aimDirection);
    }

    private void LauchProjectile(GameObject projectileObject, Vector2 aimDirection)
    {
        Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
        
        projectileRigidbody.AddForce(aimDirection * 8f, ForceMode2D.Impulse);
    }
}
