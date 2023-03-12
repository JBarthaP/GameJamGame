using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDebuff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        JohnMovement john = collision.GetComponent<JohnMovement>();
        if (john != null)
        {
            john.DebuffJohn();

        }
    }
}
