using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;  //created a object or variable for Player Script file.

    //creating an inbuilt method "OnTriger" which executes when two objects collide or trigger:
    private void OnTriggerEnter(Collider other) //other is used for game objects
    {
        if (other.gameObject.tag == "Collectables") //if the object with which the player object collides has a tag "Collectables" so that object will be destroyed.
        {
            Destroy(other.gameObject);  //game object being destroyed if condition true!
        }


    }

    private void OnCollisionEnter(Collision other) //method executer when ever Player object collides with other objects:
    {
        if (other.gameObject.tag == "Obstacles") //if its a green, blue, obstacle, big obstacle object or if their tags are called "Obstacles" the the playerscript file will be disabled!
        {
            playerScript.enabled = false;  //player Script file being disabled!
        }
    }


}
