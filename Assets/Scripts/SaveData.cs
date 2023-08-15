using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    public Horse tester = new Horse();
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
        tester = JsonUtility.FromJson<Horse>(readData);
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
public class Horse{
    string horseName;
    int age;
    string gender;
    string life;
    string medication;
    string features;

    public Horse(string newHorseName, int newAge,
     string newGender, string newLife, string newMeds, string newFeatures){
        this.horseName = newHorseName;
        this.age = newAge;
        this.gender = newGender;
        this.life = newLife;
        this.medication = newMeds;
        this.features = newFeatures;
     }

    public Horse()
    {
        this.horseName = "New Horse";
        this.age = 84910;
        this.gender = "baby";
        this.life = "great";
        this.medication = "anti hyper pills";
        this.features = "pretty boy";   
    }

}