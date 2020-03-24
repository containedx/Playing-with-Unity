using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius;
    public float force;
    private Rigidbody bombRb;

    private void Awake()
    {
        bombRb = GetComponent<Rigidbody>(); 
    }

    private void OnCollisionEnter(Collision collision) // => gdy wykryje kolizje => rysuje niewidzialna sfere
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        int i = 0; 
        while( i < hitColliders.Length)
        {
            Rigidbody rb = hitColliders[i].GetComponent<Rigidbody>();
            if (rb != null)
                rb?.AddExplosionForce(force, transform.position, radius);
            i++;
        }
        Destroy(this.gameObject);
    }

    private void OnMouseDown()
    {
        bombRb.isKinematic = false; 
    }
}
