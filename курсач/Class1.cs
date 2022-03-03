using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    class Class1
    {
        private static ЖестьEntities _context;
        public static ЖестьEntities GetContext()
        {
            if (_context == null)
                _context = new ЖестьEntities();
            return _context;
        }
    }
}
