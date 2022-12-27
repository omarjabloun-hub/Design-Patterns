using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteApp
{
    public interface IDevice
    {
        public bool isEnabled();
        public void enable();
        public void disable();
        public int getVolume();
        public void setVolume(int percent);
        public int getChannel();
        public void setChannel(int channel);
        
    }
}
