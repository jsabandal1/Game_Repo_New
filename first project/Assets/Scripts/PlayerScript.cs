using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    float hInput;
    float vInput;
    float sprintInput;

    Vector3 mouse;

    public float stamina;
    public float health;
    public float maxStamina;
    public float maxhealth;

    float sprintSpeed = 10.0f;
    public float speed = 5.0f;

    public bool runAble;

    public GameObject stamineFG;

    void Start()
    {
        stamina = 100;
        health = 100;

        maxStamina = stamina;
        maxhealth = health;
    }

    void Update()
    {
        stamineFG.transform.localScale = new Vector3(stamina / maxStamina, 1, 1);
        if (health < maxhealth)
        {
            health++;
        }
        if (stamina < maxStamina)
        {
            stamina++;
        }
        if (stamina > maxStamina || stamina == maxStamina)
        {
            runAble = true;
        }
        if (stamina < 0)
        {
            runAble = false;
        }

        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();

        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

        if (Input.GetKey(KeyCode.LeftShift) && runAble)
        {
            transform.Translate(new Vector2(0, vInput * sprintSpeed * Time.deltaTime));
            stamina -= 2;
        }
        else
        {
            transform.Translate(new Vector2(0, vInput * speed * Time.deltaTime));
        }


    }

}
