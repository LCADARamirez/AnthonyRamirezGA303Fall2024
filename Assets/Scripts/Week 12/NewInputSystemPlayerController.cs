using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class NewInputSystemPlayerController : MonoBehaviour
{
    private Vector3 movement = Vector3.zero;
    public float speed = 5f;    //Movement speed of the character.
    private CharacterController characterController;

    public float jumpHeight = 3f;   //Jump height of the character when jump is pressed.
    private float verticalVelocity;
    private float gravity = 9.81f;

    private bool isJumpPressed = false;

    private float groundedTimer;
    public float groundedTimerBuffer = .2f; //This is the time it takes for the character controller to be off the ground before it won't allow jumping to occur.

    private bool isPlayerGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(characterController.isGrounded == true) //Check if the character controller thinks it's grounded...
        {
            groundedTimer = 0f; //set this grounded timer to 0.
            isPlayerGrounded = true;    //set this custom isPlayerGrounded variable to true also.
        }
        else if(characterController.isGrounded == false) //If the character controller thinks it's not grounded...
        {
            groundedTimer += Time.deltaTime;    //Start counting up a timer.

            if(groundedTimer > groundedTimerBuffer) //If the timer finishes
            {
                isPlayerGrounded = false;   //Yup, player is for sure grounded.
            }
        }

        if (isPlayerGrounded == true && verticalVelocity < 0f) //Checks if the player is grounded, and if its verticalvelocity is lower than zero
        {
            verticalVelocity = 0f; //If so, reset verticalVelocity to 0, so it doesn't keep speeding up.
        }
        
        if (isPlayerGrounded == false)
        {
            verticalVelocity -= gravity * Time.deltaTime;          //Set the value of verticalVelocity based on the value of gravity.
        }

        if(isJumpPressed == true)   //Basically, if jump was pressed this frame because isJumpPressed is set to true in OnJump, which happens before Update...
        {
            verticalVelocity += Mathf.Sqrt(jumpHeight * gravity);   //Do a little math formula for jumping!
            isJumpPressed = false;  //Tell this that isJumpPressed is false so that it doesn't run this every frame.
            isPlayerGrounded = false;   //Since we're jumping, we know the player shouldn't be considered grounded, so we set this to false.
        }


        Vector3 moveDir = movement * speed; //Create a new Vector3 variable to make our move work based on the movement variable that is changed in OnMove()
        moveDir.y = verticalVelocity; //Change the moveDir.y to whatever the vertical velocity is that is being affected by gravity.

        characterController.Move(moveDir * Time.deltaTime); //Call character controller's Move function to tell it where to move to.
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if(isPlayerGrounded == true) //If the player is grounded (with a buffer, as defined at the start of update)
        {
            isJumpPressed = true;   //Set isJumpPressed to true, so that in update, it increases the y velocity of the character higher to simulate that jump
        }
    }

    public void OnMove(InputAction.CallbackContext context) //OnMove is called from our event on the PlayerInput component. This context can check if it's being performed this frame, canceled this frame, and any values associated with it.
    {
        Debug.Log("Button has been Pressed!");
        Debug.Log("Moving!");
        Vector2 moveDirection = context.ReadValue<Vector2>(); //This gets the value of the buttons being pressed from our context variable. W is (0, 1), S is (0, -1), A is (-1, 0), D is (1, 0)
        Debug.Log(moveDirection.ToString());
        movement = new Vector3(moveDirection.x, 0f, moveDirection.y); //Depending on the buttons being pressed, this will be anywhere between (-1, 0, -1) to (1, 0, 1) for the direction we'll move in.
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("This is for collisions for a CharacterController instead of OnCollisionEnter for a Rigidbody");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter works normally :)");
    }
}





















