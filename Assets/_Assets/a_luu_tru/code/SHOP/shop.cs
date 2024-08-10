using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.VisualElement;

public class shop : MonoBehaviour
{
    [System.Serializable]
    class Alist
    {
        public Sprite anh;
        public int Price;
        public bool Abuy;

    }
    [SerializeField] List<Alist> ShopItemLiist;






    GameObject a;
    GameObject b;
    [SerializeField] Transform s;
    Button buy_btn;
    void Start()     
    {
        loadAlits();
        a = s.GetChild(0).gameObject;
        int len = ShopItemLiist.Count;
        for (int i = 0; i < len; i++)
        {



            b = Instantiate(a, s);



            //    b.transform.GetChild(0): Lấy đối tượng con đầu tiên của b(đối tượng cha) trong cây hierarchy.
            //GetComponent<Image>(): Lấy component Image của đối tượng con này.
            //sprite = ShopItemLiist[i].Image;: Gán giá trị sprite của Image bằng giá trị Image từ danh sách ShopItemLiist ở vị trí i.
            //Mục đích: Gán hình ảnh của sản phẩm từ ShopItemLiist[i] vào hình ảnh trên UI.
            b.transform.GetChild(0).GetComponent<Image>().sprite = ShopItemLiist[i].anh;


            //            b.transform.GetChild(1).GetChild(0): Lấy đối tượng con đầu tiên của đối tượng con thứ hai của b.
            //            GetComponent<Text>(): Lấy component Text từ đối tượng đó.
            //            text = ShopItemLiist[i].Price.ToString();: Gán giá trị text là giá của sản phẩm, được chuyển thành chuỗi từ giá trị Price trong ShopItemLiist[i].
            //            Mục đích: Hiển thị giá của sản phẩm trên UI.
            b.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = ShopItemLiist[i].Price.ToString();

            //b.transform.GetChild(2): Lấy đối tượng con thứ ba của b.
            //GetComponent<Button>(): Lấy component Button từ đối tượng này.
            //interactable = !ShopItemLiist[i].ispurchased;: Gán thuộc tính interactable của nút bằng giá trị phủ định của ispurchased.
            //    Nếu sản phẩm đã được mua(ispurchased == true),
            //    nút sẽ không thể nhấn; nếu chưa mua(ispurchased == false), nút sẽ có thể nhấn.
            buy_btn = b.transform.GetChild(2).GetComponent<Button>();
            buy_btn.interactable = !ShopItemLiist[i].Abuy;
            buy_btn.AddEventListener(i, onSgopItemsBtnClicked);
        }
        Destroy(a);
    }
    void onSgopItemsBtnClicked(int itenIndex)
    {
        ShopItemLiist[itenIndex].Abuy = true;
        buy_btn = s.GetChild(itenIndex).GetChild(2).GetComponent<Button>();
        buy_btn.interactable = false;
        buy_btn.transform.GetChild(0).GetComponent<Text>().text = "da mua";
    }

    [ContextMenu("saveAlits")]
    private void saveAlits()
    {
        string inForLIst = JsonUtility.ToJson(new saveDataList { LIstString = ShopItemLiist });
        PlayerPrefs.SetString(nameof(ShopItemLiist), inForLIst);
        PlayerPrefs.Save();
    }

    [ContextMenu("loadAlits")]
    private void loadAlits()
    {
        string defoufList = PlayerPrefs.GetString(nameof(ShopItemLiist), "{}");
        saveDataList a = JsonUtility.FromJson<saveDataList>(defoufList);
        ShopItemLiist = a.LIstString;
    }
    [Serializable]
    class saveDataList
    {
        public List<Alist> LIstString;

    }

}

