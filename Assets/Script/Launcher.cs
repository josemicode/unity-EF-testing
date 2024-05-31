using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    Rigidbody2D rb;

    public float shootPower = 100f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<CircleCollider2D>();
        rb = gameObject.AddComponent<Rigidbody2D>();
        rb.isKinematic = true;
        rb.mass = 20;
    }

    void onMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
        }
    }

    void OnMouseUp()
    {
        if(Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            direction = startPos - endPos;
            rb.isKinematic = false;
            rb.AddForce(direction * shootPower, ForceMode2D.Impulse);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
