using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private Vector3 speed;
    [SerializeField] private float drag = 0.95f;
    private Vector3 acceleration;
    [SerializeField] private float acceleration_factor = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Camera>())
        {
            Destroy(this.gameObject);
        }
    }

    private void Movement()
    {
        if (drag > 1) drag = 1;
        if (drag < 0) drag = 0;

        acceleration = new Vector3(0, acceleration_factor, 0);

        speed += acceleration;
        speed *= drag;

        transform.position += speed * Time.deltaTime;
    }
}
