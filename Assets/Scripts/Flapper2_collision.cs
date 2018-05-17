using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flapper2_collision : MonoBehaviour {
    //Make Material 'Flapper 2' public
    public Material Flapper2;


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
        //If Ball hits Flapper2
        if (cul.gameObject.name == "Ball")
            //Change material to Flapper 2
            GetComponent<Renderer>().material = Flapper2;
    }


}
