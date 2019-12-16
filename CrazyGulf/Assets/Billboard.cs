using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    private Camera maincam;
    // Start is called before the first frame update
    void Start()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localRotation = maincam.transform.rotation;
    }
}
