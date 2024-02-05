using ControllerDI.Interfaces;
using System;

namespace ControllerDI.Services
{
    #region snippet
    public class SystemDateTime : IDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
    #endregion
}