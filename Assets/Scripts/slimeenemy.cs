using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimeenemy : MonoBehaviour
{

    Transform player;
    public float speed;
    float playerrange=45f;
    Rigidbody2D rb;

    public float starttimebtwspawn;
    float timebtwspawn;


    public GameObject trail;
    public GameObject explosion;

    bool contact;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        contact = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.gameObject==null)
        {
            rb.velocity = new Vector2(0,0);
            kill();
        }

        if(contact)
        {
            healthbarscript.health -= 0.23f;
        }

        if(Vector2.Distance(transform.position,player.position) < playerrange)
        {
            Vector2 playerdirection = player.position - transform.position;
            rb.velocity = playerdirection.normalized * speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        if(rb.velocity.x!=0 || rb.velocity.y!=0)
        {
            if (timebtwspawn <= 0)
            {
                Instantiate(trail, transform.position, Quaternion.identity);
                timebtwspawn = starttimebtwspawn;
            }
            else
            {
                timebtwspawn -= Time.deltaTime;
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="bullet")
        {
            scorescript.scorevalue += 1;
            kill();
        }

        contact = (collision.gameObject.tag == "Player" && Time.timeScale!=0) ? true : false;
    }

    void kill()
    {
        Destroy(gameObject, 0f);
        Instantiate(explosion, transform.position, Quaternion.identity);
    }

}
