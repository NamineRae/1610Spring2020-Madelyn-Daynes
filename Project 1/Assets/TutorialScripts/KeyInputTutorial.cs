﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

/*public class KeyInputTutorial : MonoBehaviour
{
    public GUITexture graphic;
    public Texture2D standard;
    public Texture2D downgfx;
    public Texture2D upgfx;
    public Texture2D hledgfx;
    
    void Start()
    {
        graphic.texture = standard;
    }

    
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);
        if (down)
        {
            graphic.texture = downgfx;
        }
        else if (held)
        {
            graphic.texture = hledgfx;
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