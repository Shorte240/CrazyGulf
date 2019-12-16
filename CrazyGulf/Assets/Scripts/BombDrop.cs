using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDrop : MonoBehaviour
{
    public GameObject bomb_prefab;
    public Transform bomb_spawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Fire the cannon
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Play sound
            // Spawn bomb
            GameObject bomb = Instantiate(bomb_prefab, bomb_spawn.position, bomb_spawn.transform.rotation);
        }
    }
}
