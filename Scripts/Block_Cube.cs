using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block_Cube : MonoBehaviour
{

    CollecterCube collecter;
    UImanager ui;
    private void Start()
    {
        collecter = GameObject.Find("CollectorCube").GetComponent<CollecterCube>();
        if (collecter == null) { Debug.Log("Collecter isnt found"); }
        ui = GameObject.Find("Canvas").GetComponent<UImanager>();
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.tag == "CollectCube" )
        {
            
            this.GetComponent<BoxCollider>().enabled = false;
            other.transform.parent = null;
            other.GetComponent<BoxCollider>().enabled = false;
            collecter.DecresceHeight();
            collecter.PlayAudio(collecter.GetDownClip());
           
        }

        if (other.tag == "MainCube") {
            ui.GameOver();
        }
    }

   
}
