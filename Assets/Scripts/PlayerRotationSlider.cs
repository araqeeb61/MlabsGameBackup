using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRotationSlider : MonoBehaviour
{
    public Slider rotationSlider;
    [Range(-36,36)]
    public float rotationSpeed = 0f;
    

    // Update is called once per frame
    void Update()
    {
        float rotationVal=rotationSlider.value*rotationSpeed;
        this.transform.rotation=Quaternion.Euler(-90,90,rotationVal);
        Debug.Log("this is rotational value "+rotationVal);
    }
    
    
   
}
