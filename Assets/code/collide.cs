using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class collide : MonoBehaviour

{
    private int diem;
    public Text luudiem;

    
    // Start is called before the first frame update
    void Start()
    {
        diem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        luudiem.text = diem.ToString();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tran"))
        {

        }
        else
        {
            relouts();
            Debug.Log("va chạm với player");
            diem = 0;

        }
    }
    public void relouts()
    {
        SceneManager.LoadScene("play_screen");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       
            Debug.Log("điểm +1");
        diem += 1;
       
        
    }
}
