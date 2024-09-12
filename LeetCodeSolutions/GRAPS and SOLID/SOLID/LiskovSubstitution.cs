using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.GRAPS_and_SOLID.SOLID
{
    /*
        Derived classes must be substitutable for their base classes.
     */
    public class LiskovSubstitution
    {
        public interface IDevice
        {
            void Open();
            void Read();
            void Close();
        }

        public class PCIDevice : IDevice
        {
            public void Open()
            {
                // Device specific opening logic
            }
            public void Read()
            {
                // Reading logic specific to this device
            }
            public void Close()
            {
                // Device specific closing logic.
            }
        }

        public class NetWorkDevice : IDevice
        {

            public void Open()
            {
                // Device specific opening logic
            }
            public void Read()
            {
                // Reading logic specific to this device
            }
            public void Close()
            {
                // Device specific closing logic.
            }
        }
        public class USBDevice : IDevice
        {
            public void Open()
            {
                // Device specific opening logic
            }
            public void Read()
            {
                // Reading logic specific to this device<br> 
            }
            public void Close()
            {
                // Device specific closing logic.
            }
            public void Refresh()
            {
                // specific only to USB interface Device
            }
        }

        //Client code...

        public void Acquire(IDevice aDevice)
        {
            aDevice.Open();
            // Identify if the object passed here is USBDevice class Object.    
            if (aDevice.GetType() == typeof(USBDevice))
            {
                USBDevice aUsbDevice = (USBDevice)aDevice;
                aUsbDevice.Refresh();
            }

            // remaining code….
        }

    }
}
