using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;

public class Codex_Entries : MonoBehaviour
{
    private fileData data;

    public void setAllInactive()
    {


        //GameObject entryButton;
        //GameObject entry;
        gameObject.tag = "CurrEntryButton";
        gameObject.transform.GetChild(0).gameObject.tag = "CurrEntry";
        var entries = GameObject.FindGameObjectsWithTag("Entry");
        var entryButtons = GameObject.FindGameObjectsWithTag("EntryButton");

        foreach(var i in entries)
        {
            //entryButton = GameObject.FindWithTag("EntryButton");
            i.SetActive(false);
            /*
            Text text = entryButtons[i].GetComponent<Text>();
            text.font = (Font) AssetDatabase.LoadAssetAtPath("Assets/Fonts/Rubik-Medium.ttf", typeof(Font));
            text.fontSize = 150;
            */

        }

        foreach (var i in entryButtons)
        {
            //entryButton = GameObject.FindWithTag("EntryButton");
            //i.SetActive(false);
            Text text = i.GetComponent<Text>();
            text.font = (Font)AssetDatabase.LoadAssetAtPath("Assets/Fonts/Rubik-Medium.ttf", typeof(Font));
            text.fontSize = 150;
        }

        gameObject.transform.GetChild(0).gameObject.SetActive(true);

        gameObject.tag = "EntryButton";
        gameObject.transform.GetChild(0).gameObject.tag = "Entry";
    }

    public class fileData
    {
        public string topic1, topic2, topic3, topic4, topic5;
    }

    public void assignData()
    {
        
        string json = File.ReadAllText(@"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\characters.json");
        Debug.Log(json);
        // data = fileData Object
        // topic1 = 
        data = JsonUtility.FromJson<fileData>(json);
        Debug.Log(data.ToString());
        Debug.Log(data.topic2.ToString());
        Debug.Log(data.topic3.ToString());
        Debug.Log(data.topic4.ToString());
        Debug.Log(data.topic5.ToString());
    }
    


    // Start is called before the first frame update
    void Start()
    {
         data = new fileData();

        assignData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
