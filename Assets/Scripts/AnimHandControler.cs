using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class AnimHandControler : MonoBehaviour
{
    [SerializeField]
    private InputActionReference _gripInputActionReference;

    [SerializeField]
    private InputActionReference _triggerInputActionReference;

    [SerializeField]
    private Animator _handAnimator;
    
    private float _gripValue;
    private float _triggerValue;

    void Start()
    {

    }

    void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }

    private void AnimateGrip()
    {
        _gripValue = _gripInputActionReference.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip", _gripValue);
    }

    private void AnimateTrigger()
    {
        _triggerValue = _triggerInputActionReference.action.ReadValue<float>();
        _handAnimator.SetFloat("Trigger", _triggerValue);
    }
}