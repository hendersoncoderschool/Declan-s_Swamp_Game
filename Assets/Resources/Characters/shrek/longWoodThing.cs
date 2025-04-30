using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class longWoodThing : MonoBehaviour
{
    public GameObject Onion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Instantiate(Onion, transform.position, transform.rotation);
        }
    }
}
