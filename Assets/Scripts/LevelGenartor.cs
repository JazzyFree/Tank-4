using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenartor : MonoBehaviour
{
    public GameObject[] objects;

     void Start()
    {
        int rand = Random.Range(0, objects.Length);
        _ = Instantiate(objects[rand], transform.position, Quaternion.identity);
    }
}
