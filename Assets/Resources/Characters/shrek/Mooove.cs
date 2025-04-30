using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mooove : MonoBehaviour
{
    public GameObject Pig_Vat;
    private Rigidbody rb;
    public float jumpForce;
    public bool grounded;
    public Animator anim;
    public float maxSpeed;
    public float speed;
    public int potions;
    public GameObject potion;
    public Material BLOODRED;
    public GameObject Body;
    private GameObject NewPotion;
    public GameObject Image;
    public bool GameOgre;
    // Start is called before the first frame update
    void Start()
    {
        NewPotion = null;
        potions = 0;
        rb = GetComponent<Rigidbody>();
        GameOgre = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(potions);
        Pig_Vat.transform.position = transform.position + new Vector3(0f, 1f);

        if (Input.GetKey("w"))
        {
            //transform.Translate(Vector3.forward * 50f * Time.deltaTime);
            rb.AddForce(transform.forward * speed * Time.deltaTime);
            anim.SetFloat("Speed", 15f);
        }
        else if (Input.GetKey("s"))
        {
            //transform.Translate(Vector3.forward * -50f * Time.deltaTime);
            rb.AddForce(transform.forward * -speed * Time.deltaTime);
            anim.SetFloat("Speed", 15f);
        }
        else
        {
            anim.SetFloat("Speed", 0f);
        }
        

        /*if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.forward * -50f * Time.deltaTime);
        }
*/
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up * -500f *Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * 500f *Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))
        {
            if(grounded)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                grounded = false;
            }
            else
            {
                rb.AddForce(-Vector3.up * jumpForce * 2, ForceMode.Impulse);
                grounded = true;
            }
        }

        if (potions > 0 && Input.GetKeyDown("q"))
        {
            if (NewPotion != null)
            {
                Destroy(NewPotion);
            }
            NewPotion = Instantiate(potion, transform.position + transform.forward * 2f, transform.rotation);
            NewPotion.GetComponent<Rigidbody>().AddForce(transform.forward * 1000f, ForceMode.Impulse);
        }

        if(rb.velocity.magnitude > maxSpeed)
        {
            Vector3 newVelocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z).normalized;
            newVelocity *= maxSpeed;
            rb.velocity = new Vector3(newVelocity.x, rb.velocity.y, newVelocity.z);
        }

        if(GameOgre && Input.GetKeyDown("f"))
        {
            SceneManager.LoadScene("TITLE");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Taco"))
        {
            Cursor.lockState = CursorLockMode.None;
            Material[] materials = {null};
            Body.GetComponent<SkinnedMeshRenderer>().materials = materials;
            Image.SetActive(true);
            Destroy(collision.gameObject);
            GameOgre = true;
        }
    }
}
