using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PojectileAddOn : MonoBehaviour
{
    private Rigidbody rb;

    public bool targetHit;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        //make it only affect first target you hit
        if (targetHit)
            return;
        else
            targetHit = true;

        //make projectile stick to surface 
        rb.isKinematic = true;

        //make projectile move iwth target
        transform.SetParent(collision.transform);

    }
}
