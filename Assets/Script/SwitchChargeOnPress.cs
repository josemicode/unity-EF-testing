using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchChargeOnPress : MonoBehaviour
{

    public MovingChargedParticle2D myParticle;
    public float charge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myParticle = gameObject.GetComponent<MovingChargedParticle2D>();
        charge = myParticle.charge;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            myParticle.charge = charge * (-1);
            myParticle.UpdateColor();
        }else if(Input.GetKeyUp(KeyCode.Space))
        {
            myParticle.charge = charge * (-1);
            myParticle.UpdateColor();
        }
    }
}
