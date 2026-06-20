using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;

public class InsectGameInsect : MonoBehaviour
{
    public List<Transform> RestingPositions;
    private bool isMoving = true;
    private Transform newRestingPosition;
    private Coroutine restingCountdownCoroutine;
    private const float ArrivalDistance = 0.1f;
    private bool isLeaving = false;
    protected virtual float MovementSpeed => InsectGameGameParameters.InsectMovementSpeed;

    InsectGameUI InsectGameUI;
    public SpriteRenderer spriteRenderer;
    public InsectGameInsectEcho InsectGameInsectEcho;
    public Sprite ReturnSprite;
    
    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(RemainOnScreenCountdown());
    }
    
    public void Update()
    {
        //Move(Vector2.left);
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
        }
        
        if (other.CompareTag("BatEcho"))
        {
            //InsectGameInsectEcho.FireAtBat();
            print("BatEcho");
            // make game say: You found an insect
            
            //wait a few seconds then destroy insect?
            
            Destroy(gameObject, 1f);

            AddToScore();
            LaunchReturnEcho(other.gameObject);
            CircleCollider2D circleCollider2D = gameObject.GetComponent<CircleCollider2D>();
            circleCollider2D.enabled = false;
        }

        if (other.CompareTag("InsectEcho"))
        {
            return;
        }
    }

    private void AddToScore()
    {
        InsectGameScoreKeeper.AddToScore(1);
    }

    private void LaunchReturnEcho(GameObject echo)
    {
        Rigidbody2D projectileRigidbody = echo.GetComponent<Rigidbody2D>();
        projectileRigidbody.linearVelocity = -projectileRigidbody.linearVelocity;
        
        echo.transform.rotation = Quaternion.Euler(0f, 0f, echo.transform.eulerAngles.z + 180f);
        
        SpriteRenderer spriteRenderer = echo.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = ReturnSprite;
    }


    public IEnumerator RemainOnScreenCountdown()
    {
        yield return new WaitForSeconds(InsectGameGameParameters.InsectExistTimeInSeconds);
        isLeaving = true;
    }

    public void Move(Vector2 direction)
    {
        if (isLeaving) direction.y = 1;
        //FaceCorrectDirection(direction);
        Vector2 movementAmount = MovementSpeed * InsectGameGameParameters.InsectMovementSpeed * direction * Time.deltaTime;
        spriteRenderer.transform.Translate(movementAmount.x, movementAmount.y, 0);
        //AddScreenConstraints();
    }

    public virtual void AddScreenConstraints()
    {
        if (!isLeaving) spriteRenderer.transform.position = SpriteTools.ConstrainToScreen(spriteRenderer);
    }

    private void FaceCorrectDirection(Vector2 direction)
    {
        if (direction.x >= 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
    
    /*
    private void CheckArrival()
    {
        //if (newRestingPosition == null) return;

        float distance = Vector2.Distance(transform.position, newRestingPosition.position);

        if (distance < ArrivalDistance)
        {
            if (restingCountdownCoroutine != null)
                StopCoroutine(restingCountdownCoroutine);

            restingCountdownCoroutine =
                StartCoroutine(RestingCountdown());
        }
    }
    
    private void MoveTowardsRestingPosition()
    {
        Vector2 direction = GetMovementDirection();
        
        Vector2 movementAmount = direction * (InsectGameGameParameters.InsectMovementSpeed * Time.deltaTime);

        Move(direction);

    }

    private Vector2 GetMovementDirection()
    {
        if (newRestingPosition ==null) 
            newRestingPosition = GetRandomRestingPositionLocation();
        
        Vector2 moveDirection = newRestingPosition.position - transform.position;
        return moveDirection.normalized;
    }

    private Transform GetRandomRestingPositionLocation()
    {
        int randomRestingPositionNumber = Random.Range(0, RestingPositions.Count);
        return RestingPositions[randomRestingPositionNumber];
    }

    private IEnumerator RestingCountdown()
    {
        isMoving = false;
       
        yield return new WaitForSeconds(InsectGameGameParameters.InsectRestTimeInSeconds);
        isMoving = true;
        newRestingPosition = GetRandomRestingPositionLocation();
        MoveTowardsRestingPosition();
    }
    */
}
