using UnityEditor;
using UnityEngine;

public class InsectGameInsectEcho : MonoBehaviour
{
    public InsectGameLauncher insectGameLauncher;

    //private Player player;
    public GameObject bat;
    private InsectGameGame game;
    [SerializeField] private float attackDelay = 2f;
    private float spawnTime;
    private void Awake()
    {
        //launcher = GetComponentInParent<Launcher>();
        bat = FindAnyObjectByType<GameObject>();
        // bat = GameObject.Find("Bat");
        //game = FindAnyObjectByType<Game>();
        spawnTime = Time.time;
    }

    private void Update()
    {
        //if (!game.IsGameRunning())
         //   return;
        
    }

    private Vector2 GetAimDirection()
    {
        return
            (bat.transform.position - transform.position)
            .normalized;
    }

    public void AimAtBat()
    {
        Vector2 direction = GetAimDirection();

        float angle =
            Mathf.Atan2(direction.y, direction.x)
            * Mathf.Rad2Deg;

        transform.rotation =
            Quaternion.Euler(0f, 0f, angle - 90f);
    }

    public void FireAtBat()
    {
        AimAtBat();
        
        //if (Time.time < spawnTime + attackDelay)
            //return;

        insectGameLauncher.Launch(GetAimDirection());
    }
}
