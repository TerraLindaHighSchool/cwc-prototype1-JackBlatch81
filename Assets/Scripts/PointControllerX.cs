using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointControllerX : MonoBehaviour
{
    //fields
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for rotating points
        transform.Rotate(new Vector3(10, 5, 20) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //for point particles
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        }
    }
}
