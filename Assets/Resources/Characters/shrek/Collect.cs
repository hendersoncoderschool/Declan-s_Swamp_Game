using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collect : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Dialouge_Box;
    public TMP_Text _Text;
    public List<string> Dialouge;
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            GameObject.Find("Shrek").GetComponent<Mooove>().potions++;
            Dialouge_Box.SetActive(true);
            _Text.text = Dialouge[0];
            Canvas.SetActive(true);
            Canvas.GetComponent<Canva>().Dialouge = Dialouge;
            GameObject.Find("Canvas").GetComponent<Canva>().Dialouge = Dialouge;
            Canvas.GetComponent<Canva>().Numbers = 0;
            Destroy(gameObject);
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
