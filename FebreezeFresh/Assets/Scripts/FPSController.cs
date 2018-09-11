using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {
    //|
    //|
    //START OF Player Movement And Look Controls VARIABLES
    [Range(0,10)]
    public float speed = 9f;

    [Range(0, 10)]
    public float sensitivity = 4f;

    private Vector3 movement;

    public GameObject eyes;
    CharacterController player;

    float moveFront;
    float moveSides;

    float rotX;
    float rotY;
    //END OF Player Movement And Look Controls VARIABLES
    //|
    //|
    //START OF Player Gravity and Jump Controls
    [Range(0,50)]
    public float gravity = 14f;

    [Range(0, 50)]
    public float jumpForce = 10f;

    private bool canJump;
    private float verticalVelocity;
    //END OF Player Gravity and Jump Controls
    //|
    //|

    void Start () {

        player = GetComponent<CharacterController>();
        Cursor.visible = false;
	}
	
	void Update () {

        //Ground And Jump Stuff
        if (player.isGrounded)
        {
            canJump = true;
            verticalVelocity = -gravity * Time.deltaTime;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        //Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        //player.Move(moveVector * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            canJump = false;
            verticalVelocity = jumpForce;
        }

        movement.y = verticalVelocity;

        //Movement And Look
        moveFront = Input.GetAxis("Vertical") * speed;
        moveSides = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity;

        //Vector3 movement = new Vector3(moveSides, verticalVelocity, moveFront);
        movement.x = moveSides;
        movement.z = moveFront;
        movement = transform.rotation * movement;
        transform.Rotate(0, rotX, 0);
        eyes.transform.Rotate(-rotY, 0, 0);
        player.Move (movement * Time.deltaTime);
		
	}

    //Wall Jump and Wall Run
    /*private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (!player.isGrounded && hit.normal.y < 0.1f)
        {
            verticalVelocity = verticalVelocity / 1.2f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
                movement = hit.normal * speed;
            }
        }
    }*/
}
