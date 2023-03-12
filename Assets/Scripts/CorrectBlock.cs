using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectBlock : MonoBehaviour
{

    bool enter = false;
    public AudioClip sound; 
    public void OnTriggerEnter2D(Collider2D collision)
    {
        JohnMovement john = collision.gameObject.GetComponent<JohnMovement>();
        if (john != null && !enter)
        {
            john.updateCounter(-1);
            enter = true;
            Camera.main.GetComponent<AudioSource>().PlayOneShot(sound);

        }
    }
}
