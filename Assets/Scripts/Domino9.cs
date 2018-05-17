using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domino9 : MonoBehaviour {
    //Make AudioSource Public
    public AudioSource TapSound;


    // Use this for initialization
    void Start()
    {

        //Assigning Tap Sound as Audio Source
        TapSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If Domino8 hits Domino9 play Tap
        if (cul.gameObject.name == "Domino8")
            TapSound.Play();

    }


}

