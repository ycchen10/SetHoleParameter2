using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using NXOpen;
using NXOpen.UF;
using NXOpen.Utilities;

namespace SetHoleParameter
{

    public class SetHoleParameter
    {
        [DllImport("DrillParameterForGrip.dll", EntryPoint = "set_hole_parameter")]
        internal static extern int set_hole_parameter(string gripPath, Tag[] edges, string operName, double arr, double dpth, double clr);
        string _file;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gripFile">文件夹地址需要加\</param>
        public SetHoleParameter(string gripFile)
        {
            this._file = gripFile;
        }
        /// <summary>
        /// 中心孔
        /// </summary>
        /// <param name="edges"></param>
        /// <param name="dpth"></param>
        /// <returns></returns>
        public bool SetCenterHole(string operName, Tag[] edges, double dpth)
        {
            JAM.StartUFCall();
            int start = set_hole_parameter(_file + "Standard_Hole.grx",  edges, operName, edges.Length, dpth, 5.0);
            JAM.EndUFCall();
            if (start == 0)
                return true;
            else
                return false;
        }



    }
}
