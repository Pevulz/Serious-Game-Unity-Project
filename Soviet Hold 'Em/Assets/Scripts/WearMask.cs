using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WearMask : MonoBehaviour
{
    public float timer = 5f; 

    void Start() 
    {
    
    }

    void Update() 
    {
        if(timer > 0) {
            timer -= Time.deltaTime;
            Debug.Log(timer);
         
        }

        if(timer <= 0)
            SceneManager.LoadScene("Level 2");
    }
}
