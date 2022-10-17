using Microsoft.JSInterop;

namespace DxBlazorApplication1.Shared
{
    public class Helpers
    {
        public static async Task<string> GetCookieAsync(IJSRuntime JsRuntime, string cookieName)
        {
            return await JsRuntime.InvokeAsync<string>("ReadCookie.ReadCookie", cookieName);
        }

        public static async Task SetCookieAsync(IJSRuntime JsRuntime, string cookieName, string cookieValue, int numDays)
        {
            await JsRuntime.InvokeVoidAsync("WriteCookie.WriteCookie", cookieName, cookieValue, numDays);
        }

        public static void SetCookie(IJSRuntime JsRuntime, string cookieName, string cookieValue, int numDays2Expire)
        {
            JsRuntime.InvokeVoidAsync("WriteCookie.WriteCookie", cookieName, cookieValue, numDays2Expire);
        }
    }
}
