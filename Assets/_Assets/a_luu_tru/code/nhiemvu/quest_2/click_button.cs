using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click_button : MonoBehaviour
{
    public Button button;
    public Text test_btn;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnStatusButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnStatusButtonClick()
    {
        test_btn.text = "da nhan";
    }

} 