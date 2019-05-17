using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeapomMain : MonoBehaviour {

    
    public Outline[] outlinesEnable = new Outline[3];
    private bool has_equipped_hand = false;
    private bool has_equipped_pistol = false;
    private bool has_equipped_stick = false;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject handPrefab;
    public GameObject stickPrefab;
    public Text ammunitionTxt;
    public GameObject ammo;
    public int bullets = 100;

    Pistol pistol = new Pistol();
    Hand hand = new Hand();
    Stick stick = new Stick();
    

   

    // Use this for initialization
    void Start () {
     

    }
	
	// Update is called once per frame
	void Update () {

        if (bullets < 0)
        {
            bullets = 0;
        }

        if (bullets > 100)
        {
            bullets = 100;
        }

        ammunitionTxt.text = bullets+ "/100";

        if (Input.GetKeyDown(KeyCode.Alpha1)) {

            has_equipped_hand =! has_equipped_hand;
            has_equipped_pistol = false;
            has_equipped_stick = false;
            outlinesEnable[0].enabled =! outlinesEnable[0].enabled;
            outlinesEnable[1].enabled = false;
            outlinesEnable[2].enabled = false;
           
           
        }
        if (has_equipped_hand && Input.GetKeyDown(KeyCode.Z)) {

            Punch();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            has_equipped_pistol = !has_equipped_pistol;
            has_equipped_hand = false;
            has_equipped_stick = false;
            outlinesEnable[0].enabled = false;
            outlinesEnable[1].enabled =! outlinesEnable[1].enabled;
            outlinesEnable[2].enabled = false;
            

        }
        if (has_equipped_pistol && Input.GetKeyDown(KeyCode.Z))
        {
            Shoot();    
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            has_equipped_pistol = false;
            has_equipped_hand = false;
            has_equipped_stick =! has_equipped_stick;
            outlinesEnable[0].enabled = false;
            outlinesEnable[1].enabled = false;
            outlinesEnable[2].enabled =! outlinesEnable[2].enabled;


        }
        if (has_equipped_stick && Input.GetKeyDown(KeyCode.Z))
        {
            Knock();
        }


    }

    void Shoot() {
        if (bullets > 0)
        {
            GameObject prefabCopy = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullets --;
            Destroy(prefabCopy, pistol.Range);
        }
    }

    void Punch()
    {
        GameObject prefabCopy = Instantiate(handPrefab, firePoint.position, firePoint.rotation);
        Destroy(prefabCopy, hand.Range);

    }

    void Knock()
    {
        GameObject prefabCopy = Instantiate(stickPrefab, firePoint.position, firePoint.rotation);
        Destroy(prefabCopy, stick.Range);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bullet"))
        {
            bullets += 50;
            Destroy(ammo);
        }
    }



}
