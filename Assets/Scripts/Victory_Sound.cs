using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory_Sound : MonoBehaviour {
    //Make AudioSource Public
    public AudioSource VictorySound;


    // Use this for initialization
    void Start()
    {

        //Assigning Victory Sound as Audio Source
        VictorySound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If Ball reaches end goal, play Victory Sound
        if (cul.gameObject.name == "Ball")
            VictorySound.Play();

    }


}
