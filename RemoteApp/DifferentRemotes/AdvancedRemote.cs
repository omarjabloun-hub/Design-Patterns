using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp.DifferentRemotes
{
    internal class AdvancedRemote : Remote
    {
        private readonly IDevice device;
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void mute()
        {
            device.setVolume(0);
        }
        
    }
   
}
