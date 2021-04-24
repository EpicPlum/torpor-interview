using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class addNote : MonoBehaviour
{
    public InputField input;
    public TextAsset output;
    public StreamWriter writer;


    public class inputData
    {
        public string inputText;
    }

    public void addInput()
    {
        if(GameObject.Find("Act1").activeInHierarchy)
        {
            writer = new StreamWriter("act1.json");
        }

        if (GameObject.Find("Act2").activeInHierarchy)
        {
            writer = new StreamWriter("act2.json");
        }

        if (GameObject.Find("Act3").activeInHierarchy)
        {
            writer = new StreamWriter("act3.json");
        }

        if (GameObject.Find("Act4").activeInHierarchy)
        {
            writer = new StreamWriter("act4.json");
        }

        inputData data = new inputData();
        data.inputText = input.text;

        string json = JsonUtility.ToJson(data);

        writer.Write(json);
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
