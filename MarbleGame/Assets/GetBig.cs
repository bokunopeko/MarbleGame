using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GetBig : MonoBehaviour
{

 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Big")
        {
            GetBigger();
            Destroy(gameObject);
        }
    }

    public void GetBigger()
    {
       
        
    }

}
