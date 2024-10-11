using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //카메라를 붙이는 대상
    public GameObject player;
    //카메라가 플레이어를 따라가는 속도
    public float camerSpeed;


    //카메라가 플레이어를 쫒아가게 하여야한다. 카메라의 위치를 계속 바꿔줘야 하기 때문에 Update를 사용하는 것이 맞는 것 같다.

    public void Update()
    {
        //카메라와 플레이어의 위치값의 차이
        Vector3 ditanceDif = player.transform.position - this.transform.position;

        //카메라의 이동반경
        // z값이 0인 이유는 보여야하기 때문이다.대상과 z값이 같으면 대상이 보이지 않는다.
        //Time.deltaTime 을 곱하면 컴퓨터의 프레임 만큼 제동을 걸어준다. 
        Vector3 cameraMove = new Vector3(ditanceDif.x * camerSpeed * Time.deltaTime, ditanceDif.y * camerSpeed * Time.deltaTime, 0f);
        


        this.transform.Translate(cameraMove);
        //transform.traslate 는 vector3 값만큼 위치값을 변경시켜준다. update문에 씀으로서 매 프레임단위로 플레이어를 쫒아감

    }






}
