using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;



public class EnemyFollow : MonoBehaviour
{
    public GameObject ThePlayer;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _ = gameObject.GetComponent<NavMeshAgent>().SetDestination(ThePlayer.transform.position);

    }
}