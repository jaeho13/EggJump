using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float speed;

    Rigidbody2D rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();   // 소스 상에서 중력 무시 및 Z축 회전 방지를 한다. rbody.gravityScale = 0;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionY;
    }

 void FixedUpdate()
    {
        //물리 엔진의 속도로 X축으로 이동
        rbody.velocity = new Vector2(speed, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Wall"))
        {
        speed = -speed;
        this.GetComponent<SpriteRenderer>().flipX = (speed < 0);      
        }
    }
}