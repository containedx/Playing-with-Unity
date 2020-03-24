using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{

    // zeby obiekt sie obracal w kierunku w ktorym leci 

    public Rigidbody shellRb;

    private void Update()
    {
        transform.forward = shellRb.velocity.normalized; 
    }
}
