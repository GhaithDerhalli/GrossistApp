using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace GrossistApp
{
    internal static class Program
    {
        ///  The main
        ///  entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        
    }
}