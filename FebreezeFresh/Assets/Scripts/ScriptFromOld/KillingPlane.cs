using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillingPlane : MonoBehaviour {

    [SerializeField]
    Text winningText;

   void OnControllerColliderHit(ControllerColliderHit hit)
    {
      
        if (hit.gameObject.tag == "KillingPlane")
        {
            Destroy(gameObject);
        }else if (hit.gameObject.tag == "FinalPlateform")
        {
            Debug.Log("Hi");
            winningText.enabled = true;
        }
    }

    // Use this for initialization
    void Start () {
        //winningText.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
