using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnPool;
    public GameObject quad;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
    }


    public void spawnObjects()
    {
        GameObject toSpawn;
        //MeshCollider c = quad.GetComponent<MeshCollider>();

        toSpawn = spawnPool;

        float screenX, screenY;
        Vector2 pos;

        screenX = i;
        //Random.Range(c.bounds.min.x, c.bounds.max.x);
        screenY = -1;
        //Random.Range(c.bounds.min.y, c.bounds.max.y);

        i += 1;
        pos = new Vector2(screenX, screenY);

        Instantiate(toSpawn, pos, toSpawn.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
