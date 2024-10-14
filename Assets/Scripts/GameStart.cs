using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject pTypeData;
    public bool playerType;
    public GameObject playerSelect;
    void Start()
    {
        pTypeData = GameObject.FindGameObjectWithTag("pNameData");
        setPlayerType();
    }
    private void setPlayerType()
    {
        playerType = pTypeData.GetComponent<playerInfo>().pType;
        Debug.Log(playerType);
        if (playerType == true)
        {
            Debug.Log("pType1");
            GameObject.Find("PlayerGroup").transform.Find("Penguin").gameObject.SetActive(true);
            
        }
        else
        {
            GameObject.Find("PlayerGroup").transform.Find("Wizzard").gameObject.SetActive(true);

        }

    }
}
