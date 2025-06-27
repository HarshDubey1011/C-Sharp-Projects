using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSystem
{
    internal class VolumeButton : VolumeButtonImpl
    {
        IElectronicDevice device;

        public VolumeButton(IElectronicDevice device )
        {
            this.device = device;
        }
        public void VolumeDown()
        {
            device.VolumeDown();
        }

        public void VolumeUp()
        {
            device.VolumeUp();
        }
    }
}
