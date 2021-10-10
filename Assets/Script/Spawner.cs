using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    private Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {

        spawnObject();
    }

    public void spawnObject()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for(int i = 0; i < numberToSpawn; i++)
        {
            StartCoroutine(wait());
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);

            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            StartCoroutine(wait());
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
    }



    private void destroyObject()
    {
        foreach(GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
        {
            Destroy(o);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
