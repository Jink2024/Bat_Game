using UnityEngine;

public class InsectGameLauncher : MonoBehaviour
{
    public GameObject ProjectilePrefab;
    public Transform ProjectileSpawnPoint;

    public void Launch(Vector2 aimDirection)
    {
        GameObject projectileObject = Instantiate(ProjectilePrefab, ProjectileSpawnPoint.position, Quaternion.identity);
        
        LaunchProjectile(projectileObject, aimDirection);
    }

    private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
    {
        Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
        projectileRigidbody.AddForce(aimDirection * 20f, ForceMode2D.Impulse);
        
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        projectileObject.transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
