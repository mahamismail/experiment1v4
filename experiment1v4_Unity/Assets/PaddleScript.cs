using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public KeyCode moveLeft = KeyCode.W;
    public KeyCode moveRight = KeyCode.S;
    public float speed = 10.0f;
    public float boundX = 3.25f;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update () {
        var vel = rb2d.velocity;
            if (Input.GetKey(moveRight)) {
                vel.x = speed;
            }
            else if (Input.GetKey(moveLeft)) {
                vel.x = -speed;
            }
            else {
                vel.x = 0;
            }
            rb2d.velocity = vel;

            var pos = transform.position;
            if (pos.x > boundX) {
                pos.x = boundX;
            }
            else if (pos.x < -boundX) {
                pos.x = -boundX;
            }

        transform.position = pos;
    }
}
