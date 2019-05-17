using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour {

    public float countdownFire = 2.0f;
    public Transform firePoint;
    public GameObject[] bulletPrefab = new GameObject[2];
    public Transform Player;
    public Transform Enemy;
    GameObject prefabCopy;
    public bool rangeOn;
    private GameObject playerGO;
    public float distance;
    private float Follow;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        playerGO = GameObject.FindWithTag("Player"); // aqui nos buscamos a Tag " Player " e igualamos o objeto Player ao objeto retornado pelo FindWithTag
        distance = Vector3.Distance(playerGO.transform.position, transform.position); // aqui e a distancia entre o objeto que tem o script e o Player
       
        

        Enemy.LookAt(Player);
        countdownFire -= Time.deltaTime;
        if (countdownFire <= 0 && rangeOn) {
            ShootEnemy();
            countdownFire = 2.0f;
        }


        if (this.gameObject.tag == "Enemy")
        {
            FireDistanceEnemy();
        }


        if (this.gameObject.tag == "Tank")
        {
            FireDistanceTank();
        }

       
    }

    void ShootEnemy()
    {
        if (this.gameObject.tag == "Enemy")
        {
            prefabCopy = Instantiate(bulletPrefab[0], firePoint.position, firePoint.rotation);
            Destroy(prefabCopy, 2.0f);
        }
        if (this.gameObject.tag == "Tank")
        {
            prefabCopy = Instantiate(bulletPrefab[1], firePoint.position, firePoint.rotation);
            Destroy(prefabCopy, 2.0f);
        }
    }

    void FireDistanceEnemy() {
        if (distance <= 3)
        {
            rangeOn = true;
            Follow = 0.0f;
        }

        else if (distance > 3 && distance < 4.5f)
        {
            Follow = 2.0f;
            transform.position = Vector2.Lerp(Enemy.position, playerGO.transform.position, Follow * Time.deltaTime);
           
           
        }
        else if (distance >= 5) {
            
            Follow = 0.0f;
            rangeOn = false;
        }
        else
        {
            rangeOn = false;
        }

    }

    void FireDistanceTank() {
        if (distance <= 2)
        {
            Follow = 0.0f;
            rangeOn = true;
        }
        else if (distance > 2 && distance < 6)
        {
            Follow = 1.0f;
            transform.position = Vector2.Lerp(Enemy.position, playerGO.transform.position, Follow * Time.deltaTime);
          
        }
        else if (distance >= 6)
        {
            Follow = 0.0f;
            rangeOn = false;
        }

        else
        {
            rangeOn = false;
        }

    }

   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            rangeOn = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rangeOn = false;
        }
    }*/

}
