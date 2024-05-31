using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager2D : MonoBehaviour
{
    public float intensity = 1;

    private List<ChargedParticle2D> ChargedParticles;
    private List<MovingChargedParticle2D> MovingChargedParticles;

    // Start is called before the first frame update
    void Start()
    {
        ChargedParticles = new List<ChargedParticle2D>(FindObjectsOfType<ChargedParticle2D>());
        MovingChargedParticles = new List<MovingChargedParticle2D>(FindObjectsOfType<MovingChargedParticle2D>());   
    }

    // Update is called once per frame
    void Update()
    {
        foreach(MovingChargedParticle2D mcp in MovingChargedParticles){
            ApplyForce(mcp);
        }
        
    }

    private void ApplyForce(MovingChargedParticle2D mcp)
    {
        Vector2 newForce = Vector2.zero;
        foreach(ChargedParticle2D cp in ChargedParticles){

            if(mcp == cp){
                continue;
            }

            float distance = Vector2.Distance(mcp.transform.position, cp.gameObject.transform.position);
            float force = intensity * mcp.charge * cp.charge / Mathf.Pow(distance,2); 

            Vector2 direction = mcp.transform.position - cp.transform.position;
            direction.Normalize();
            newForce += force*direction;

           
        }

        mcp.rb.AddForce(newForce);
    }
}
