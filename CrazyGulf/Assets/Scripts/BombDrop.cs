using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombDrop : MonoBehaviour
{
    public GameObject bomb_prefab;
    public Transform bomb_spawn;
    public int bombs = 10;
    public Text bomb_text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire the cannon
        if (Input.GetKeyDown(KeyCode.Space) && bombs > 0)
        {
            // Play sound
            // Spawn bomb
            GameObject bomb = Instantiate(bomb_prefab, bomb_spawn.position, bomb_spawn.transform.rotation);
            bombs -= 1;
        }

        bomb_text.text = ("Bombs: " + bombs);
    }
}
