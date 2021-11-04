using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    [SerializeField ]GameObject targer;
    [SerializeField] Vector3 distance;
    // Update is called once per frame
    
    private void LateUpdate()
    {
     //   transform.position = Vector3.Lerp(transform.position, targer.transform.position + distance, Time.deltaTime);
    }
}
