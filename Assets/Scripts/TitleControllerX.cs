using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleControllerX : MonoBehaviour
{
    public float rotationSpeed;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //for animating plane
        transform.Translate(Vector3.forward * speed * (1 - Time.deltaTime));
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
    }
}
