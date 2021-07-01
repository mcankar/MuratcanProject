using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Entity
{
    public interface IEntity<T>
    {
        T ID { get; set; }

    }
}
