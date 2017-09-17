using System;
using System.Collections.Generic;
using Theson.Common;

namespace Theson.Util
{
    

    public interface ITaskControl
    {
        bool IsFinish();
        void Start();
        void Stop();
        void Pause();
        bool IsBusy();
    }

    public interface IProgressReportable : ITaskControl
    {
        Object GetResult();
        int GetNowProgress();
        void SetDataNeeded(params Object[] data);
        String GetProgressDesc();
    }

    public interface IMultiTypeArguments
    {
        String Key { get; set; }
        int IntValue { get; set; }
        byte[] ByteValues { get; set; }
        Dictionary<int, int> IntValues { get; }
        bool BoolValue { get; set; }
        String StrValue { get; set; }
        Dictionary<int, double> DblValues { get; }
        int SingleHexa { get; set; }
    }

    public interface IAlarmLog
    {
        event LogEventHandler OnAlarm;
        event LogEventHandler OnWarning;
        event LogEventHandler OnLog;
    }
}
