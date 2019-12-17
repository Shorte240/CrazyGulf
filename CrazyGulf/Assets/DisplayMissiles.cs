using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMissiles : MonoBehaviour
{
    int missleCount = 0;
    public GameObject[] misslesUI;
    // Start is called before the first frame update
    void Start()
    {
        missleCount = GameObject.FindObjectOfType<Missile>().missiles;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < missleCount; i++)
        {
            misslesUI[i].SetActive(false);
        }
    }
}
