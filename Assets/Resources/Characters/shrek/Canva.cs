using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Canva : MonoBehaviour
{
    public GameObject Dialouge_Box;
    public TMP_Text _Text;
    public List<string> Dialouge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e"))
        {
            _Text.text = Dialouge[1];
        }
        if(Input.GetKeyDown("space"))
        {
            Dialouge_Box.SetActive(false);
        }
    }
}
