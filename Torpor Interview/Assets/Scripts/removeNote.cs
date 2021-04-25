using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeNote : MonoBehaviour
{
    private string path;

    public void removeInput()
    {
        if (GameObject.Find("Act1") != null)
        {
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act1.json";
        }
        else if (GameObject.Find("Act2") != null)
        {
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act2.json";
        }
        else if (GameObject.Find("Act3") != null)
        {
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act3.json";
        }
        else if (GameObject.Find("Act4") != null)
        {
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act4.json";
        }



        gameObject.SetActive(false);
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
