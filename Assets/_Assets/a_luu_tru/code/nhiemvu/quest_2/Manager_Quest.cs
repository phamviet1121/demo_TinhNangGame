using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Manager_Quest : MonoBehaviour
{
    
    
    [SerializeField]
    public data_bace_Quest databaseScripts_1;
    public daliquestIntemHandler DaliquestIntemHandler;
    public Transform rootUI;
    public questItem QuestItem;

    private void Start()
    {
        foreach(var questdata in databaseScripts_1.DatabaseScripts)
        {
            CreatQuest(questdata);
            QuestItem.Setdata(questdata);
        }
    }
    private void CreatQuest(data_Quest Data_Questt)
    {
        var quest = Instantiate(DaliquestIntemHandler, rootUI);
        quest.SetData(Data_Questt);
    }
}
