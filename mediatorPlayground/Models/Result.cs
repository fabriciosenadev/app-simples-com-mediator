namespace mediatorPlayground.Models
{
    public class Result
    {
        public Result(string message = "", bool isSuccess = true)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public string Message { get; private set; }
        public bool IsSuccess { get; private set; }
    }

    public class Result<T> : Result
    {
        public Result(T data, string message= "", bool isSuccess = true) : base(message, isSuccess)
        {
            Data = data;
        }

        public T Data { get; private set; }
    }
}
