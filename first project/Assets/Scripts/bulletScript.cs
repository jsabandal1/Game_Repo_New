using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {
    private static int counter = 0;
    public float bulletSpeed;
    public GameObject grenagde;
    private GameObject explosion;
    public float dmg;
    public float damage
    {
        get { return dmg;}
    }
    internal static int Counter
    {
        get { return counter; }
        set { counter = value; }
    }
	// Use this for initialization
	void Start () {
        //Destroy(gameObject, 5);
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(bulletSpeed * Time.deltaTime * Vector2.up);
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("unbreakable"))
        {

            Destroy(gameObject);
        }
        else if(gameObject.tag.Equals("grenade"))
        {
            explosion = Instantiate(grenagde, gameObject.transform.position, Quaternion.identity);
            Destroy(explosion, 2);
        }
    }
}
