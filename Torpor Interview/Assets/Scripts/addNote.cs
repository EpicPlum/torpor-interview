using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class addNote : MonoBehaviour
{
    public InputField input;


    public class inputData
    {
        public string inputText;
    }

    public void addInput()
    {
        inputData data = new inputData();
        data.inputText = input.text;

        string json = JsonUtility.ToJson(data);
        Debug.Log(json);
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
