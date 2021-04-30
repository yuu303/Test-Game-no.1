using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppleController : MonoBehaviour
{
    GameObject director;

    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.director.GetComponent<GameDirector>().GetApple();
            Destroy(this.gameObject);
        }
    }
// Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        
    }
}
