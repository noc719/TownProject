using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartInput : MonoBehaviour
{
    [SerializeField]
    TMP_InputField inputField;

    [SerializeField]
    TextMeshProUGUI nametxt;

    
  

    
    public void SaveName()
    {
        if (inputField.text.Length < 2 )
        {
            nametxt.text = "������ �� ���� �̸��Դϴ�.";
            return;
        }
        else
        {
            nametxt.text = $"�̸��� : {inputField.text}";
            GameObject pNameData = GameObject.FindGameObjectWithTag("pNameData");
            pNameData.GetComponent<playerInfo>().pName = inputField.text;
            SceneManager.LoadScene("MainScene");
            

        }

    }
    
}
