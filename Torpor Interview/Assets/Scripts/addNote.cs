using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class addNote : MonoBehaviour
{
    public InputField input;
    public TextAsset output;
    public GameObject bullet;
    private Transform bulletParent;
    private string path;
    private Vector3 lastBulletPos;




    public class inputData
    {
        public string inputText;
    }

    public void addInput()
    {
        if(GameObject.Find("Act1").activeInHierarchy && GameObject.Find("Act1") != null)
        {
            bulletParent = GameObject.Find("Act1").transform;
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act1.json";
            Debug.Log("Act1");
        }
        else if (GameObject.Find("Act2").activeInHierarchy && GameObject.Find("Act2") != null)
        {
            bulletParent = GameObject.Find("Act2").transform;
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act2.json";
            Debug.Log("Act2");
        }
        else if (GameObject.Find("Act3").activeInHierarchy && GameObject.Find("Act3") != null)
        {
            bulletParent = GameObject.Find("Act3").transform;
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act3.json";
            Debug.Log("Act3");
        }
        else if (GameObject.Find("Act4").activeInHierarchy && GameObject.Find("Act4") != null)
        {
            bulletParent = GameObject.Find("Act4").transform;
            path = @"C:\Users\Admin\Documents\GitHub\torpor-interview\Torpor Interview\Assets\JSON\act4.json";
            Debug.Log("Act4");
        }

        inputData data = new inputData();
        data.inputText = input.text;

        string json = JsonUtility.ToJson(data);
       
        File.WriteAllText(path, json);
        Debug.Log("Written");

        //retrieve json data
        json = File.ReadAllText(path);
        data = JsonUtility.FromJson<inputData>(json);
        Debug.Log("Read");

        lastBulletPos = new Vector3(-316, 235, 0);

        //create bullet object from prefab
        //use last y-value to determine position
        //instantiate as child of Act Object
        GameObject bulletObj = Instantiate(bullet, new Vector3(0,0,0), Quaternion.identity, bulletParent);
        //bulletObj.GetComponent<Text>().text = data.inputText;
        //bulletObj.transform.position = lastBulletPos;

        lastBulletPos.y -= 30;
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
