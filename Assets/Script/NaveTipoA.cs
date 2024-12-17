using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveTipoA : Player
{
    [SerializeField] private GameObject shoot;
    [SerializeField] private Transform spawn;
    [SerializeField] private float shootCooldown = 0.4f;
    [SerializeField] private float damage;


    protected override void Attacking()
    {
        if (Input.GetKey(attack))
        {
            if (shootTimer >= shootCooldown)
            {
                Instantiate(shoot, spawn.transform.position, new Quaternion(0, 0, 0, 0));
                shootTimer = 0f;
            }
        }
    }
}
