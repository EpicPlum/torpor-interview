using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Sprite buttonClicked;
    public Sprite buttonNormal;
    public Button button;

    public void changeSprite()
    {
        if (button.image.sprite == buttonClicked)
        {
            button.image.sprite = buttonNormal;
        }
        else
            button.image.sprite = buttonClicked;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
