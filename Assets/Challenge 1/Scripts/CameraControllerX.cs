using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerX : MonoBehaviour
{
    public GameObject player;
    
    void Start()
    {

    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + player.transform.forward * -13, 0.05f);
        transform.LookAt(player.transform.position);
    }
}
