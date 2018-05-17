using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickbehaviour : MonoBehaviour {
    public float health;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<bulletScript>() != null)
        {
            print(collision);
            health -= collision.gameObject.GetComponent<bulletScript>().damage;
            Destroy(collision.gameObject);
        }
        //else if(collision.gameObject.GetComponent<>() != null)
        //{

        //}
        //else if (health <= 0)
        //{
        //    Destroy(gameObject);
        //}

    }
}
