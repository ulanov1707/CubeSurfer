using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    CollecterCube collector;
    // Start is called before the first frame update
    void Start()
    {
        collector = GameObject.Find("CollectorCube").GetComponent<CollecterCube>();
        if (collector == null)
        {
            Debug.Log("Collectable:: Collector cube isnt found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CollectorCube") 
        {
            collector.ScoreDimonds++;
            collector.PlayAudio(collector.GetDimondClip());
            Destroy(this.gameObject);
        }
    }
}
