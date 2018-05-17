using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup_spawn : MonoBehaviour {
    public GameObject[] powerup;
    public int arraymax;
    int arraynum;
    int triggervalue=60;
    int randomValue;
    public int max;
    public bool exists=false;
    
	
	// Update is called once per frame
	void Update ()
    {
        arraynum = Random.Range(0, arraymax);
        randomValue = Random.Range(0, max);
        if(triggervalue == randomValue && exists==false)
        {
            Instantiate(powerup[arraynum], gameObject.transform);
            exists = true;
        }
	}
   
}
