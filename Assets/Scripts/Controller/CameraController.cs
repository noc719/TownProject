using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //ī�޶� ���̴� ���
    public GameObject player;
    //ī�޶� �÷��̾ ���󰡴� �ӵ�
    public float camerSpeed;


    //ī�޶� �÷��̾ �i�ư��� �Ͽ����Ѵ�. ī�޶��� ��ġ�� ��� �ٲ���� �ϱ� ������ Update�� ����ϴ� ���� �´� �� ����.

    public void Update()
    {
        //ī�޶�� �÷��̾��� ��ġ���� ����
        Vector3 ditanceDif = player.transform.position - this.transform.position;

        //ī�޶��� �̵��ݰ�
        // z���� 0�� ������ �������ϱ� �����̴�.���� z���� ������ ����� ������ �ʴ´�.
        //Time.deltaTime �� ���ϸ� ��ǻ���� ������ ��ŭ ������ �ɾ��ش�. 
        Vector3 cameraMove = new Vector3(ditanceDif.x * camerSpeed * Time.deltaTime, ditanceDif.y * camerSpeed * Time.deltaTime, 0f);
        


        this.transform.Translate(cameraMove);
        //transform.traslate �� vector3 ����ŭ ��ġ���� ��������ش�. update���� �����μ� �� �����Ӵ����� �÷��̾ �i�ư�

    }






}
