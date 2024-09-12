using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.GRAPS_and_SOLID.SOLID
{
    /*
        “Program to an interface, not to an implementation”
     */
    public class DependencyInversion
    {
        // DIP'yi ihlal eden örnek
        public class LightBulb1
        {
            public void TurnOn() { }
            public void TurnOff() { }
        }

        public class Switch1
        {
            private LightBulb bulb;

            public Switch1(LightBulb bulb)
            {
                this.bulb = bulb;
            }

            public void Operate()
            {
                // lambayı açma veya kapama kodu
            }
        }

        // DIP'yi takip eden örnek
        public interface ISwitchable
        {
            void TurnOn();
            void TurnOff();
        }

        public class LightBulb : ISwitchable
        {
            public void TurnOn() { }
            public void TurnOff() { }
        }

        public class Switch
        {
            private readonly ISwitchable device;

            public Switch(ISwitchable device)
            {
                this.device = device;
            }

            public void Operate()
            {
                // aleti açma veya kapama kodu
            }
        }

    }
}
