using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private float thrust = 1.0f;

    void Start()
    {
        rb2D = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector2(0.276f, 0.0f);
    }//0.018x closed


    // Update is called once per frame

    void FixedUpdate()
    {
     //  rb2D.AddForce(transform.left * thrust, ForceMode2D.Force);
    }
}
