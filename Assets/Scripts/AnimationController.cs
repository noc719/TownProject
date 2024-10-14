using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //�ִϸ����Ϳ� inputSystem�� ����ϰ� ������ ������ ��Ʈ�ѷ� ȣ��

    protected Animator animator;
    protected TownCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TownCharacterController>();
    }
}
