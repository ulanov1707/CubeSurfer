using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCube : MonoBehaviour
{
    [SerializeField] private float _leftRightSpeed = 10f;
    [SerializeField] private float _ForwardSpeed = 40f;
    float velocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Input.GetAxis("Horizontal") * _leftRightSpeed * Time.deltaTime;
        transform.Translate(velocity, 0, _ForwardSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -4.3f, 4.3f));

    }
}
