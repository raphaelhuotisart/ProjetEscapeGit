using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

    [SerializeField]
    float speed;
    float rotationX;
    float rotationY;
    float sensitivity;

    CharacterController player;

    float moveFB;
    float moveLR;

	// Use this for initialization
	void Start () {
        player = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;
        

        Vector3 mouvement = new Vector3(moveLR,0 , moveFB);
        mouvement = transform.rotation * mouvement;
        player.Move(mouvement * Time.deltaTime);

	}
}
