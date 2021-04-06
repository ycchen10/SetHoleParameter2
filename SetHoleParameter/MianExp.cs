using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NXOpen;
using NXOpen.UIStyler;
using NXOpen.UF;

namespace SetHoleParameter
{
    public class MianExp
    {
        public static int Main(string[] args)
        {

            Tag[] edges = { (Tag)59752 };
            SetHoleParameter hole = new SetHoleParameter(@"C:\Users\ycchen10\OneDrive - kochind.com\Desktop\MolexPlugIn-1899\hole\");
            hole.SetCenterHole("DRILLING", edges, 1.0);
            return 0;
        }



        /// <summary>
        /// 卸载函数
        /// </summary>
        /// <param name="arg"></param>
        /// <returns></returns>
        public static int GetUnloadOption(string arg)
        {
            // return System.Convert.ToInt32(Session.LibraryUnloadOption.Explicitly);
            return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);
            // return System.Convert.ToInt32(Session.LibraryUnloadOption.AtTermination);
        }
    }
}
