using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillingPlane : MonoBehaviour {


   void OnControllerColliderHit(ControllerColliderHit hit)
    {
      
        if (hit.gameObject.tag == "KillingPlane")
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
