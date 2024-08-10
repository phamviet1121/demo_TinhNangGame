using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luuDuLieuPhucTap : MonoBehaviour
{
    public aGameClass Aclass;
    public aGameStruct Astruct;
    //List<ten_cua_class> Alist = new List<ten_cua_class>();
    public List<string> Alist = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // class
    [ContextMenu("saveAclass")]
    private void saveAclass()
    {
        var GameInforValue=JsonUtility.ToJson(Aclass);
        PlayerPrefs.SetString(nameof(Aclass), GameInforValue);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAclass")]
    private void loadAclass() 
    {
        var LoadInforValue = PlayerPrefs.GetString(nameof(Aclass));
        Aclass=JsonUtility.FromJson<aGameClass>(LoadInforValue);
    }

    // struct

    [ContextMenu("saveAstruct")]
    private void saveAstruct()
    {
        var StructInforValue=JsonUtility.ToJson(Astruct);
        PlayerPrefs.SetString(nameof (Astruct), StructInforValue);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAstruct")]

    private void loadAstruct() 
    {
        //neu cai nay PlayerPrefs.GetString(nameof(Astruct) ma null thi tra ve gia tri defaulvalue
        var defaulvalue =JsonUtility.ToJson(new aGameStruct());
        var loadStructValue=PlayerPrefs.GetString(nameof(Astruct), defaulvalue);
        Astruct = JsonUtility.FromJson<aGameStruct>(loadStructValue);

    }


    // list bat buoc phai co class list kem theo

    //lisit
    [ContextMenu("saveAlist")]
    private void saveAlist()
    {
        //gan gia tri cua alist vao mot list moi trong class StringListWrapper sau do chuyen thanh choi string gan vao gia tri listInforValue
        string listInforValue = JsonUtility.ToJson(new StringListWrapper { list = Alist });
        // gan gia tri cua list vao 1 chuoi string 
        //var listInforValue= JsonUtility.ToJson(Alist);
        PlayerPrefs.SetString(nameof(Alist), listInforValue);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAlist")]
    private void loadAlist()
    {
       
        string defaufValue=PlayerPrefs.GetString(nameof(Alist),"{}");
        // lay choi string defaufValue gan no vao gia tri list trong class StringListWrapper
        StringListWrapper data = JsonUtility.FromJson<StringListWrapper>(defaufValue);
        //gan gia tri cua list vao Alist
        Alist=data.list;
    }

    //class cua list
    [System.Serializable]
    private class StringListWrapper
    {
        public List<string> list;
    }

}
[Serializable]
public class aGameClass
{
    public string name;
    public Vector2 aVecter;
    public int aInt;
    public float aFloat;
}
[Serializable]
public struct aGameStruct
{
    public string name;
    public Vector2 aVecter;
    public int aInt;
    public float aFloat;
}
//// khai bao 1 class chua cac thuoc tinh cua list
//[System.Serializable]
//public class ten_cua_class
//{
//    //cac thuoc tinh 
//    public string Name;
//    public int Age;
//}