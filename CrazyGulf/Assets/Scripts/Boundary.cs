using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boundary : MonoBehaviour
{
    public Text return_text;
    public float return_timer = 5.0f;
    public GameObject plane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Plane" && return_timer > 0)
        {
            // Show return text
            return_text.gameObject.SetActive(true);
            return_text.text = ("Return to the battlefield: " + return_timer.ToString("F2"));
            // Countdown
            return_timer -= Time.deltaTime;

            // If countdown == 0, reset plane
            if (return_timer <= 0.0f)
            {
                plane.gameObject.SetActive(false);
                return_timer = 5.0f;
            }
        }
    }
}
