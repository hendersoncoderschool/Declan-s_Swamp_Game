using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Squidward : MonoBehaviour
{
    public TMP_Text _Text;
    public List<string> Dialouge;
    public GameObject Dialouge_Box;
    public GameObject prompt;
    private int line_dancing;
    private bool active;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            prompt.SetActive(true);
            active = true;
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            prompt.SetActive(false);
            active = false;
        }
    }

    private void OnTriggerStay(Collider collider)
    {
        
    }


    // Start is called before the first frame update
    void Start()
    {
        prompt.SetActive(false);
        _Text.text = Dialouge[0];
        line_dancing = 0;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(line_dancing);
        if (active)
        {
            if (line_dancing == 4 && Input.GetKeyDown("space"))
                Dialouge_Box.SetActive(false);
            //prompt.SetActive(true);
            if(Input.GetKeyDown("e"))
            {
                Dialouge_Box.SetActive(true);
                if (line_dancing == 4)
                    line_dancing -= 4;
                

                _Text.GetComponent<TMP_Text>().text = Dialouge[line_dancing];
                line_dancing += 1;
            }
        }
    }
}
