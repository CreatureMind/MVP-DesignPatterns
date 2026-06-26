using UnityEngine;

public enum LoggerType { CoolParty, DoomsDay, Whatsapp }

public interface ILogger
{
    void Log(string message, LoggerType loggerType = LoggerType.CoolParty);
}