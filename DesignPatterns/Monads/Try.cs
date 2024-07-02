namespace DesignPatterns.CSharp.Monads
{
    public class Try<T>
    {
        public T? Value { get; }
        public Exception? Error { get; }
        public bool IsSuccess { get; }

        private Try(T? value, Exception? error, bool isSuccess)
        {
            Value = value;
            Error = error;
            IsSuccess = isSuccess;
        }

        public static Try<T> Success(T value) => new(value, null, true);
        public static Try<T> Failure(Exception error) => new(default, error, false);
    }
}
