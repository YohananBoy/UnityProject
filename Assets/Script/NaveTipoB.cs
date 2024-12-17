using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveTipoB : Player
{
    [SerializeField] private GameObject shoot;
    [SerializeField] private Transform spawn1;
    [SerializeField] private Transform spawn2;
    [SerializeField] private float shootCooldown = 0.4f;
    [SerializeField] private float damage;

    protected override void Attacking()
    {
        if (Input.GetKey(attack))
        {
            if (shootTimer >= shootCooldown)
            {
                GameObject bullet1 = Instantiate(shoot, spawn1.position, new Quaternion(0, 0, 0, 0));
                GameObject bullet2 = Instantiate(shoot, spawn2.position, new Quaternion(0, 0, 0, 0));
                bullet1.transform.localScale += new Vector3(-0.3f, 0, 0);
                bullet2.transform.localScale += new Vector3(-0.3f, 0, 0);
                shootTimer = 0f;
            }
        }
    }
}

