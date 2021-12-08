using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] GameObject rat;
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
            Instantiate(rat, new Vector3(-3f, -5.8f, 0f), transform.rotation); //spawn rat on x,y,z
        }
    }
}
