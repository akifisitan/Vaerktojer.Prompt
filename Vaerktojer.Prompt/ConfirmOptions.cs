using System;

namespace Vaerktojer.Prompt;

public class ConfirmOptions
{
    public string Message { get; set; } = null!;

    public bool? DefaultValue { get; set; }

    internal void EnsureOptions()
    {
        ArgumentNullException.ThrowIfNull(Message);
    }
}
