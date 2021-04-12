using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Class07.CSharpOop.Inheretence.Domain.Classes
{
    //We inherit from EBook and because EBook inherits from Book we inherit from Book as well.
    //Changed inheritance
    public class KindleEbook : EBook
    {
        public bool IsAmazonProduced { get; set; } = true;
    }
}
