using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flapper4_Collision : MonoBehaviour {
    //Make Material 'Flapper 4' public
    public Material Flapper4;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If Ball hits Flapper4
        if (cul.gameObject.name == "Ball")
            //Change material to Flapper 4
            GetComponent<Renderer>().material = Flapper4;
    }


}
