using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AI_Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float forceModifier = 150000.0f;
    public GameObject firepoint;
    private GameObject plane;
    float timer = 0.0f;
    public float fireTimer = 1.0f;
    public Text destroyed_text;

    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.FindGameObjectWithTag("Plane");
        
    }

    // Update is called once per frame
    void Update()
    {
       timer += Time.deltaTime;
       if(timer > fireTimer)
        {
            timer = 0.0f;
            Vector3 directionalVec = plane.transform.position - gameObject.transform.position;
           // directionalVec.Normalize();
            GameObject bullet = Instantiate(bulletPrefab,firepoint.transform.position, bulletPrefab.transform.rotation);
            Rigidbody bullet_rb = bullet.GetComponent<Rigidbody>();
            bullet_rb.AddForce(directionalVec * forceModifier * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "Missile")
        {
            gameObject.SetActive(false);
            destroyed_text.text = (gameObject.name + " " + " Destroyed");
        }
    }
}