using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capacitor : MonoBehaviour
{
    public float fieldValue = 1f;
    private float forceValue;
    private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = gameObject.AddComponent<BoxCollider2D>();
        col.isTrigger = true;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.attachedRigidbody)
        {
            forceValue = other.gameObject.GetComponent<MovingChargedParticle2D>().charge * fieldValue;
            other.attachedRigidbody.AddForce(forceValue * this.transform.right);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
