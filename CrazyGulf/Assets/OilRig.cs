using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRig : MonoBehaviour
{
    public int health = 3;
    public ParticleSystem smoke;
    public bool destroyed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0 && smoke.isPlaying)
        {
            smoke.Stop();
            destroyed = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Truck")
        {
            health -= 1;
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
            return;
        }
    }
}
