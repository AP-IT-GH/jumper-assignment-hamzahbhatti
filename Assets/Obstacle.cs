using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float Movespeed = 1f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.back * Movespeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("wallend") == true)
        {
            Destroy(this.gameObject);
        }
    }

}
