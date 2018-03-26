using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
using System.Net;
using Microsoft.Win32;
using F4SharedMem;

namespace DEDuino
{
    public partial class MainWindow
    {

        private bool CheckLight(F4SharedMem.Headers.LightBits datamask)
        {
            if ((BMSdata.lightBits & (Int32)datamask) == (Int32)datamask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckLight(F4SharedMem.Headers.LightBits2 datamask)
        {
            if ((BMSdata.lightBits2 & (Int32)datamask) == (Int32)datamask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckLight(F4SharedMem.Headers.LightBits3 datamask)
        {
            if ((BMSdata.lightBits3 & (Int32)datamask) == (Int32)datamask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckLight(F4SharedMem.Headers.HsiBits datamask)
        {
            if ((BMSdata.hsiBits & (Int32)datamask) == (Int32)datamask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckLight(F4SharedMem.Headers.PowerBits datamask)
        {
            if ((BMSdata.powerBits & (Int32)datamask) == (Int32)datamask)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
