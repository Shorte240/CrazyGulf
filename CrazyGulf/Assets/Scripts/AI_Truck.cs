using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AI_Truck : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject[] points;
    int pointIndex = 0;
    public Vector3 rotation = new Vector3(0,0,0);   // Forced rotation axis.
    public Text destroyed_text;
    public AudioClip explosion_clip;
    private bool played_sound = false;

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
            pointIndex++;
            agent.SetDestination(points[pointIndex].transform.position);
        }
        // Force rotation of the truck
        gameObject.transform.eulerAngles = rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Missile")
        {
            gameObject.SetActive(false);
            if (!played_sound)
            {
                AudioSource.PlayClipAtPoint(explosion_clip, gameObject.transform.position, 1.0f);
                played_sound = true;
            }
            destroyed_text.text = (gameObject.name + " " + "Destroyed");
        }
    }
}
