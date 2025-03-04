using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Splash_Text : MonoBehaviour
{
    public List<string> Splashy;
    public float minsize;
    public float maxsize;
    private bool growing = true;
    private TMP_Text _Text;
    private RectTransform rtransform;
        
    // Start is called before the first frame update
    void Start()
    {
        //Splashy = new List<string>();
        _Text = GetComponent<TMP_Text>();
        rtransform = GetComponent<RectTransform>();
        _Text.fontSize = 50;
        _Text.text = Splashy[Random.Range(0, Splashy.Count-1)];
        StartCoroutine(SonicFont());
    }

    // Update is called once per frame
    IEnumerator SonicFont()
    {
        while (true)
        {
            if(growing)
            {
                rtransform.localScale += new Vector3(0.1f, 0.1f, 0);
                if(rtransform.localScale.x > maxsize) growing = false;
            }

            else
            {
                rtransform.localScale -= new Vector3(0.1f, 0.1f, 0);
                if(rtransform.localScale.x < minsize) growing = true;
            }
            yield return new WaitForSeconds(0.025f);
        }
    }

    void Update()
    {
        
    }
}
