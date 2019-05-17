using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour {

    public float Dmg = 5.0f;
    public float Range = 0.05f;
    // Use this for initialization
    void Start()
    {
        Weapom pistol = new Weapom();
        pistol.setDmg(Dmg);
        pistol.setRange(Range);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
