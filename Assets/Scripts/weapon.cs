using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

    public float offset;
    public GameObject projectile;
    public Transform shotpos;
    Vector3 difference;
    Vector3 localscale;
    float dirX;

    private float timebtwshots;     ////  variables for amount of time btw shots
    public float starttimebtwshots=4;
    public static bool facingright=true;


    public Transform reticle;
    
    Rigidbody2D reticlerb;

    

   // float movespeed = 22.35f;


    float angle;


    public Joystick joystick;


    public static float joyposx,joyposy;

       
    // Start is called before the first frame update
    void Start()
    {
        timebtwshots = starttimebtwshots;
        localscale = transform.localScale;
        reticlerb = reticle.gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


        //difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        /*difference = reticle.position - transform.position;
        */
         //float rotZ = Mathf.Atan2(difference.y,difference.x)*Mathf.Rad2Deg;


        float heading = Mathf.Atan2(joystick.Horizontal,-1f*joystick.Vertical);
        transform.rotation = Quaternion.Euler(0f, 0f, heading * Mathf.Rad2Deg-90f);

       //transform.rotation = Quaternion.Euler(0f,0f,rotZ + offset);

        if(timebtwshots<=0)
        {
            if (/*Input.GetMouseButton(0)*/ joystick.Horizontal!=0 || joystick.Vertical!=0 )
            {
                Instantiate(projectile, shotpos.position, transform.rotation);
                
                timebtwshots = starttimebtwshots;

                joyposx = joystick.Horizontal;
                joyposy = joystick.Vertical;
            }
        }
        else
        {
            timebtwshots -= Time.deltaTime;
        }

        
               
    }


    



    private void LateUpdate()
    {
        //if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x > transform.position.x )      //// checking whether mouse cursor is to the right of the character
        if(/*reticle.position.x > transform.position.x*/joystick.Horizontal>0)
        {
            facingright = true;
        }
        else
        {
            facingright = false;
        }

        if ((!facingright && localscale.y > 0) || (facingright && localscale.y < 0))
        {
            localscale.y *= -1;
        }

        transform.localScale = localscale;
    }
}
