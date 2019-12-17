using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    float timer = 0.0f;
    float introTime = 10.0f;
    public GameObject videoPlayer;
    public GameObject renderImage;
    public AudioSource audio;
    bool introHappened = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > introTime && !introHappened)
        {
            introHappened = true;
            videoPlayer.SetActive(false);
            renderImage.SetActive(false);
            audio.Play();
        }

        if(introHappened)
        {
            if(Input.anyKey)
            {
                SceneManager.UnloadScene("Menu");
                SceneManager.LoadScene("Alex");
            }
        }
    }
}
