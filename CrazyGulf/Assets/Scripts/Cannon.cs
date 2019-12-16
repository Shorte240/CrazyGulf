using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject bullet_prefab;
    public Transform bullet_spawn;

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
            // Play sound
            // Spawn bullets
            GameObject bullet = Instantiate(bullet_prefab, bullet_spawn.position, bullet_spawn.transform.rotation);
            Rigidbody bullet_rb = bullet.GetComponent<Rigidbody>();
            bullet_rb.AddForce(bullet.transform.forward * 75000.0f * Time.deltaTime);
            // Stuff
        }
    }
}
