using System;
using UnityEngine;

public class Groundds : MonoBehaviour
{
    private GroundSpawner groundSpawn;
    
    public float jumpForce;
    public bool groundTouch = false;
    public static Action TriggerPoint;
    private Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

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

                    anim.SetTrigger("Trigger");
                    //Destroy(gameObject,1f);
                    
                    TriggerPoint.Invoke();
                }
           
                
            }
        }
        
    }

}
