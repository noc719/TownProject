using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class SelectSystem : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI selectTxt;

    bool characterDefault;

    GameObject selectUI;
    [SerializeField]
    GameObject myChar;

    public void Start()
    {
        selectUI = GameObject.Find("StartMenu").transform.Find("SelectUI").gameObject;
        myChar = GameObject.FindGameObjectWithTag("CharacterUI");
    }

    public void characterSelect1()
    {
        characterDefault = true;
        selectTxt.text = "펭귄이 선택되었습니다.";
        GameObject pNameType = GameObject.FindGameObjectWithTag("pNameData");
        pNameType.GetComponent<playerInfo>().pType = characterDefault;

        myChar.transform.Find("Penguin").gameObject.SetActive(true);
        myChar.transform.Find("Wizzard").gameObject.SetActive(false);
    }

    public void characterSelect2()
    {
        characterDefault = false;
        selectTxt.text = "마법사가 선택되었습니다.";
        GameObject pNameType = GameObject.FindGameObjectWithTag("pNameData");
        pNameType.GetComponent<playerInfo>().pType = characterDefault;

        myChar.transform.Find("Penguin").gameObject.SetActive(false);
        myChar.transform.Find("Wizzard").gameObject.SetActive(true);
    }

    public void SelectUIOpen()
    {
        selectUI.SetActive(true);
    }
    public void SelectUIClose()
    {
        selectUI.SetActive(false);
    }


}
