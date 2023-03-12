using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyBuffScript : MonoBehaviour
{

    public AudioClip buffAudio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        JohnMovement john = collision.gameObject.GetComponent<JohnMovement>();
        if (john != null)
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(buffAudio);
            john.BuffJohn();

        }
    }
}
