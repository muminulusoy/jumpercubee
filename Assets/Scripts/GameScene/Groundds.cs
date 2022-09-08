using System;
using UnityEngine;

public class Groundds : MonoBehaviour
{
    [SerializeField]private GroundSpawner groundSpawn;
    
    public float jumpForce;
    public bool groundTouch = false;
    public static Action TriggerPoint;
    private Animator anim;

    public void Start()
    {
        groundSpawn = GameObject.Find("GroundSpawner").GetComponent<GroundSpawner>();//sorun
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        groundSpawn.SpawnGround();
        
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

                    //anim.SetBool("touch",true);
                    //Destroy(gameObject,1f);
                    
                    TriggerPoint.Invoke();
                }
           
                
            }
        }
        
    }

}
