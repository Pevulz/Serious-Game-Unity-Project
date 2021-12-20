using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileClue : MonoBehaviour
{
    [SerializeField] GameObject item;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        if(item == null) {
            item = GameObject.FindGameObjectWithTag("Item");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") { //when player touches game object
    
            Destroy(item); //destroys itself 
        }
    }
}
