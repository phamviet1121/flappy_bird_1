using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_column : MonoBehaviour

{
    public float speed=2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();


    }
    private void Move()
    {
        //Vector3: x, y, z
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

}
