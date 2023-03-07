using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_EggJump : MonoBehaviour
{

    Rigidbody2D rb;
    public float jumpPower;
    
    int R_EggLayer, CloudLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        R_EggLayer = LayerMask.NameToLayer("R_Egg");
        CloudLayer = LayerMask.NameToLayer("Cloud");
    }

    // Update is called once per frame
    void Update()
    {   if (Input.GetMouseButtonDown(0)) //왼쪽 버튼은 0
        {
            rb.velocity = Vector2.up * jumpPower; //(0.3)
        }

        if (rb.velocity.y > 0.05)
            Physics2D.IgnoreLayerCollision(R_EggLayer, CloudLayer, true);
        else
            Physics2D.IgnoreLayerCollision(R_EggLayer, CloudLayer, false);
            
    }
}