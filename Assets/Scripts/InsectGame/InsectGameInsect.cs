using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InsectGameInsect : MonoBehaviour
{
    public List<Transform> RestingPositions;
    private bool isMoving = true;
    private Transform newRestingPosition;
    private Coroutine restingCountdownCoroutine;
    private const float ArrivalDistance = 0.1f;
   
    public InsectGameInsectEcho InsectGameInsectEcho;
   
    private SpriteRenderer spriteRenderer;
    private bool isLeaving = false;
    protected virtual float MovementSpeed => InsectGameGameParameters.InsectMovementSpeed;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(RemainOnScreenCountdown());
        
        MoveTowardsRestingPosition();
    }
    
    public void Update()
    {
        //Move(Vector2.left);
        if (isMoving)
        {
            //Move();
            //MoveTowardsRestingPosition();
            //CheckArrival();
        }
    }

    public virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("SlotTrigger"))
        {
            Destroy(gameObject);
        }
        
        if (other.CompareTag("BatEcho"))
        {
            print ("hit insect with bat echo");
            InsectGameInsectEcho.FireAtBat();
            return;

            // make insect shoot wave at bat
        }

        if (other.CompareTag("InsectEcho"))
        {
            print ("hit with insect echo");
        }
    }

    public IEnumerator RemainOnScreenCountdown()
    {
        yield return new WaitForSeconds(InsectGameGameParameters.InsectExistTimeInSeconds);
        isLeaving = true;
    }

    public void Move(Vector2 direction)
    {
        if (isLeaving) direction.y = 1;
        FaceCorrectDirection(direction);
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
    
}
