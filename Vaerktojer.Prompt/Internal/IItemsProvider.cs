using System.Collections.Generic;
using System.Reflection;

namespace Vaerktojer.Prompt.Internal;

internal interface IItemsProvider
{
    IEnumerable<T> GetItems<T>(PropertyInfo targetPropertyInfo) where T : notnull;
}
