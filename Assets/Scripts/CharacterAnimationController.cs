using System;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterAnimationController : AnimationController 
{
    //여기선 아직 가만히 있을 때와 걷는 것만 구분할 생각이니 걷고있는지만 확인해주는 변수.
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private readonly float moveRange = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += MoveAnim;
    }

    private void MoveAnim(Vector2 vector)
    {
        //Bool 값은 true false 밖에 없기 때문에 안에 setbool안에 조건을 넣을 수 있다.
        //입력된 값을 vector.magnitude로 불러오고 특정 값과 비교하여 참 거짓을 판별하게 한다.
        animator.SetBool(isWalking, vector.magnitude > moveRange);
    }
}
