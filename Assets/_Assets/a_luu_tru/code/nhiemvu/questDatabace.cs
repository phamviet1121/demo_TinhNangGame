using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataList", menuName = "ScriptableObjects/Quests", order = 1)]
public class questDatabace : ScriptableObject
{
    //List<QuestDataa> databaceList;
    [SerializeField]
    private List<QuestDataa> databaseList = new List<QuestDataa>();

    public List<QuestDataa> DatabaseList => databaseList;
}

