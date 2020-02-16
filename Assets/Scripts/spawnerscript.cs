using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerscript : MonoBehaviour
{

    public GameObject enemy;
    float nextspawn=0;
    float spawnrate;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        spawnrate = 1.9f;

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<GameObject>();
    }
    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextspawn)
        {
            nextspawn = Time.time + spawnrate;
            Instantiate(enemy, transform.position, Quaternion.identity);

        }
    }
}
