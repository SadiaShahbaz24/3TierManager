using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class CouData
    {
        private string id;
        private string name;
        private string crHour;
        private string type;
        private string dept;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string CrHour { get => crHour; set => crHour = value; }
        public string Type { get => type; set => type = value; }
        public string Dept { get => dept; set => dept = value; }
    }
}
