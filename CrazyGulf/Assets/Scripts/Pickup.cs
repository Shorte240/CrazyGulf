using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plane" && gameObject.tag == "Fuel Pickup")
        {
            other.gameObject.GetComponentInParent<MFlight.Demo.PlaneController>().fuel = 5.0f;
            Destroy(gameObject);
        }
        else if (other.gameObject.tag == "Plane" && gameObject.tag == "Missile Pickup")
        {
            other.gameObject.GetComponentInParent<Missile>().missiles = 3;
            for (int i = 0; i < other.gameObject.GetComponentInParent<Missile>().missiles; i++)
            {
                GameObject.FindObjectOfType<DisplayMissiles>().misslesUI[i].SetActive(true); 

            }
            Destroy(gameObject);
        }
    }
}
