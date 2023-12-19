using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PR_RayInteractor : MonoBehaviour
{
    public TextMeshPro debugText;
    public string direction;
    public bool isStayingInObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnHoverEnter(){
        //debugText.text = "ENTER " + PR_Controller.i.raycastingObjL.name;
    }

    //this works with OnTriggerStay in ReticleIndicator.cs
    public void OnHoverExit(){
        //debugText.text = "EXIT " + PR_Controller.i.raycastingObjR.name;
    }

    public void OnSelectEntering(){
        debugText.text = "SelectEntering";
    }
    public void OnSelectExiting(){
        debugText.text = "SelectExiting";
    }
    public void OnUISelectEntering(){
        debugText.text = "UISelectEntering";
    }
    public void OnUISelectExiting(){
        debugText.text = "UISelectExiting";
    }
}
