using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Person : MonoBehaviour {
    public Image healthBar;
    public float maxHealth = 100;
    public float health = 100;
    public Text text;
    private GameObject Recharge;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        healthBar.fillAmount = health / maxHealth;
        text.text = health + " / " + maxHealth;
 
    }


}
