﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class ButtonInputTutorial : MonoBehaviour
{
    public GUITexture graphic;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D heldgfx;
    void Start()
    {
        graphic.texture = standard;
    }

    void Update()
    {
        bool down = Input.GetButtonDown("Jump");
        bool held = Input.GetButton("Jump");
        bool up = Input.GetButtonUp("Jump");

        if (down)
        {
            graphic.texture = downgfx;
        }
        else if (held)
        {
            graphic.texture = heldgfx;
        }
        else if (up)
        {
            graphic.texture = upgfx;
        }
        else
        {
            graphic.texture = standard;
        }

        GetComponent<GUIText>().text = " " + down + "\n" + held + "\n" + up;
    }
}
//unity learn tutorial*/