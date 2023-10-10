using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player") 
        {
            other.gameObject.tag = "Finished";
            if (gameObject.tag != "Hit")
            {
                GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("You finished the game!");
                gameObject.tag = "Hit";
            }
            
        }
        
    }
}
