using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject ButtonUI1;
    public GameObject ButtonUI2;
    public GameObject StausUI;
    public GameObject InventoryUI;
    public GameObject EQUI;

    public void StatusClick()
    {
        Debug.Log("����â ����");
        StausUI.SetActive(true);
        ButtonUI1.SetActive(false);
        ButtonUI2.SetActive(false);
    }
    public void StatusBack()
    {
        Debug.Log("����â �ݱ�");
        StausUI.SetActive(false);
        ButtonUI1.SetActive(true);
        ButtonUI2.SetActive(true);
    }
    public void InventoryClick()
    {
        Debug.Log("������â ����");
        InventoryUI.SetActive(true);
        ButtonUI1.SetActive(false);
        ButtonUI2.SetActive(false);
    }
    public void InventoryBack()
    {
        Debug.Log("������â �ݱ�");
        InventoryUI.SetActive(false);
        ButtonUI1.SetActive(true);
        ButtonUI2.SetActive(true);
    }
    public void EQYes()
    {
        Debug.Log("����â ����");
        EQUI.SetActive(true);
    }
    public void EQNo()
    {
        Debug.Log("����â �ݱ�");
        EQUI.SetActive(false);
    }

}
