using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "DataList", menuName = "ScriptableObjects/Quests", order = 1)]
public class data_bace_Quest : ScriptableObject
{
    [SerializeField]
    private List<data_Quest> databaseScripts = new List<data_Quest>();

    public List<data_Quest> DatabaseScripts => databaseScripts;

}

