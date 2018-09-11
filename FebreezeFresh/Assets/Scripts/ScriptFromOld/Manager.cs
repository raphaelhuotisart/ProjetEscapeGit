using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    GameObject Player;

	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
     
	}
	
	// Update is called once per frame
	void Update () {
		if (Player == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
