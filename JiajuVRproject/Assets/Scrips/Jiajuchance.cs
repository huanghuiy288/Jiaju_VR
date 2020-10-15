using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jiajuchance : MonoBehaviour
{
    public GameObject btnObj;
    public GameObject objSet;
    public GameObject objBuy;
    bool isshow = false;
    Button btn;
    public Sprite expan;
    public Sprite back;
    // Start is called before the first frame update
    void Start()
    {
        objSet.SetActive(isshow);
        objBuy.SetActive(isshow);
        btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            isshow = !isshow;
            objSet.SetActive(isshow);
            objBuy.SetActive(isshow);
            if (isshow)
            {
                btn.GetComponent<Image>().sprite = expan;
            }
            else
            {
                btn.GetComponent<Image>().sprite = back;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

}
