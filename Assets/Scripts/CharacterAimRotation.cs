using System;
using UnityEngine;
using UnityEngine.UIElements;

public class CharacterAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TownCharacterController controller;

    private void Awake()
    {
        controller = GetComponent<TownCharacterController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }
    public void OnAim(Vector2 Direction)
    {
        RotateVision(Direction);
    }

    private void RotateVision(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}