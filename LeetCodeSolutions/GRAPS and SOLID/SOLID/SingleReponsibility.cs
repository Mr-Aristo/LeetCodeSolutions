using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.GRAPS_and_SOLID.SOLID
{
    /*
     * A class should have only one responsibility 
     */
    public class SingleReponsibility
    {

        /* Wrong usage */
        class Simulation
        {
            public void Simulate() { }
            public void LoadSimulationFile() { }
            public void ConvertParams() { }
            
        }

        /* Right usage */

        class Simulation2
        {
           public void Simulate() { }
           
   
        }

        class Convert
        {
            public void ConvertParams() { }
        }

        class SimulationFile
        {
            public void LoadSimulationFile() { }
        }
    }
}
