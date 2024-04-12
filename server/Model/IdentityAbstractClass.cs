using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class IdentityAbstractClass<T>
    {
        public required T Id { get; set; }
    }
}
