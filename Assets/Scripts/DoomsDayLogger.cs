using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class DoomsDayLogger
{
    public async void DoomLine(string text)
    {
        if (!text.Contains(":(", System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log($"{text} :( :( :( :(");
            return;
        }
        
        Debug.LogWarning("You've trigger the doomsday log");

        await Task.Delay(2500);
        
        Debug.LogWarning("3");
        
        await Task.Delay(2000);
        
        Debug.LogWarning("2");
        
        await Task.Delay(1000);
        
        Debug.LogError("1");
        
        await Task.Delay(500);
        
        EditorApplication.Exit(0);
    }
}
