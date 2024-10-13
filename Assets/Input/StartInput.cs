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
            text.text = "설정할 수 없는 이름입니다.";
            return;
        }
        else
        {
            text.text = $"이름은 : {inputField.text}";
            GameObject pNameData = GameObject.FindGameObjectWithTag("pNameData");
            pNameData.GetComponent<playerName>().pName = inputField.text;
            //playerName.GetComponentInChildren<Text>().text = $"{inputField.text}";
            SceneManager.LoadScene("MainScene");
            

        }

    }
}
