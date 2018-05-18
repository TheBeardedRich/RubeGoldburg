using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndGame : MonoBehaviour {



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
        //If Ball hits endgame zone, go to quit menu
        if (cul.gameObject.name == "Ball")
            //Load the next scene in the scene index
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


}
