using System;

namespace ResultLab
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T? Value { get; }
        public string? Error { get; }

        // Приватные конструкторы — запрещаем создание вручную
        private Result(T value)
        {
            IsSuccess = true;
            Value = value;
            Error = null;
        }

        private Result(string error)
        {
            IsSuccess = false;
            Value = default(T);
            Error = error;
        }

        // Фабричные методы
        public static Result<T> Success(T value)
        {
            return new Result<T>(value);
        }

        public static Result<T> Failure(string error)
        {
            return new Result<T>(error);
        }
    }
}