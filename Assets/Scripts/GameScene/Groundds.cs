using System;
using UnityEngine;

public class Groundds : MonoBehaviour
{
    public float jumpForce;
    public bool groundTouch = false;
    public static Action TriggerPoint;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 jumpVelocity = rb.velocity;
                jumpVelocity.y = jumpForce;
                rb.velocity = jumpVelocity;
                
                if (groundTouch == false)
                {
                    groundTouch = true;
                    
                    TriggerPoint.Invoke();
                }
            }
        }
        
    }

}
