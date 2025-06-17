using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Robot : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Dialouge_Box;
    public TMP_Text _Text;
    public List<string> Dialouge;
    public List<string> Dialouge2;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            //GameObject.Find("Shrek").GetComponent<Mooove>().potions++;
            Dialouge_Box.SetActive(true);
            Canvas.SetActive(true);
            Canvas.GetComponent<Canva>().Numbers = 0;
            if(collider.gameObject.GetComponent<Mooove>().Onions < 5)
            {
            _Text.text = Dialouge[0];
            Canvas.GetComponent<Canva>().Dialouge = Dialouge;
            GameObject.Find("Canvas").GetComponent<Canva>().Dialouge = Dialouge;
            }
            else
            {
            _Text.text = Dialouge2[0];
            Canvas.GetComponent<Canva>().Dialouge = Dialouge2;
            GameObject.Find("Canvas").GetComponent<Canva>().Dialouge = Dialouge2;
            collider.gameObject.GetComponent<Mooove>().Onions -= 5;
            collider.gameObject.GetComponent<Mooove>().sacredOnions += 1;
            GameObject.Find("onionCount").GetComponent<TMP_Text>().text = "Onions = " + collider.gameObject.GetComponent<Mooove>().Onions.ToString();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
