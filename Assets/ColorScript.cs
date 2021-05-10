using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    Vector3 scale = new Vector3(5f, 5f, 5f);
    Vector3 scale1 = new Vector3(1f, 1f, 1f);


    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        transform.localScale = scale;
    }

    private void OnMouseExit()
    {
        transform.localScale = scale1;
    }
}
