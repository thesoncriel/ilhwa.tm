using System;
using Theson.Util;

namespace Theson.Common
{
    public delegate void LogEventHandler(Object Sender, String msg);
    public delegate void StringTransEventHandler(object sender, string key, string value);
    public delegate void DataReceivedEventHandler(Object sender, IMultiTypeArguments argsData);
    public delegate void StatusChangedEventHandler(Object sender, bool status, String desc);
}
