using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendFlying : MonoBehaviour
{
    public GameObject proximityDetonator;
    public float thrust;
    public int distance;

    void Update()
    {
        if(Vector3.Distance(transform.position, proximityDetonator.transform.position) < distance)
        {
            var rb = GetComponent<Rigidbody>();
            rb.AddForce(proximityDetonator.transform.forward * thrust);
        }
        
    }
}
