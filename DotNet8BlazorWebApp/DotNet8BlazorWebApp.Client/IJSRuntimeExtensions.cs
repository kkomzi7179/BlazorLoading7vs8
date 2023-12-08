using Microsoft.JSInterop;

namespace DotNet8BlazorWebApp.Client
{
    public static partial class IJSRuntimeExtensions
    {
        public static async Task DeleteElementById(this IJSRuntime jsRuntime, string id)
        {
            await jsRuntime.InvokeVoidAsync("DeleteElementById", id);
        }
    }
}