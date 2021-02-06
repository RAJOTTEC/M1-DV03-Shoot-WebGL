using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    // 1
    public GameBehavior gameManager;

    void Start()
    {
        // 2
        gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
            {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item collected!");

            // 3
            gameManager.Items += 1;
        }
    }
}
