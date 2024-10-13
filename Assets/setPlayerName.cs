using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class setPlayerName : MonoBehaviour
{
    public GameObject pNameData;
    public TMP_Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        pNameData = GameObject.FindGameObjectWithTag("pNameData");
        tmp = this.GetComponent<TMP_Text>();
        tmp.text = pNameData.GetComponent<playerName>().pName;
    }
}
