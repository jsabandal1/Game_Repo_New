using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            GameObject.FindGameObjectWithTag("spawn point").GetComponent<powerup_spawn>().exists = false;
            Destroy(gameObject);
        }
    }
}
