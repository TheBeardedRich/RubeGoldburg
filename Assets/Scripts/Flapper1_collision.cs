using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flapper1_collision : MonoBehaviour {
    //Make Material 'Flapper 1' public
    public Material Flapper1;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If Ball hits Flapper1
        if (cul.gameObject.name == "Ball")
            //Change material to Flapper 1
            GetComponent<Renderer>().material = Flapper1;
    }


}
