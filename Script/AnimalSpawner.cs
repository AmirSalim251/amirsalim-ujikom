using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animal;
    public Transform[] spawnPosition;
     GameObject spawnedAnimal;

    System.Random random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(spawner());
        
    }

    // Update is called once per frame
    void Update()
    {
        
     
      
    }

    void spawnAnimal(){
        int indexAnimal = random.Next(0,4);
        int indexPos = random.Next(0,4);

        spawnedAnimal = Instantiate(animal[indexAnimal],spawnPosition[indexPos].position,Quaternion.identity);
        
         

    }

    IEnumerator spawner(){
        while(true){
        yield return new WaitForSeconds(3f);
         
        spawnAnimal();

        if(spawnedAnimal.GetComponent<AnimalController>().getHp() == 0){
            Destroy(spawnedAnimal);
        }
        }
        
        
    }
}
