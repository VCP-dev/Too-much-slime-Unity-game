using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float movespeed;
    public Rigidbody2D rb;
    Vector2 movement;
    Animator anim;

    public Joystick joystick;


    public GameObject paused;

    public GameObject gameover;

    bool ispaused;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gameover.SetActive(false);
        paused.SetActive(false);
        ispaused = false;
    }

    // Update is called once per frame
    void Update()
    {


        if (healthbarscript.health <= 0)
        {
            Destroy(gameObject, 0f);
            gameover.SetActive(true);

        }



        /* movement.x = Input.GetAxisRaw("Horizontal");                  ///          For PC
         movement.y = Input.GetAxisRaw("Vertical"); */


        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;



        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            anim.SetBool("isrunning", true);
        }
        else
        {
            anim.SetBool("isrunning", false);
        }

        if(Input.GetKeyDown(KeyCode.Escape) && !ispaused)
        {
            ispaused = true;
            Time.timeScale = 0;
            paused.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && ispaused)
        {
            ispaused = false;
            Time.timeScale = 1;
            paused.SetActive(false);
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }

    
}
