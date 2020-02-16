using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    public float speed;
    Transform gun;

    // Start is called before the first frame update
    void Start()
    {
        gun = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Invoke("Destroyprojectile",1.13f);
     
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(gun.right * speed * Time.deltaTime);
       
    }

    void Destroyprojectile()
    {
        Destroy(gameObject,0f);
    }
}
