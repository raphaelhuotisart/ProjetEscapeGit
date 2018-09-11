using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour {

    [SerializeField]
    float speed;
    Vector3 position;
    Vector3 direction = Vector3.down;

    bool falling;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "DisableFloor")
        {
       if (GetComponent<MeshRenderer>().enabled == false)
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
            falling = true;
        }
    }

    void Fall()
    {
        position = transform.position;
        position = Vector3.Lerp(position, position + direction, Time.deltaTime * speed);
        transform.position = position;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (falling == true)
        {
            Fall();
        }

	}
}
