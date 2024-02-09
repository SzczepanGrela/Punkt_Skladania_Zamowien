using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.classes;
using WindowsFormsApp1.classes.DataObjects;
using WindowsFormsApp1.classes.FileOperations;
using WindowsFormsApp1.containers.usercontrols.controls;

namespace WindowsFormsApp1.classes
{
    public static class Methods
    {


        public static string[][] splitArray(string[] array, char delimiter)
        {
            string[][] splitArray = new string[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                splitArray[i] = array[i].Split(delimiter);
            }
            return splitArray;
        }


        public static string[] splitArray(string[] array, char delimiter, int column)
        {
            string[] splitArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                splitArray[i] = array[i].Split(delimiter)[column];
            }
            return splitArray;
        }




        public static string addApostrophes(string text)
        {


            return "'" + text + "'";
        }




      

      

       
    }
}
