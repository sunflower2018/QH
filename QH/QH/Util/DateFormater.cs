using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QH.Util
{
    public class DateFormater : ICustomFormatter, IFormatProvider
    {
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            throw new NotImplementedException();
        }

        public object GetFormat(Type formatType)
        {
            throw new NotImplementedException();
        }
    }
}
