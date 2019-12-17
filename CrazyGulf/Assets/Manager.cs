using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public GameObject[] rigs;
    public GameObject[] trucks;
    public Text lose_text;
    public Text win_text;

    // Start is called before the first frame update
    void Start()
    {
        trucks = GameObject.FindGameObjectsWithTag("Truck");
    }

    // Update is called once per frame
    void Update()
    {
        if (rigs[0].GetComponent<OilRig>().destroyed && rigs[1].GetComponent<OilRig>().destroyed && rigs[2].GetComponent<OilRig>().destroyed)
        {
            lose_text.gameObject.SetActive(true);
            StartCoroutine(LoadAfterWait());
        }

        if (trucks.Length == 0)
        {
            win_text.gameObject.SetActive(true);
            StartCoroutine(LoadAfterWait());
        }
    }

    IEnumerator LoadAfterWait()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Menu");
    }
}
