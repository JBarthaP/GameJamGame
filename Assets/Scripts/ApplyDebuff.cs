using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDebuff : MonoBehaviour
{
    public AudioClip debuffAudio;
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
            Camera.main.GetComponent<AudioSource>().PlayOneShot(debuffAudio);
            john.DebuffJohn();

        }
    }
}
