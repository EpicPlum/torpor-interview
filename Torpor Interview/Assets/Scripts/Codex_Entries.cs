using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Codex_Entries : MonoBehaviour
{

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
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
