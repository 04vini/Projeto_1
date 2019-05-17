using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBullet : MonoBehaviour {
    public Transform spawnerBullets;
    public GameObject bullets;
    // Use this for initialization
    void Start () {
        Instantiate(bullets, spawnerBullets.position, spawnerBullets.rotation);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
