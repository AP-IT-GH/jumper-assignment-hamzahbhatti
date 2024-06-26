using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab = null;
    public Transform spawnpoint = null;
    public float min = 3.0f;
    public float max = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(min, max));   
    }
    private void Spawn()
    {
        GameObject go = Instantiate(prefab);
        go.transform.position = new Vector3(spawnpoint.position.x, spawnpoint.position.y, spawnpoint.position.z);
        Invoke("Spawn", Random.Range(min, max));
    }
}
