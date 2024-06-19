using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float movement;

    public int hp = 5;
    
    void Start()
    {
        
        
        
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Food")){
            Debug.Log("Kena");
            hp--;


        }
    }

    public int getHp(){
        return this.hp;
    }



    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0,0,movement);

        
       
        
    }
}
