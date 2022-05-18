using edproject.Models;
using System;

namespace edproject.Controllers
{
    internal class DBNewContext
    {
        public object Students { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public static implicit operator DBNewContext(StudentDBContext v)
        {
            throw new NotImplementedException();
        }
    }
}