using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiinalDimondsMultiplyer : MonoBehaviour
{
    [SerializeField] int myltiplyerNumber = 2;
    [SerializeField] bool first = false;
    CollecterCube collecter;
    bool isHitted = false;
    [SerializeField] WinUI ui;
    void Start()
    {
        collecter = GameObject.Find("CollectorCube").GetComponent<CollecterCube>();
        if (collecter == null) { Debug.Log("Collecter isnt found"); }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "CollectCube" && isHitted==false )
        {
            if(first == true)
                collecter.CollectorHeightIncrease();
            isHitted = true;
            collecter.CollectorHeightIncrease();
            collecter.PlayAudio(collecter.GetDownClip());
            other.transform.parent = null;
          

        }

        if (other.tag == "MainCube")
        {
            collecter.ScoreDimonds *= (myltiplyerNumber-2);
            ui.Won(myltiplyerNumber - 2, collecter.ScoreDimonds);

        }
    }
}
