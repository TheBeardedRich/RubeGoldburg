using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thud_Sound : MonoBehaviour
{
    //Make AudioSource Public
    public AudioSource ThudSound;


    // Use this for initialization
    void Start()
    {

        //Assigning Tap Sound as Audio Source
        ThudSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Once Collision Occurs
    void OnCollisionEnter(Collision cul)
    {
        //If Cylinder4 hits this surface,play a thud sound
        if (cul.gameObject.name == "Cylinder4")
            ThudSound.Play();

    }
}
