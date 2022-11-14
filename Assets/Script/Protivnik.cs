
using UnityEngine;

public class Protivnik : MonoBehaviour
{
    public float MaxMovementSpeed;
    private Rigidbody2D rb;
    private Vector2 startingPosition;
    public Rigidbody2D Puck;
    public Transform PlayerBoundaryHolder;
    private Boundary playerBoundary;
    public Transform PuckBoundaryHolder;
    private Boundary puckBoundary;
    private Vector2 targetPosition;
    private bool isFirstTimeInOpponentsHalf = true;
    private float offsetXFromTarget;
    public GameObject ball;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = rb.position;

        playerBoundary = new Boundary(PlayerBoundaryHolder.GetChild(0).position.x,
                              PlayerBoundaryHolder.GetChild(1).position.x,
                              PlayerBoundaryHolder.GetChild(2).position.y,
                              PlayerBoundaryHolder.GetChild(3).position.y);
        puckBoundary = new Boundary(PuckBoundaryHolder.GetChild(0).position.x,
                              PuckBoundaryHolder.GetChild(1).position.x,
                              PuckBoundaryHolder.GetChild(2).position.y,
                              PuckBoundaryHolder.GetChild(3).position.y);
        
        
    }

    private void FixedUpdate()
    {
        float movementSpeed;

        if (Puck.position.x < puckBoundary.Right)

        {
            if (isFirstTimeInOpponentsHalf)
            {
                isFirstTimeInOpponentsHalf = false;
                offsetXFromTarget = Random.Range(1f, 1f);
            }

            movementSpeed = MaxMovementSpeed * Random.Range(0.1f, 0.3f);
            targetPosition = new Vector2(Mathf.Clamp(Puck.position.y + offsetXFromTarget, playerBoundary.Down,
                                                    playerBoundary.Up),
                                        startingPosition.x);

        }
        else
        
            {
                isFirstTimeInOpponentsHalf = true;

                movementSpeed = Random.Range(MaxMovementSpeed * 0.4f, MaxMovementSpeed);
                targetPosition = new Vector2(Mathf.Clamp(Puck.position.x, playerBoundary.Left,
                                            playerBoundary.Right),
                                            Mathf.Clamp(Puck.position.y, playerBoundary.Down,
                                            playerBoundary.Up));

            }
        
        if(Puck.position.x < puckBoundary.Left)
        {
            if (isFirstTimeInOpponentsHalf)
            {
                isFirstTimeInOpponentsHalf = false;
                offsetXFromTarget = Random.Range(1f, 1f);
            }
            movementSpeed = Random.Range(MaxMovementSpeed * 1.5f, MaxMovementSpeed);
                targetPosition = Vector2.MoveTowards(transform.position, ball.transform.position, movementSpeed * Time.fixedDeltaTime);
                
        }
            rb.MovePosition(Vector2.MoveTowards(rb.position, targetPosition,
                movementSpeed * Time.fixedDeltaTime));
    }
}

