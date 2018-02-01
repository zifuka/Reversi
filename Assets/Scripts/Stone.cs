﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// オセロの石
public class Stone : MonoBehaviour
{

    private bool _isBlack;
    public bool isBlack
    {
        set
        {
            _isBlack = value;
            image.sprite = stoneImage[isBlack ? 0 : 1];
        }
        get
        {
            return _isBlack;
        }
    }

    [SerializeField]
    private Sprite[] stoneImage = new Sprite[2];

    private Animator turnAnimator;
    private Image image;

    void Awake()
    {
        image = GetComponent<Image>();
        isBlack = true;

        turnAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void Turn()
    {
        turnAnimator.SetTrigger("Turn");
    }

    public void ChangeColor()
    {
        isBlack = !isBlack;
    }
}