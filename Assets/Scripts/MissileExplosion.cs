using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileExplosion : MonoBehaviour
{
    public GameObject explosionPrefab;

    public float explosionForce = 1000;
    public float explosionRadius = 5;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        Collider[] collidersHit = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider collider in collidersHit)
        {
            Rigidbody targetBody = collider.GetComponent<Rigidbody>();

            //temporarily store each object’s Rigidbody component inside the targetBody variable
            if (targetBody == null)
            {
                continue;
            }
            targetBody.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            Health targetHealth = collider.GetComponent<Health>();

            if(targetHealth == null)
            {
                continue;
            }

            targetHealth.TakeDamage();
        } 
        
        Destroy(gameObject);    
    }
}
