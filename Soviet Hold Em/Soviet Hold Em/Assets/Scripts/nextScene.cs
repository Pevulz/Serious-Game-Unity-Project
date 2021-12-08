using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    [SerializeField] GameObject item;

    void Start()
    {
        if(item == null) {
            item = GameObject.FindGameObjectWithTag("Item");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            SceneManager.LoadScene("Level 2b");
    }
}
