using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * @brief : DirectoryInfo class 를 사용하기 위함
 */
using System.IO;


namespace LearningCSharp.util
{
    class FileUtils
    {
        /*
         * @brief : 디렉토리 삭제 메소드
         * @arg path : 디렉토리 경로
         */
        public static bool deleteDirectory(string path)
        {
            bool isDelete = false;
            DirectoryInfo tempDirInfo = new DirectoryInfo(path);

            if (tempDirInfo.Exists == true)
            {
                foreach (DirectoryInfo di in tempDirInfo.GetDirectories())
                {
                    foreach (FileInfo fi in di.GetFiles())
                    {
                        // 파일 속성이 ReadOnly 인 경우에 노멀로 변경 하고 삭제 한다.
                        if ((fi.Attributes & FileAttributes.ReadOnly) > 0)
                        {
                            fi.Attributes = FileAttributes.Normal;
                        }
                    }
                }
                tempDirInfo.Delete(true);
                isDelete = true;
            }

            return isDelete;
        }
    }
}
