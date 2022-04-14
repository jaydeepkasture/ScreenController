using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSlidingAnimation : MonoBehaviour
{
    [SerializeField] Transform finshingPoint;
    [SerializeField] Transform startingPoint;
    [SerializeField] LeanTweenType leanType;
float time=0.6f;
    CanvasGroup canvasGroup;
    private void Awake()
    {
        canvasGroup = this.GetComponent<CanvasGroup>();
    }
    public bool allowAnimation=true;//set from the inspector
    public void Slide()
    {
        if (!allowAnimation) return;
        canvasGroup = this.GetComponent<CanvasGroup>();
        GameObject filterRectangle = gameObject;
        canvasGroup.alpha = 0;
        filterRectangle.transform.position = startingPoint.position;
        LeanTween.move(gameObject, finshingPoint.position, time).setEase(leanType);
        LeanTween.alphaCanvas(canvasGroup, 1, time); 
    }
}
