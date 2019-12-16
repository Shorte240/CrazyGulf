using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Gun : MonoBehaviour
{
    private GameObject plane;
    private Vector3 firePoint;
    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.FindGameObjectWithTag("plane");
        firePoint = GetComponentInChildren<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
