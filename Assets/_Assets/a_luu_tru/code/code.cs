using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class code : MonoBehaviour
{
    // Start is called before the first frame update
    // cac kieu du lieu ma playerpreft ho tro
    public int aInt;
    public float aFloat;
    public string aString;
    //chuyen cac kieu du lieu nguyen thu ve dang kieu du lieu ma playerpreft ho tro 
    public char aChar;
    public bool aBool;
    public long aLong;
    public double aDouble;
    // cac kieu du lieu nguyen thu cua unity
    public Vector2 aVector2;
    public Vector3 aVector3;
    public Vector4 aVector4;
    public Quaternion aQuaternion;
    public Color aColor;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //kieu int 
    [ContextMenu("severAint")]
    private void severAint()
    {
        PlayerPrefs.SetInt("aInt", aInt);
        PlayerPrefs.Save();

    }
    [ContextMenu("loadAint")]
    private void loadAint()
    {
        aInt = PlayerPrefs.GetInt("aInt", 0);
    }

    //kieu float
    [ContextMenu("severAflaot")]
    private void severAfloat()
    {
        PlayerPrefs.SetFloat("aFloat", aFloat);
        PlayerPrefs.Save();

    }
    [ContextMenu("laodAfloat")]
    private void loadAfloat()
    {
        aFloat = PlayerPrefs.GetFloat("aFloat", 0);
    }

    //kieu string
    [ContextMenu("saveAstring")]
    private void saveAstring()
    {
        PlayerPrefs.SetString("aString", aString);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAstring")]
    private void loadAstring()
    {
        aString = PlayerPrefs.GetString("aString", "");
    }
    //kieu char
    [ContextMenu("saveAchar")]
    private void saveAchar()
    {
        PlayerPrefs.SetString("aChar", aChar.ToString());
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAchar")]
    private void loadAchar()
    {
        var value = PlayerPrefs.GetString("aChar", aChar.ToString());
        aChar = char.Parse(value);
    }
    //kieu bool

    [ContextMenu("saveAbool")]
    private void saveAbool()
    {
        PlayerPrefs.SetString("aBool", aBool.ToString());
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAbool")]
    private void loadAbool()
    {
        var value = PlayerPrefs.GetString("aBool", aBool.ToString());
        aBool = bool.Parse(value);
    }
    //kieu long
    [ContextMenu("saveAlong")]
    private void saveAlong()
    {
        PlayerPrefs.SetString("aLong", aLong.ToString());
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAlong")]
    private void loadAlong()
    {
        var value = PlayerPrefs.GetString("aLong", aLong.ToString());
        aLong = long.Parse(value);
    }


    //kieu double
    [ContextMenu("saveAdouble")]
    private void saveAdouble()
    {
        PlayerPrefs.SetString("aBool", aDouble.ToString());
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAdouble")]
    private void loadAdouble()
    {
        var value = PlayerPrefs.GetString("aDouble", aDouble.ToString());
        aDouble = double.Parse(value);
    }

    //kieu vecter2

    [ContextMenu("saveAvecter2")]

    private void saveAvecter2()
    {
        PlayerPrefs.SetFloat("aVector2.x", aVector2.x);
        PlayerPrefs.SetFloat("aVector2.y", aVector2.y);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAvecter2")]
    private void loadAvecter2(string key)
    {
        var X = PlayerPrefs.GetFloat("aVector2.x", aVector2.x);
        var Y = PlayerPrefs.GetFloat("aVector2.y", aVector2.y);
        aVector2 = new Vector2(X, Y);
    }

    //kieu vecter3

    [ContextMenu("saveAvecter3")]

    private void saveAvecter3()
    {
        PlayerPrefs.SetFloat("aVector3.x", aVector3.x);
        PlayerPrefs.SetFloat("aVector3.y", aVector3.y);
        PlayerPrefs.SetFloat("aVector3.z", aVector3.z);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAvecter3")]
    private void loadAvecter3()
    {
        var X = PlayerPrefs.GetFloat("aVector3.x", aVector3.x);
        var Y = PlayerPrefs.GetFloat("aVector3.y", aVector3.y);
        var Z = PlayerPrefs.GetFloat("aVector3.z", aVector3.z);
        aVector3 = new Vector3(X, Y, Z);
    }


    //kieu vecter4

    [ContextMenu("saveAvecter4")]

    private void saveAvecter4()
    {
        PlayerPrefs.SetFloat("aVector4.x", aVector4.x);
        PlayerPrefs.SetFloat("aVector4.y", aVector4.y);
        PlayerPrefs.SetFloat("aVector4.z", aVector4.z);
        PlayerPrefs.SetFloat("aVector4.w", aVector4.w);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAvecter4")]
    private void loadAvecter4()
    {
        var X = PlayerPrefs.GetFloat("aVector4.x", aVector4.x);
        var Y = PlayerPrefs.GetFloat("aVector4.y", aVector4.y);
        var Z = PlayerPrefs.GetFloat("aVector4.z", aVector4.z);
        var W = PlayerPrefs.GetFloat("aVector4.w", aVector4.w);
        aVector4 = new Vector4(X, Y, Z, W);
    }

    //kieu Quaternion

    [ContextMenu("saveAquaternion")]

    private void saveAquaternion()
    {
        PlayerPrefs.SetFloat("aQuaternion.x", aQuaternion.x);
        PlayerPrefs.SetFloat("aQuaternion.y", aQuaternion.y);
        PlayerPrefs.SetFloat("aQuaternion.z", aQuaternion.z);
        PlayerPrefs.SetFloat("aQuaternion.w", aQuaternion.w);
        PlayerPrefs.Save();
    }
    [ContextMenu("loadAquaternion")]
    private void loadAquaternion()
    {
        var X = PlayerPrefs.GetFloat("aQuaternion.x", aQuaternion.x);
        var Y = PlayerPrefs.GetFloat("aQuaternion.y", aQuaternion.y);
        var Z = PlayerPrefs.GetFloat("aQuaternion.z", aQuaternion.z);
        var W = PlayerPrefs.GetFloat("aQuaternion.w", aQuaternion.w);
        aQuaternion = new quaternion(X, Y, Z, W);
    }
    // kieu mau(color)
    [ContextMenu("saveAcode")]
    private void saveAcolor()
    {
        PlayerPrefs.SetFloat("aColor.r", aColor.r);
        PlayerPrefs.SetFloat("aColor.g", aColor.g);
        PlayerPrefs.SetFloat("aColor.b", aColor.b);
        PlayerPrefs.SetFloat("aColor.a", aColor.a);

        PlayerPrefs.Save();
    }
    [ContextMenu("loadAcolor")]
    private void loadAcolor()
    {
        float R = PlayerPrefs.GetFloat("aColor.r", aColor.r);
        float G = PlayerPrefs.GetFloat("aColor.g", aColor.g);
        float B = PlayerPrefs.GetFloat("aColor.b", aColor.b);
        float A = PlayerPrefs.GetFloat("aColor.a", aColor.a);
        aColor = new Color(R, G, B, A);
    }
}





// kieu du lieu cap cao 
//kieu class
//kieu struct
//kieu arry
//kieu list


