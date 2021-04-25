using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
using System;

public class Codex_Entries : MonoBehaviour
{
    private topicData tData;
    private codexData cData;
    private string codexPath = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\codex.json";
    private string characterPath = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\characters.json";
    private string locationsPath = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\locations.json";
    private string organisationsPath = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\organisations.json";
    private string historyPath = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\history.json";
    private GameObject[] entries;
    private GameObject[] entryButtons;
    private GameObject[] titles;
    private GameObject[] images;
    private GameObject[] paragraphs;




    public void setAllInactive()
    {
        entries = GameObject.FindGameObjectsWithTag("Entry");
        entryButtons = GameObject.FindGameObjectsWithTag("EntryButton");

    //GameObject entryButton;
    //GameObject entry;
    gameObject.tag = "CurrEntryButton";
        gameObject.transform.GetChild(0).gameObject.tag = "CurrEntry";
        

        foreach(GameObject i in entries)
        {
            //entryButton = GameObject.FindWithTag("EntryButton");
            i.SetActive(false);
            /*
            Text text = entryButtons[i].GetComponent<Text>();
            text.font = (Font) AssetDatabase.LoadAssetAtPath("Assets/Fonts/Rubik-Medium.ttf", typeof(Font));
            text.fontSize = 150;
            */

        }

        foreach (GameObject i in entryButtons)
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

    [Serializable]
    public class topicData
    {
        public string[] topic1, topic2, topic3, topic4, topic5;
    }

    [Serializable]
    public class codexData
    {
        public string[] category1, category2, category3, category4;
    }

    public void assignData()
    {
        entryButtons = GameObject.FindGameObjectsWithTag("EntryButton");
        titles = GameObject.FindGameObjectsWithTag("Title");
        images = GameObject.FindGameObjectsWithTag("Image");
        paragraphs = GameObject.FindGameObjectsWithTag("Paragraph");

    string json = File.ReadAllText(characterPath);
            Debug.Log(json);

            // data = fileData Object
            // topic1 = Cabinet
            // topic2 = Family
            JsonUtility.FromJsonOverwrite(json, tData);

        int buttonCount = 0;
        int titleCount = 0;


                foreach(GameObject i in entryButtons)
                {
                    //set text on entry buttons
                    i.GetComponent<Text>().text = tData.topic1[buttonCount];
                    
                    //set paragraphs

                Debug.Log(titles[buttonCount]);
            buttonCount++;
                }

                foreach (GameObject i in titles)
                {
                    //set titles
                    i.GetComponent<Text>().text = tData.topic1[titleCount].ToUpper();

            //set paragraphs
            titleCount++;
                }
        






        Debug.Log(tData.topic2[0]);

    }
    


    // Start is called before the first frame update
    void Start()
    {
         tData = new topicData();

        assignData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
