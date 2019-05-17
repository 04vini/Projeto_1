using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemy : MonoBehaviour {
    public Transform spawnerEnemy;
    public GameObject enemy;
  

    // Use this for initialization
    void Start () {
      
        Instantiate(enemy, spawnerEnemy.position, spawnerEnemy.rotation);
      

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
