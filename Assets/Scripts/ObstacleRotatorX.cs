using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRotatorX : MonoBehaviour
{
    //fields
    public GameObject obstacle;
    public float rotationSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for rotating obstacles
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
