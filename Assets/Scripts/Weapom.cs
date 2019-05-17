using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapom : MonoBehaviour {

    private float Dmg;
    private float Range;
    private float sizeFire;
    private float cadenceFire;

    public Weapom() {

    }
    public Weapom(float Dmg, float Range, float sizeFire, float cadenceFire) {

        this.Dmg = Dmg;
        this.Range = Range;
        this.sizeFire = sizeFire;
        this.cadenceFire = cadenceFire;

    }
    public float getDmg() {
        return Dmg;
    }

    public void setDmg(float Dmg) {
        this.Dmg = Dmg;
    }

    public float getRange() {
        return Range;
    }
    public void setRange(float Range)
    {
         this.Range = Range;
    }

    public float getSizeFire() {
        return sizeFire;
    }

    public void setSizeFire(float sizeFire)
    {
        this.sizeFire = sizeFire;
    }

    public float getCadenceFire() {
        return cadenceFire;
    }

    public void setCadenceFire(float cadenceFire)
    {
        this.cadenceFire = cadenceFire;
    }

    

}
