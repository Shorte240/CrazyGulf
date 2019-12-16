using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearText : MonoBehaviour
{
    public float countdown = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Text>().text != "" && countdown > 0)
        {
            countdown -= Time.deltaTime;

            if (countdown <= 0.0f)
            {
                gameObject.GetComponent<Text>().text = "";
                countdown = 2.0f;
            }
        }
    }
}
