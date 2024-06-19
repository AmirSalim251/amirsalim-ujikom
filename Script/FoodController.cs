using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    
    void Start()
    {
        
        
        
    }



    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0,0,20);
       
        
    }

   
}
