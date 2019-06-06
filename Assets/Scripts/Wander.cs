using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    private Vector3 targetPosition;

    public  float movementSpeed = 5.0f;
    public float rotationSpeed = 2.0f;
    public  float targetPositionTolerance = 3.0f;
    private float minX;
    private float maxX;
    private float minZ;
    private float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        minX = -45.0f;
        maxX = 45.0f;

        minZ = -45.0f;
        maxZ = 45.0f;

        // Get the wander position 

    }

    // Update is called once per frame
    void Update()
    {

    }

    void GetNextPosition()
    {
        targetPosition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
    }
}
