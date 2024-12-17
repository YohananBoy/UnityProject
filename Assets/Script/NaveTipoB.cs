using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveTipoB : Player
{
    [SerializeField] protected float shootCooldown = 0.4f;

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

