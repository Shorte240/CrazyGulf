using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float life_time = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CountdownLifeRemaining();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Instantiate explosion
        if (collision.relativeVelocity.magnitude > 10 && collision.gameObject.tag != "Plane")
        {
            // Destroy this object
            Destroy(gameObject);
        }
    }

    void CountdownLifeRemaining()
    {
        if (gameObject.activeSelf && life_time > 0.0f)
        {
            life_time -= Time.deltaTime;
        }

        if (life_time <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
