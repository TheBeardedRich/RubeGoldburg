using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper_Sound : MonoBehaviour
{
    //Make AudioSource Public
    public AudioSource BoingSound;


    // Use this for initialization
    void Start()
    {

        //Assigning Victory Sound as Audio Source
        BoingSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If Ball hits Flipper, play Boing Sound
        if (cul.gameObject.name == "Ball")
            BoingSound.Play();

    }
}