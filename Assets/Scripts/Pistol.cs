using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour {

    public float Dmg = 10.0f;
    public float Range = 0.5f;
    public float sizeFire = 10.0f;
    public float cadenceFire = 10.0f;
    // Use this for initialization
    void Start () {
        Weapom pistol = new Weapom();
        pistol.setDmg(Dmg);
        pistol.setCadenceFire(cadenceFire);
        pistol.setRange(Range);
        pistol.setSizeFire(sizeFire);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
