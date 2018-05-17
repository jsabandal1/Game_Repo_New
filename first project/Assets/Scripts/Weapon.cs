using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon",menuName = "weapon")]
public class Weapon : ScriptableObject {

    public string name;
    public Sprite artwork;
    public float fire_rate;
    public float R_speed;
    public GameObject projectile;
    public GameObject particle;
    public AudioSource sound;
}
