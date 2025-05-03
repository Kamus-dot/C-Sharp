using system;
public class Exception : ISerializable
{
    // Constructors
    public Exception(string message, Exception innerException);
    public Exception(string message);
    public Exception();
    // Methods
    public virtual Exception GetBaseException();
    public virtual void GetObjectData(SerializationInfo info, StreamingContext context);
    // Internals
    public virtual IDictionary Data { get; }
    public virtual string HelpLink { get; set; }
    public int HResult { get; set; }
    public Exception InnerException { get; }
    public virtual string Message { get; }
    public virtual string Sourse { get; set; }
    public virtual string StackTrace { get; }
    public MethodBase TargetTrace { get; }
}