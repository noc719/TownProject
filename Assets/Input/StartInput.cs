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
    TextMeshProUGUI text;
  

    
    public void SaveName()
    {
        if (inputField.text.Length < 2 )
        {
            text.text = "������ �� ���� �̸��Դϴ�.";
            return;
        }
        else
        {
            text.text = $"�̸��� : {inputField.text}";
            GameObject pNameData = GameObject.FindGameObjectWithTag("pNameData");
            pNameData.GetComponent<playerName>().pName = inputField.text;
            //playerName.GetComponentInChildren<Text>().text = $"{inputField.text}";
            SceneManager.LoadScene("MainScene");
            

        }

    }
}
