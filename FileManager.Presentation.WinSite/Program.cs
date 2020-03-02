using FileManager.Common.Layer;
using FileManager.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager.Presentation.WinSite
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

          
           Commands();

           

            /* Application.EnableVisualStyles();
             Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new frmStudent());*/


        }

        private static void Commands()
        {

            Student student = new Student(10,"Sergi","Virgilius",2000);
            
            IFile file = FactoryProvider.getFactory("File").Create(FileTypes.txt);

            file.Create(student);
            

        }
        
    }
}
