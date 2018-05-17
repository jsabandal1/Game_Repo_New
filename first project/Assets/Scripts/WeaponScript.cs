using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponScript : MonoBehaviour
{
    private GameObject explosion;
    public Weapon[] all = new Weapon[6];
    private int index = 0;
    public Weapon current_weapon;

    float rateOfFire;
    float TimeStamp;



    public Transform bulletSpawn;
    public Rigidbody2D rb;

    public float speed = 5.0f;

    // Use this for initialization
    void Start()
    {
        current_weapon = all[index];
        TimeStamp = Time.time;

        rb = GetComponent<Rigidbody2D>();


    }
    public void Fire(Weapon current)
    {
        rateOfFire = current_weapon.fire_rate;
        if (Time.time > TimeStamp + rateOfFire)
        {
            GameObject spawnBullet = Instantiate(current_weapon.projectile, bulletSpawn.transform.position, gameObject.transform.rotation);
            explosion = Instantiate(current_weapon.particle, bulletSpawn.transform.position, gameObject.transform.rotation);
            TimeStamp = Time.time;
            Destroy(explosion,3);
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        current_weapon = all[index];
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Fire(current_weapon);
            print("shot");
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            index = 0;
            print(index);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            index = 1;
            print(index);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            index = 2;
        }
    }
}
