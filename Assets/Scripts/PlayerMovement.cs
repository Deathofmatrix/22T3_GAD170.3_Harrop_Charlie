using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [Header("References")]
    // This must be linked to the gameobject that has the "Character Controller" in the inspector.
    private CharacterController characterController;
    [SerializeField] private Transform groundCheck;

    [Header("Movement Variables")]
    // These variables (visible in the inspector) are for you to set up to match the right feel
    [SerializeField] private float movementSpeed = 12f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHeight = 3f;
    [SerializeField] private int jumpNumber = 1;
    [SerializeField] private int jumpState = 0;

    [Header("Ground Variables")]
    [SerializeField] private float groundDistance = 0.4f;
    [SerializeField] private LayerMask groundMask;

    //gravity and velocity
    private Vector3 velocity;

    private bool isGrounded;

    private void Start()
    {
        // If the variable "characterController" is empty...
        if (characterController == null)
        {
            // ...then this searches the components on the gameobject and gets a reference to the CharacterController class
            characterController = GetComponent<CharacterController>();
        }
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
            jumpState = 0;
        }

        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");

        // This takes the Left/Right and Forward/Back values to build a vector
        Vector3 movementVector = transform.right * xValue + transform.forward * zValue;

        // Finally, it applies that vector it just made to the character
        characterController.Move(movementVector * movementSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && jumpState < jumpNumber)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
            jumpState++;
        }

        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);




    }
}
