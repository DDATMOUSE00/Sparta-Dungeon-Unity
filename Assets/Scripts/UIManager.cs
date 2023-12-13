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
        Debug.Log("½ºÅÈÃ¢ ¿­±â");
        StausUI.SetActive(true);
        ButtonUI1.SetActive(false);
        ButtonUI2.SetActive(false);
    }
    public void StatusBack()
    {
        Debug.Log("½ºÅÈÃ¢ ´Ý±â");
        StausUI.SetActive(false);
        ButtonUI1.SetActive(true);
        ButtonUI2.SetActive(true);
    }
    public void InventoryClick()
    {
        Debug.Log("¾ÆÀÌÅÛÃ¢ ¿­±â");
        InventoryUI.SetActive(true);
        ButtonUI1.SetActive(false);
        ButtonUI2.SetActive(false);
    }
    public void InventoryBack()
    {
        Debug.Log("¾ÆÀÌÅÛÃ¢ ´Ý±â");
        InventoryUI.SetActive(false);
        ButtonUI1.SetActive(true);
        ButtonUI2.SetActive(true);
    }
    public void EQYes()
    {
        Debug.Log("ÀåÂøÃ¢ ¿­±â");
        EQUI.SetActive(true);
    }
    public void EQNo()
    {
        Debug.Log("ÀåÂøÃ¢ ´Ý±â");
        EQUI.SetActive(false);
    }

}
