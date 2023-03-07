using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D rb;
    
    float moveX;

    [SerializeField] [Range(100f, 800f)] float moveSpeed = 400f;
    [SerializeField] [Range(100f, 800f)] float jumpForce = 500f;

    int PlayerLayer, GroundLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        PlayerLayer = LayerMask.NameToLayer("Player");
        GroundLayer = LayerMask.NameToLayer("Ground");
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        rb.velocity = new Vector2(moveX, rb.velocity.y);

        if(Input.GetButtonDown("Jump"))
        {
            if (rb. velocity.y == 0)
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Force);
        }
    
        if (rb.velocity.y > 0)
            Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, true);
        else
            Physics2D.IgnoreLayerCollision(PlayerLayer, GroundLayer, false);
    }
}
