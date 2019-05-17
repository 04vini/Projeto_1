using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour {

    public float Dmg = 15.0f;
    public float Range = 0.09f;
    // Use this for initialization
    void Start () {
        Weapom pistol = new Weapom();
        pistol.setDmg(Dmg);
        pistol.setRange(Range);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
