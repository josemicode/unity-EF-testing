using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingChargedParticle2D : ChargedParticle2D
{
    public float particleMass = 1;
    public Rigidbody2D rb;

    void Start()
    {
        UpdateColor();

        gameObject.AddComponent<CircleCollider2D>();
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.mass = particleMass;
        rb.gravityScale = 0;
        
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
