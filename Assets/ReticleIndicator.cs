using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReticleIndicator : MonoBehaviour
{
    public TextMeshPro hintText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        hintText.text = "Enter" + other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        hintText.text = "Nope";
    }
}
