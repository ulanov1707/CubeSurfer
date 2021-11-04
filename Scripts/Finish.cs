using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    CollecterCube collecter;
    private void Start()
    {
        collecter = GameObject.Find("CollectorCube").GetComponent<CollecterCube>();
    }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CollectCube" || other.tag == "MainCube") 
        {
            collecter.ScoreDimonds *= 32;
            Time.timeScale = 0;
        }
    }
}
