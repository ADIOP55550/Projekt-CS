using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Code from https://gist.github.com/audinue/4292e558db444bca83ddc9fb6e4f5810
/// </summary>
namespace Kalendarz
{
    public class Util
    {
        /**
     * <summary>C# implementation of JavaScript's setTimeout.</summary>
     */
        public static CancellationTokenSource setTimeout(Action callback, int delay = 100)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            Task.Delay(delay, source.Token)
                .ContinueWith(task =>
                {
                    if (!task.IsCanceled)
                    {
                        callback();
                    }
                }, source.Token);
            return source;
        }

        /**
     * <summary>C# implementation of JavaScript's clearTimeout.</summary>
     */
        public static void ClearTimeout(CancellationTokenSource source)
        {
            source.Cancel();
        }

        /**
     * <summary>Debounces the callback.</summary>
     */
        public static Action Debounce(Action callback, int delay = 100)
        {
            CancellationTokenSource? source = null;
            return () =>
            {
                if (source != null)
                {
                    ClearTimeout(source);
                }

                source = setTimeout(() =>
                {
                    source = null;
                    callback();
                }, delay);
            };
        }
    }
}