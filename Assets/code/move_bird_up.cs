using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move_bird_up : MonoBehaviour
{

    public Rigidbody2D rb;
    public float down = 12f;
    public bool leverStar;
    public GameObject gamecontreller;
    public Animator amin;

    // Start is called before the first frame update
    //void Start()
    //{
    //    rb = this.gameObject.GetComponent<Rigidbody2D>();

    //}
    private void Awake()
    { 
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        leverStar = false;
        rb.gravityScale = 0;
        amin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (leverStar==false)
            {
                leverStar = true;
                rb.gravityScale = 6;
                //gan giá trị cho biến bool batdau trong creste.cs
                gamecontreller.GetComponent<create>().batdau = true;
            }
           
                jump();
                amin.SetTrigger("bay");
            

        }
    }
    private void jump()
    {
       // rb.AddForce(Vector3.up * down, (ForceMode2D)ForceMode.Impulse);
       rb.velocity = Vector2.up * down;
    }
       
}
