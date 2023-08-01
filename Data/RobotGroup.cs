using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.Data
{
    public class RobotGroup: List<Robot>
    {
        public string Name { get; private set; }

        public RobotGroup(string name, List<Robot> robots) : base (robots)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
