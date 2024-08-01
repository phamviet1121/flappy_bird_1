using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create : MonoBehaviour
{
    public GameObject colurmn;
    float time;
    public float time_dutation = 2;
    public bool batdau;

    // Start is called before the first frame update
    void Start()
    {
        time =1;
        batdau = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(batdau)
        {
            time -= Time.deltaTime;
            if ((time <= 0))
            {

                Instantiate(colurmn, new Vector3(10, Random.Range(0.5f, -2.5f), 0), Quaternion.identity);

                time = time_dutation;
            }
        }    
            
    }
}
