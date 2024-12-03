using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchForBallPinCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.CompareTag("Pin")){
            Debug.Log("ball and pin collision");

            GetComponent<AudioSource>().Play(); //TODO, may need to put limits on this to not trigger 100 times in a row

        }
    }
}
