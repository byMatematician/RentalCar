using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // beginning for bacis voids 
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
