using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public GameObject missile_prefab;
    public Transform[] missile_spawn;
    public float force_modifier = 150000.0f;
    public float life_time = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireMissile();
        }
    }

    public void FireMissile()
    {
        Transform spawn = missile_spawn[Random.Range(0, missile_spawn.Length)];
        GameObject missile = Instantiate(missile_prefab, spawn);
        Rigidbody missile_rb = missile.GetComponent<Rigidbody>();
        missile_rb.AddForce(missile.transform.up * force_modifier * Time.deltaTime);
    }
}
