using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    Rigidbody2D rb2d;
    Vector2 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
     rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(0, playerDirection.y*playerSpeed);

    }
}
