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

    public void Accept_Click()
    {
        if (IDInput.text == "AAA")
            Debug.Log("¤·¤·¤·");
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
    }

}
