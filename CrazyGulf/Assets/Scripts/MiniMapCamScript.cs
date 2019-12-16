using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCamScript : MonoBehaviour
{
    public GameObject plane;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position.Set(plane.transform.position.x, gameObject.transform.position.y, plane.transform.position.z);
    }
}
