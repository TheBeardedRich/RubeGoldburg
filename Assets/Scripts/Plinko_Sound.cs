using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plinko_Sound : MonoBehaviour
{
    //Make AudioSource Public
    public AudioSource PlinkSound;


    // Use this for initialization
    void Start()
    {

        //Assigning Tap Sound as Audio Source
        PlinkSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If the Ball hits any of the Plinko Pegs, play a Plink Sound
        if (cul.gameObject.name == "Ball")
            PlinkSound.Play();

    }
}
