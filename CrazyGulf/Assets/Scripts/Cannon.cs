using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bullet_prefab;
    public Transform bullet_spawn;
    public float force_modifier = 150000.0f;
    public AudioSource cannon_audio;
    public ParticleSystem gun_particle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Fire the cannon
        if (Input.GetMouseButton(0))
        {
            // Play sprite
            if (!gun_particle.isPlaying)
            {
                gun_particle.Play(); 
            }

            // Play sound
            if (!cannon_audio.isPlaying)
            {
                cannon_audio.Play(); 
            }

            float plane_mag = gameObject.GetComponent<Rigidbody>().velocity.magnitude;

            // Spawn bullets
            GameObject bullet = Instantiate(bullet_prefab, bullet_spawn.position, bullet_spawn.transform.rotation);
            Rigidbody bullet_rb = bullet.GetComponent<Rigidbody>();
            bullet_rb.AddForce(bullet.transform.forward * (force_modifier + plane_mag) * Time.deltaTime);
            // Stuff
        }
        else if (Input.GetMouseButtonUp(0))
        {
            gun_particle.Stop();
        }
    }
}
