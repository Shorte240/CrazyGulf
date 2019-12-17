using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public GameObject plane;
    public float reset_timer = 3f;
    public GameObject reset_text_object;
    public Transform reset_transform;
    public AudioSource explosion_source;
    private bool played_sound = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetPlane();
    }

    private void ResetPlane()
    {
        if (!plane.activeSelf)
        {
            if (!explosion_source.isPlaying && !played_sound)
            {
                explosion_source.Play();
                played_sound = true;
            }

            //activate reset UI countdown
            // which will count down timer
            reset_text_object.SetActive(true);
            Text reset_text = reset_text_object.GetComponent<Text>();

            if (reset_timer > 0)
            {
                reset_timer -= Time.deltaTime;
                reset_text.text = "Respawn in " + (reset_timer).ToString("F2");
            }

            // after reaching zero
            // reset plane to spawn point
            if (reset_timer <= 0)
            {
                plane.SetActive(true);
                plane.GetComponent<MFlight.Demo.PlaneController>().health = 5f;
                plane.GetComponent<MFlight.Demo.PlaneController>().thrust = 100f;
                plane.GetComponent<Missile>().missiles = 10;
                GameObject.Find("MouseFlightRig").GetComponent<MFlight.MouseFlightController>().isMouseAimFrozen = true;
                GameObject.Find("MouseFlightRig").GetComponent<MFlight.MouseFlightController>().locktimer = 3f;
                //plane.GetComponent<MFlight.MouseFlightController>().isMouseAimFrozen = true;
                //plane.GetComponent<MFlight.MouseFlightController>().locktimer = 3f;
                Vector3 pos = reset_transform.position;
                plane.transform.position = reset_transform.position;
                plane.transform.rotation = reset_transform.rotation;
                reset_timer = 3f;
                played_sound = false;
            }
        }
    }
}
