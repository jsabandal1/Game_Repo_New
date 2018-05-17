using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade_script : MonoBehaviour {
    private static int counter = 0;
    public float bulletSpeed;
    public float dmg;
    public float damage
    {
        get { return dmg; }
    }
    internal static int Counter
    {
        get { return counter; }
        set { counter = value; }
    }
    
    // Use this for initialization
    void Start()
    {
        //Destroy(gameObject, 5);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("unbreakable"))
        {

            Destroy(gameObject);
        }
    }
}
