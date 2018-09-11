using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {


	
    void Shoot()
    {
        Ray shotRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(shotRay, out hit, 100f)){
            Debug.Log(hit.collider.gameObject.tag);
            if (hit.collider.gameObject.tag == "Floor")
            {
                
                Renderer boxMesh = hit.collider.gameObject.GetComponent<MeshRenderer>();
                boxMesh.enabled = true;
            }
        }
    }

	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
	}
}
