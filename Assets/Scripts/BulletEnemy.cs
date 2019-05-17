using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {

        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            if (this.gameObject.tag == "bulletEnemy")
            {
                FindObjectOfType<Person>().health -= 5;
            }
            if (this.gameObject.tag == "BulletTank")
            {
                FindObjectOfType<Person>().health -= 2;
            }

            Destroy(gameObject);
        }
    }

}
