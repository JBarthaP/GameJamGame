using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject John;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (John != null)
        {
            Vector3 pos = transform.position;

            Debug.DrawRay(transform.position, Vector3.down * 2f, Color.red);

            pos.x = John.transform.position.x;
            pos.y = John.transform.position.y;

            transform.position = pos;
        }

        

    }

}
