using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Coin : MonoBehaviour
{
    
    public int value;
    public GameObject sphere;
    private Vector3 scale = new Vector3(2.0f, 2.0f, 2.0f);
    void Start()
    {
       
    } 
    void Update()
    {
        transform.Rotate(0, 360 * Time.deltaTime , 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        ScaleUp();
        Debug.Log("Coin Get");
        GameManager.gm.score += value;
        Destroy(gameObject);
        
    
           
    }
    public void ScaleUp()
    {
        transform.localScale = transform.localScale + scale;
    }
  

    private void OnTriggerExit(Collider other)
    {

    }
    
}
