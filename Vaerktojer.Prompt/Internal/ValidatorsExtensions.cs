using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vaerktojer.Prompt.Internal;

internal static class ValidatorsExtensions
{
    public static void Merge(this IList<Func<object?, ValidationResult?>> source, IEnumerable<Func<object?, ValidationResult?>>? validators)
    {
        foreach (var validator in validators ?? [])
        {
            source.Add(validator);
        }
    }
}
