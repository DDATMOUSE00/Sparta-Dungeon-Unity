using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;

    public void Item1Click()
    {
        Debug.Log("아이템1번 장착 열기");
        Item1.SetActive(true);
        //ButtonUI1.SetActive(false);
        //ButtonUI2.SetActive(false);
    }
}
