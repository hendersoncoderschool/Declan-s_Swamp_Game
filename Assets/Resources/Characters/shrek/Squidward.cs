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
    private bool hit_by_potion;
    public GameObject Hand_me_that_Mirror;
    public GameObject Canvas;

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            prompt.SetActive(true);
            active = true;
            Dialouge_Box.SetActive(true);
            _Text.text = Dialouge[0];
            Canvas.SetActive(true);
            Canvas.GetComponent<Canva>().Dialouge = Dialouge;
            GameObject.Find("Canvas").GetComponent<Canva>().Dialouge = Dialouge;
            Canvas.GetComponent<Canva>().Numbers = 0;
        }
        if(collider.CompareTag("Liquid Water"))
        {
            //GameObject Squid = Instantiate(Hand_me_that_Mirror, transform.position, transform.rotation);
            Destroy(collider.gameObject);
            Hand_me_that_Mirror.transform.position = transform.position;
            Hand_me_that_Mirror.SetActive(true);
            Destroy(gameObject);
            /*
            prompt.SetActive(true);
            hit_by_potion = true;
            active = true;
            */
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
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
        hit_by_potion = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            /*if (line_dancing == Dialouge.Count && Input.GetKeyDown("space"))
                Dialouge_Box.SetActive(false);
            //prompt.SetActive(true);
            
            if (hit_by_potion == true)
            {
                Dialouge_Box.SetActive(true);
                _Text.GetComponent<TMP_Text>().text = Dialouge[4];
                hit_by_potion = false;
                line_dancing = 4;
            }
            
            if(Input.GetKeyDown("e"))
            {
                Dialouge_Box.SetActive(true);
                print(Dialouge.Count);
                if (line_dancing == Dialouge.Count)
                    line_dancing -= Dialouge.Count;
                

                _Text.GetComponent<TMP_Text>().text = Dialouge[line_dancing];
                line_dancing += 1;
            }*/
        }
    }
}
