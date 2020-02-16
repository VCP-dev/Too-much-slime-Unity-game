using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupscript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
           
           
            if(healthbarscript.health>=70)
            {
                healthbarscript.health = 100;
            }
            else
            {
                healthbarscript.health += 30;
            }
            Destroy(gameObject,0f);
        }
    }
}
