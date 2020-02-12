using System.Collections;
using System.Collections.Generic;
using TMPro.SpriteAssetUtilities;
using UnityEngine;
[RequireComponent(typeof(Sprite))]
public class SpriteController : MonoBehaviour
{
    public Color offColor = Color.cyan;
    public Color SpriteColor = Color.magenta;
    private SpriteRenderer spriteObj;
    void Start()
    {
        spriteObj = GetComponent<SpriteRenderer>();
        spriteObj.color = SpriteColor;
    }

    private void OnEnable()
    {
        spriteObj.color = SpriteColor;
    }

    private void OnDisable()
    {
        spriteObj.color = offColor;
    }
}
