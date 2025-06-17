using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Canva : MonoBehaviour
{
    public GameObject Dialouge_Box;
    public TMP_Text _Text;
    public List<string> Dialouge;
    public int Numbers;
    // Start is called before the first frame update
    void Start()
    {
        //Dialouge = GameObject.Find("potion").GetComponent<Collect>().Dialouge;
        Numbers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e") & Numbers < Dialouge.Count - 1)
        {
            Numbers++;
            _Text.text = Dialouge[Numbers];
        }
        if(Input.GetKeyDown("space"))
        {
            Dialouge_Box.SetActive(false);
        }
    }
}
