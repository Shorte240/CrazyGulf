﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    private float timer = 0.0f;
    public float splashTimer = 22.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > splashTimer)
        {
            SceneManager.UnloadScene("Splash");
            SceneManager.LoadScene("Menu");
        }
    }
}
