using UnityEngine;

public class LoggerAdapter : ILogger
{
    private CoolPartyLogger _logger = new ();
    private DoomsDayLogger _doomsDayLogger = new ();
    private WhatsappLogger _whatsappLogger = new ();

    public void Log(string message,LoggerType loggerType = LoggerType.CoolParty)
    {
        switch (loggerType)
        {
            case LoggerType.CoolParty:
                _logger.WriteLine(message);
                break;
            case LoggerType.DoomsDay:
                _doomsDayLogger.DoomLine(message);
                break;
            case LoggerType.Whatsapp:
                _whatsappLogger.SendLine(message);
                break;
            default:
                _logger.WriteLine(message);
                break;
        }
    }
}