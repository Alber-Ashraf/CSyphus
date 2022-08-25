using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;
    private Vector3 velocity;

    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;

    [SerializeField] private float jumpHeight;

    private CharacterController controller;
    private Animator animator;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = true;
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection = transform.TransformDirection(moveDirection);        

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
            }
            Jump();
        }

            if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = walkSpeed;
                animator.SetFloat("Speed", 0.5f, 0.1f, Time.deltaTime);
                MovementAnimation();
            }
            else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = runSpeed;
                animator.SetFloat("Speed", 1f, 0.1f, Time.deltaTime);
                MovementAnimation();
            }
            else if (moveDirection == Vector3.zero)
            {
                Idle();
            }

            MovementAnimation();
            moveDirection *= moveSpeed;
        
            
        controller.Move(moveDirection * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void Idle()
    {
        animator.SetFloat("Speed", 0, 0.1f, Time.deltaTime);
    }
    
    private void MovementAnimation()
    {
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
            }
            animator.SetBool("BackWalk", true);
            moveSpeed = walkSpeed;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
            }
            animator.SetBool("LeftWalk", true);
            moveSpeed = walkSpeed;
        }
        else if (Input.GetKey(KeyCode.D )|| Input.GetKey(KeyCode.RightArrow))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("Jump");
            }
            animator.SetBool("RightWalk", true);
            moveSpeed = walkSpeed;
        }


        else
        {
            animator.SetBool("LeftWalk", false);
            animator.SetBool("RightWalk", false);
            animator.SetBool("BackWalk", false);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }
    }

}
