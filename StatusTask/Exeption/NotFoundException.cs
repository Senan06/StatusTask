using System;
using System.Collections.Generic;
using System.Text;

namespace StatusTask.Exeption
{
    class NotFoundException:Exception
    {
        public NotFoundException(string mesagge):base(mesagge)
        {

        }
    }
}
