using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    //애니메이터와 inputSystem을 사용하고 있으니 참조할 컨트롤러 호출

    protected Animator animator;
    protected TownCharacterController controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TownCharacterController>();
    }
}
