using System;
using UnityEngine;

public class WhatsappLogger
{
    public void SendLine(string message)
    {
        string escapedMessage = Uri.EscapeDataString(message);

        string url = $"https://api.whatsapp.com/send?phone=972524395533&text={escapedMessage}";
        
        Application.OpenURL(url);
    }
}