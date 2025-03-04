using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour
{
    private Mooove shrek;

    // Start is called before the first frame update
    void Start()
    {
        shrek = GameObject.Find("Shrek").GetComponent<Mooove>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Ground"))
        {
            shrek.grounded = true;
        }
    }
}
