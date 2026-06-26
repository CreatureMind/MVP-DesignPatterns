using UnityEngine;

public class CoolPartyLogger
{
    public void WriteLine(string text)
    {
        Debug.Log($"{text}");
    }
}
