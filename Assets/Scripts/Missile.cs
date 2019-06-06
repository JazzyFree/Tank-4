using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public int playerNumber = 1;

    public GameObject missilePrefab;
    public Transform fireTransform;
    public float fireForce = 2000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {    // To the fire the missile from the tank
        if (Input.GetButtonDown("Fire" + playerNumber))
        {
            GameObject missile = Instantiate(missilePrefab, fireTransform.position, transform.rotation);


            Rigidbody missileBody = missile.GetComponent<Rigidbody>();

            // The missle force 
            missileBody.AddForce(transform.forward * fireForce);
        }
    }


}
