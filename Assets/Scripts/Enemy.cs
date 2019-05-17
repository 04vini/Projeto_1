using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public Image healthBar;
    public Text text;
    public float maxHealth;
    public float health;
    public float Dmg;

 
    Pistol pistol = new Pistol();
    Hand hand = new Hand();
    Stick stick = new Stick();
    // Use this for initialization
    void Start () {
        if (this.gameObject.tag == "Enemy")
        {
            maxHealth = 100;
            health = 100;
           
        
        }

        if (this.gameObject.tag == "Tank")
        {
            maxHealth = 200;
            health = 200;
          
          
        }
    }
	
	// Update is called once per frame
	void Update () {
        
        healthBar.fillAmount = health / maxHealth;
        text.text = health + " / " + maxHealth;
     
      

        if (health < 0)
        {
           
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletAlliad")) {
            if (this.gameObject.tag == "Enemy")
            {
                health -= pistol.Dmg;
            }
            if (this.gameObject.tag == "Tank")
            {
                health -= pistol.Dmg - 5;
            }
        }

        if (collision.CompareTag("Punch"))
        {
            if (this.gameObject.tag == "Enemy")
            {
                health -= hand.Dmg;
            }
            if (this.gameObject.tag == "Tank")
            {
                health -= hand.Dmg - 5;
            }
        }

        if (collision.CompareTag("Knock"))
        {
            if (this.gameObject.tag == "Enemy")
            {
                health -= stick.Dmg;
            }
            if (this.gameObject.tag == "Tank")
            {
                health -= stick.Dmg - 5;
            }
        }

    }
}
