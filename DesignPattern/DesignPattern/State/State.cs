using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 状态模式 
/// </summary>
namespace DesignPattern.State
{
    public abstract class State
    {
        public abstract void Display(Proxy proxy);
    }
}
