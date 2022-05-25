using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControl : MonoBehaviour
{
    //Start Page
    public GameObject startPage;
    //Campus Button Menu
    public GameObject campusMenu;
    //Campus
    public GameObject[] smCampus;
    //Side Menu
    public GameObject[] sideMenus;
    //hider
    public GameObject hider;
    public int cNo = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCampusMenu(){
        //show menu
        campusMenu.SetActive(true);
    }

    public void ChooseCampus(int campusNumber){
        //hide start page
        startPage.SetActive(false);
        //hide smBtns
        for(int i = 0; i < smCampus.Length; i++)
        {
            smCampus[i].SetActive(false);
        }
        //show smBtn
        smCampus[campusNumber].SetActive(true);
        //hide campusPanel
        campusMenu.SetActive(false);
        cNo = campusNumber;
    }

    public void ShowSideMenu(int campusNumber){
        //show side menu
        sideMenus[campusNumber].SetActive(true);
        //show hider
        hider.SetActive(true);
        //hide smBtn
        smCampus[campusNumber].SetActive(false);
    }

    public void HideSideMenu(){
        foreach (GameObject sideMenu in sideMenus)
        {
            sideMenu.SetActive(false);
        }
        //hide hider
        hider.SetActive(false);
        //show smBtn
        smCampus[cNo].SetActive(true);
    }

    public void BackToHome(){
        //show start page
        startPage.SetActive(true);
        foreach (GameObject sideMenu in sideMenus)
        {
            sideMenu.SetActive(false);
        }
        //hide hider
        hider.SetActive(false);
    }
}
