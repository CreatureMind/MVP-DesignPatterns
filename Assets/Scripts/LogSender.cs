using TMPro;
using UnityEngine;

public class LogSender : MonoBehaviour
{
    private LoggerAdapter _loggerAdapter = new ();

    [SerializeField]
    private TMP_InputField text;
    
    private string message;

    public void PrintLog()
    {
        if (string.IsNullOrEmpty(text.text)) return;
        message = text.text;
        text.text = "";
        
        _loggerAdapter.Log(message);
        _loggerAdapter.Log(message, LoggerType.DoomsDay);
    }
    
    public void SendLog()
    {
        if (string.IsNullOrEmpty(text.text)) return;
        message = text.text;
        text.text = "";
        
        _loggerAdapter.Log(message, LoggerType.Whatsapp);
    }
}
