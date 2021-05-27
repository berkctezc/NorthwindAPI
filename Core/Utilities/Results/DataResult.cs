namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = Data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = Data;
        }

        public T Data { get; }
    }
}