using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlane : MonoBehaviour {

    [SerializeField]
    [Range(0,10)]
    float speed;
    Vector3 position;
    Vector3 direction = Vector3.up;

  


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        position = transform.position;
        position = Vector3.Lerp(position, position + direction, Time.deltaTime * speed);
        transform.position = position;
    }
}
