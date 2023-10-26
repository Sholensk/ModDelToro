using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickMove : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody2D rb;
    public float force;
    public Vector2 combinedValue;
    private float horizontalValue;
    private float verticalValue;
    public Vector2 initialValue=new Vector2(0,0);
    private Vector2 _direction;
    private float _force;
    private float _distance;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void FixedUpdate()
    {
        Debug.Log(combinedValue);
        

        horizontalValue = joystick.Horizontal;
        verticalValue = joystick.Vertical;
        combinedValue = joystick.Direction;
        /*_distance=Vector2.Distance(initialValue, combinedValue);
        _direction=(initialValue-combinedValue).normalized;
        _force = _distance * 10;*/

        if (combinedValue ==new Vector2(0,0))
        {
            rb.AddForce(_direction * _force);
        }
        else
        {
            
            _distance = Vector2.Distance(initialValue, combinedValue);
            _direction = (initialValue - combinedValue).normalized;
            _force = _distance * 1000;
        }

        if (rb.velocity != new Vector2(0, 0))
        {
            rb.velocity=(initialValue);
            _force = 0;
        }

       /* if (combinedValue==initialValue)
        {
            rb.AddForce(combinedValue * 2);
            Debug.Log("equals values");
        }*/
    }
}
