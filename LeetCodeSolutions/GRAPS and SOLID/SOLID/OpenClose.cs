using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.GRAPS_and_SOLID.SOLID
{
    /*
        A software module (it can be a class or method) should be open for extension but closed for modification.
     */
    public class OpenClose
    {
        class DataStream
        {
            public byte[] Read() { return new byte[0]; }
        }

        class NetworkDataStream : DataStream
        {
            public byte[] Read()
            {
                //Read from the network
                throw new NotImplementedException();
            }
        }

        class PCIDataStream : DataStream
        {

            public byte[] Read()
            {
                //Read data from PCI
                throw new NotImplementedException();
            }
        }


        class Client
        {
            public void ReadData(DataStream ds)
            {
                ds.Read();
            }
        }

    }
}
