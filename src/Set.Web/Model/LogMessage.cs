using Set.Core;

namespace Set.Web.Services;

public class LogMessage
{
    public LogMessage(string message, LogType type)
    {
        Message = message;
        Type = type;
    }

    public string Message { get; set; }
    public LogType Type { get; set; }
}
