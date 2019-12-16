using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Truck : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject[] points = new GameObject[2];
    int pointIndex = 0;
    public Vector3 rotation = new Vector3(0,0,0);   // Forced rotation axis.

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(points[0].transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        // Switch to other point if we find that the distance to the destination point is less than 0.1f.
        if(agent.remainingDistance < 0.1f)
        {
            if(pointIndex == 0)
            {
                pointIndex = 1;
            }
            else
            {
                pointIndex = 0;
            }
            agent.SetDestination(points[pointIndex].transform.position);
        }
        // Force rotation of the truck
        gameObject.transform.eulerAngles = rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);

        }
    }
}
