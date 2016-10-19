using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4PracticeConsole.Utils
{
    public static class CommonUtil
    {
        /// <summary>
        /// 若要儲存檔案的資料夾不存在, 則建立資料夾
        /// </summary>
        /// <param name="dir"></param>
        public static void CreateDirectoryIfNotExist(string dir)
        {
            try
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("建立資料夾錯誤:" + dir, ex);
            }
        }
    }
}
