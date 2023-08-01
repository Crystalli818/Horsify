using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public TestClass tester = new TestClass();
    public void SaveToJson()
    {
        string dataToStore = JsonUtility.ToJson(tester);
        string filePath = Application.persistentDataPath +"/TestData.json";
    Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, dataToStore);
    }
    public void LoadFromJson()
    {
        string filePath = Application.persistentDataPath + "/TestData.json";
        string readData = System.IO.File.ReadAllText(filePath);
        tester = JsonUtility.FromJson<TestClass>(readData);
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        { 
            SaveToJson();
        }
if(Input.GetKeyDown(KeyCode.L))
        { 
            LoadFromJson();
        }
        
    }
}
[System.Serializable]
public class TestClass
{
    public int points;
    public string playerName;
}