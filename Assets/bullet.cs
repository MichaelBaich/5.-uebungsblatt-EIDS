using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        // at speed -76 in position (0,0,0) or above glitches the sphere through the plane
        // at speed -95 in position (-2.26, 1.88, -2.47) or above glitches the sphere through the plan
        // the behavior is not cosistent
        rb.velocity = new Vector3(0,-95,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
