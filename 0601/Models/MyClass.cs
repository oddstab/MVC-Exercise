using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _0601.Models
{
    public class MyClass
    {

    }

    public static class MyClassExtend
    {
        private static bool IsImage(string FileName)
        {
            //先全部轉小寫
            FileName = FileName.ToLower();

            //如果包含其中一種就會return true
            return
                FileName.EndsWith(".jpg") ||
                FileName.EndsWith(".png") ||
                FileName.EndsWith(".gif") ||
                FileName.EndsWith(".bmp") ||
                FileName.EndsWith(".svg") ||
                FileName.EndsWith(".tif");
        }

        /// <summary>
        /// 過濾圖片檔案(依副檔名)
        /// </summary>
        /// <param name="ImageArr"></param>
        /// <returns></returns>
        public static string[] FilterImage(this string[] ImageArr)
        {
            try
            {
                List<string> NewArr = new List<string>();

                foreach (string item in ImageArr)
                {
                    if (IsImage(item))
                        NewArr.Add(item);
                }

                return NewArr.ToArray();
            }
            catch (Exception ex)
            {
                return new string[] { "Error：" + ex.Message };
            }

        }
    }
}