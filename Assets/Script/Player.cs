using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public abstract class Player : MonoBehaviour
{

    //Movement
    protected Vector3 speed;
    [SerializeField] protected float drag = 0.95f;
    protected Vector3 acceleration;
    [SerializeField] protected float acceleration_factor = 1f;
    //KeyCodes
    [SerializeField] protected KeyCode up;
    [SerializeField] protected KeyCode left;
    [SerializeField] protected KeyCode down;
    [SerializeField] protected KeyCode right;
    [SerializeField] protected KeyCode attack;

    //Shoot
    protected float shootTimer;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        shootTimer += Time.deltaTime;
        Attacking();
    }

    protected void Movement()
    {
        if (drag > 1) drag = 1;
        if (drag < 0) drag = 0;

        acceleration = new Vector3(0, 0, 0);

        if (Input.GetKey(up))
        {
            acceleration += new Vector3(0, acceleration_factor, 0);
        }

        if (Input.GetKey(left))
        {
            acceleration += new Vector3(-acceleration_factor, 0, 0);
        }

        if (Input.GetKey(down))
        {
            acceleration += new Vector3(0, -acceleration_factor, 0);
        }

        if (Input.GetKey(right))
        {
            acceleration += new Vector3(acceleration_factor, 0, 0);
        }

        speed += acceleration;
        speed *= drag;

        transform.position += speed * Time.deltaTime;
    }

    protected abstract void Attacking();
}
