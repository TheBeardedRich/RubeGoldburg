using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {


    //Public allows for changing within the inspector
    public float speed = 100f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Rotate the Spinner Object
    
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);

	}
}
