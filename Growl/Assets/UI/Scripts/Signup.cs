using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;
using System.Net.Sockets;
using TMPro;
using System.Text.RegularExpressions;

public class Signup : Popup
{
    private bool ID_Duplicate = false;
    private string ID_Duplicated = string.Empty;
    private bool Nick_Duplicate = false;
    private string Nick_Duplicated = string.Empty;
    private bool PW_Complicated = false;

    [SerializeField]
    private Button Accept;
    [SerializeField]
    private Button Reset;
    [SerializeField]
    private Button Quit;
    [SerializeField]
    private Button IDDupCheck;
    [SerializeField]
    private Button NickDupCheck;
    [SerializeField]
    private TMP_InputField IDInput;
    [SerializeField]
    private TMP_InputField PWInput;
    [SerializeField]
    private TMP_InputField PWReInput;
    [SerializeField]
    private TMP_InputField NickInput;
    [SerializeField]
    private Image IDDupCheckMark;
    [SerializeField]
    private Image NickDupCheckMark;

    public void ID_Duplicate_Check()
    {
        if (true)   //TODO
        {
            ID_Duplicate = true;
            ID_Duplicated = IDInput.text;
            IDDupCheckMark.enabled = true;
        }
        else
        {
            ID_Duplicate = false;
            ID_Duplicated = string.Empty;
            IDDupCheckMark.enabled = false;
        }
    }
    public void Nick_Duplicate_Check()
    {
        if (true)   //TODO
        {
            Nick_Duplicate = true;
            Nick_Duplicated = NickInput.text;
            NickDupCheckMark.enabled = true;
        }
        else
        {
            Nick_Duplicate = false;
            Nick_Duplicated = string.Empty;
            NickDupCheckMark.enabled = false;
        }
    }
    public void _Submit()
    {
        if(ID_Duplicate && Nick_Duplicate && PW_Complicated)
            Debug.Log("¤·¤·¤·");
    }
    public void _Reset()
    {
        
    }
    public void Input_IME_Auto()
    {
        Input.imeCompositionMode = IMECompositionMode.Auto;
    }
    public void Input_IME_Off()
    {
        Input.imeCompositionMode = IMECompositionMode.Off;
    }
    private void Start()
    {
        IDInput.onValueChanged.AddListener((word) => IDInput.text = Regex.Replace(word, @"[^a-zA-Z0-9°¡-ÆR]", ""));
        PWInput.onValueChanged.AddListener((word) => PWInput.text = Regex.Replace(word, " ", ""));
        PWReInput.onValueChanged.AddListener((word) => PWReInput.text = Regex.Replace(word, " ", ""));
        NickInput.onValueChanged.AddListener((word) => NickInput.text = Regex.Replace(word, @"[^a-zA-Z0-9°¡-ÆR]", ""));

        IDDupCheckMark.enabled = false;
        NickDupCheckMark.enabled = false;
    }

}
