using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float move = Input.GetAxis("Horizontal");
        Debug.Log(move);
            if(Input.GetKeyDown(KeyCode.A) ){
               this.GetComponent<Animator>().StopPlayback();
                this.GetComponent<Animator>().Play("Strafe Left");
               

            }

            

            if(Input.GetKeyDown(KeyCode.D)){
                 this.GetComponent<Animator>().StopPlayback();
                this.GetComponent<Animator>().Play("Strafe Right");

            }

            if(!Input.anyKey){
                this.GetComponent<Animator>().StopPlayback();
                this.GetComponent<Animator>().Play("Idle");

            }
        

        Vector3 movement = new Vector3(move*speed*Time.deltaTime,0f,0f);
        transform.Translate(movement);

        
    }
}
