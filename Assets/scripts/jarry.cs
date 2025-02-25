using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jarry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        CapsuleCollider2D capsuleCollider2D = rb.GetComponent<CapsuleCollider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
