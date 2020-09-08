using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IUser<T>
    {
        T Id { get; }
    }
    class User<T>: IUser<T>
    {
        T _id;
        public User(T id)
        {
            _id = id;
        }

        T IUser<T>.Id => _id;
    }
    class IntUser : IUser<int>
    {
        int _id;
        public IntUser(int id)
        {
            _id = id;
        }

        int IUser<int>.Id { get { return _id; } }
    }
}
