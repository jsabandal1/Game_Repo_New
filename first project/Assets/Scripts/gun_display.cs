using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gun_display : MonoBehaviour {
    private Weapon current;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        current = GameObject.FindGameObjectWithTag("Player").GetComponent<WeaponScript>().current_weapon;
        gameObject.GetComponent<SpriteRenderer>().sprite = current.artwork;
	}
}
