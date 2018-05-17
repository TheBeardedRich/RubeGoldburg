using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flapper3_collision : MonoBehaviour {
    //Make Material 'Flapper 3' public
    public Material Flapper3;


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
        //If Ball hits Flapper3
        if (cul.gameObject.name == "Ball")
            //Change material to Flapper 3
            GetComponent<Renderer>().material = Flapper3;
    }


}
