using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingLibraryMultiLayer
{
    public class ProcessMultiLayerClass
    {
        public string[] ToonBestanden(string strPath)
        {
            return System.IO.Directory.GetFiles(strPath);
        }

        public string[] ToonInhoudEersteFile(string strPath)
        {
            //check welk bestand een tekstfile is
            string pathFirstFile = Directory.GetFiles(strPath).FirstOrDefault();

            //open en lees tekstfile
            string[] result = File.ReadAllLines(pathFirstFile);
           
            //return inhoud
            return result;
        }

    }
}


