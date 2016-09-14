using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS.Puzzle03.Models
{
    public interface IEntity
    {
        Guid id { get; }
    }
}