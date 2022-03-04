using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoTonedBackground : MonoBehaviour
{
    public Image Image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeBackgroundColor(Color newColor)
    {
        if (newColor == null)
        {
            return;
        }
        Image.color = newColor;
    }
}
