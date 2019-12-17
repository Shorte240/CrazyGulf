using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] rigs;
    public Text lose_text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rigs[0].GetComponent<OilRig>().destroyed && rigs[1].GetComponent<OilRig>().destroyed && rigs[2].GetComponent<OilRig>().destroyed)
        {
            lose_text.gameObject.SetActive(true);
            StartCoroutine(LoadAfterWait());
        }
    }

    IEnumerator LoadAfterWait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}
