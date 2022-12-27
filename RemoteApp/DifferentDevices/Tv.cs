using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp.DifferentDevices
{
    internal class Tv : IDevice
    {
        public void disable()
        {

            // send UV signal to disable TV thru api called with httpclient
            throw new NotImplementedException();
        }

        public void enable()
        {
            throw new NotImplementedException();
        }

        public int getChannel()
        {
            throw new NotImplementedException();
        }

        public int getVolume()
        {
            throw new NotImplementedException();
        }

        public bool isEnabled()
        {
            throw new NotImplementedException();
        }

        public void setChannel(int channel)
        {
            throw new NotImplementedException();
        }

        public void setVolume(int percent)
        {
            throw new NotImplementedException();
        }
    }
}
