using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGeneratorSuelo : MonoBehaviour
{

    public GameObject Suelo1;

    private bool leftCreated;

    private void OnTriggerExit2D(Collider2D collision)
    {
        JohnMovement john = collision.GetComponent<JohnMovement>();
        if (john != null)
        {
            //Debug.Log("Sale");
            SpawnMap();

        }

    }

    private void SpawnMap()
    {
        //+12 unidades en el eje horizontal para que continue
        Vector3 act_pos = transform.parent.position;

        Instantiate(Suelo1, act_pos + new Vector3(12.0f, 0.0f), Quaternion.identity);

    }

}