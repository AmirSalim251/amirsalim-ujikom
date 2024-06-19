using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    
    public float speed;
    public GameObject food;
    AudioSource audioSource;
    public AudioClip sfxClip;
    public Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        audioSource= this.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float move = Input.GetAxis("Horizontal");
        Debug.Log(move);
            if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) ){
               this.GetComponent<Animator>().StopPlayback();
                this.GetComponent<Animator>().Play("Strafe Left");
               

            }

            

            if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)){
                 this.GetComponent<Animator>().StopPlayback();
                this.GetComponent<Animator>().Play("Strafe Right");

            }

            if(!Input.anyKey){
                this.GetComponent<Animator>().StopPlayback();
                this.GetComponent<Animator>().Play("Idle");

            }

            if(Input.GetKeyDown(KeyCode.Mouse0)){
                GameObject spawnedFood = Instantiate(food,spawnPosition.position,Quaternion.identity);
                audioSource.PlayOneShot(sfxClip);
                Destroy(spawnedFood,3f);

            }
        

        Vector3 movement = new Vector3(move*speed*Time.deltaTime,0f,0f);
        transform.Translate(movement);

        

        
    }
}
