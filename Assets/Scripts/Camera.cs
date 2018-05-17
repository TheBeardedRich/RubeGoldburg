using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


    public Vector3 BallPos;
    public Transform Ball;


    // Update is called once per frame
    public void Update () {

        transform.position = Ball.position + BallPos;

    }
}
