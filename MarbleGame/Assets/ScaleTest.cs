using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ScaleTest : MonoBehaviour
{
    private Vector3 scale = new Vector3(1.1f, 1.1f, 1.1f);
    void Start()
    {
        
    }

   
    void Update()
    {
        ScaleUp();
    }

    public void ScaleUp()
    {
        transform.localScale = Time.deltaTime * transform.localScale + scale;
    }
}
