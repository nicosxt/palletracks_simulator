using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTEst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("Trigger Enter" + other.name);
    }
}
