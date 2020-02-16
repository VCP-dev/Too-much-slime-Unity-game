using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascript : MonoBehaviour
{

    public Transform player;
    public Transform reticle;
    Vector2 lastpos;
   
           
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            //transform.position = new Vector3((reticle.position.x + (player.position.x * 2)) / 3, (reticle.position.y + (player.position.y * 2)) / 3, -3);

            transform.position = new Vector3(player.position.x+(weapon.joyposx*3),player.position.y+(weapon.joyposy*3),-3.2f);
        }
        
    }

    
}
