using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMotion : MonoBehaviour
{
    public float amplitude;          //Set in Inspector 
     public float speed;                  //Set in Inspector 
     public float Value;
     public Vector3 Position;
    // Start is called before the first frame update
    void Start()
    {
        Value = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Position.y = Value + amplitude * Mathf.Sin(speed * Time.time);
         transform.position = Position;
    }
}
