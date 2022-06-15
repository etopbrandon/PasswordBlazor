using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace PasswordBlazor.Data
{
    public class Clipboard
    {
        private readonly IJSRuntime _jsRuntime;

        public Clipboard(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public ValueTask WriteTextAsync(string text)
        {
            return _jsRuntime.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
