using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    //SerializedField oznacza możliwość zmiany w inspektorze bez upubliczniania zmniennej
    [SerializeField]
    private float jumpForce = 7.0f;
    [SerializeField]
    private float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        //połączenie z komponentem Rigidbody
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float move = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {   //dodanie skoku do prędkości ruchu
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }    //dodanie prędkości ruchu do komponentu rigidbody
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }
}
