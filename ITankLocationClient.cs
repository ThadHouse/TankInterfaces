using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XNATankGame
{
    public interface ITankLocationClient
    {
        event EventHandler<Tank> OnRedTankUpdated;
        event EventHandler<Tank> OnBlueTankUpdated;
        
        Tank GetRedTank();
        Tank GetBlueTank();
    }
}
