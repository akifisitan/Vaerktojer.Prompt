using System;

namespace Vaerktojer.Prompt;

public class PromptCanceledException : Exception
{
    public PromptCanceledException()
    {
    }

    public PromptCanceledException(string message)
        : base(message)
    {
    }

    public PromptCanceledException(string message, Exception inner)
        : base(message, inner)
    {
    }

    public PromptCanceledException(string message, string promptType)
        : base(message)
    {
        PromptType = promptType;
    }

    public string? PromptType { get; }
}
