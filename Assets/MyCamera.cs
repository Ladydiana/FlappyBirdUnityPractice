using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour {

    public Transform player;
	
	// Update is called once per frame
	void Update () {
		if (player.position.x < gameObject.transform.position.x -10)
        {
            gameObject.transform.position -=  new Vector3 (2, 0, 0);
        }

        if (player.position.x > gameObject.transform.position.x + 10)
        {
            gameObject.transform.position += new Vector3(2, 0, 0);
        }
    }
}
