
namespace SD101.Common
{
    using System;

    public class Event : EventArgs
    {
        public EventType Type;
        public object ExtraInfo;
    }

    public enum EventType
    {
        LOADING,
        START,
        FINISH
    }
}
