using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool _isCollected;
  
    private void Start()
    {
        _isCollected = false;
    }

    public void SetCollectedTrue() {
        _isCollected = true;
    }
    public bool GetCollected() {
        return _isCollected;
    }

 
   
}
