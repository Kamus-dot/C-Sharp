using System;

namespace ProcessMultipleExceptions
{
    public class CarIsDeadException : ApplicationException
    {
        private string _messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string? CauseOfError { get; set; }
        public CarIsDeadException() { }
        public CarIsDeadException(string cause, DateTime time)
        : this(cause, time, string.Empty) { }
        public CarIsDeadException(string cause, DateTime time, string message)
        : this(cause, time, message, null) { }
        public CarIsDeadException(string cause, DateTime time,
        string message, System.Exception? inner)
        : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }
    // public override string Message => $"Car Error Message: {_messageDetails}";
    }
    // Написать exc и нажать на TAB

    // [System.Serializable]
    // public class CustomExceptionException : System.Exception
    // {
    //     public CustomExceptionException() { }
    //     public CustomExceptionException(string message) : base(message) { }
    //     public CustomExceptionException(string message, System.Exception inner) : base(message, inner) { }
    //     protected CustomExceptionException(
    //         System.Runtime.Serialization.SerializationInfo info,
    //         System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    // }
}
