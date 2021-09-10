using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using prj_db_csv.controller;
using prj_db_csv.model;

namespace prj_db_csv
{
    class Program
    {
        private const string path = @"./DB/DB.csv"; // Aqui vai o nome do arquivo CSV
        private static BaseRead reader = new BaseRead(path);
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            PropertyInfo[] properties = typeof(PatientModel).GetProperties();
            Console.WriteLine(properties[0].Name);
            Console.WriteLine("Aqui vai as opçẽos");
            Console.WriteLine("[1] ");
            Console.WriteLine("[2] ");
            Console.WriteLine("[3] ");
            Console.WriteLine("[4] ");
            Console.WriteLine("[5] ");
            Console.WriteLine("[6] ");
            Console.WriteLine("[0] Encerrar Aplicação");
            Console.Write("\r\nSelecione uma opção: ");
            switch (Console.ReadLine())
            {
                case "1":
                    Menu1();
                    return true;
                case "2":
                    Menu2();
                    return true;
                case "0":
                    return false;
                default:
                    return true;
            }
        }

        private static void Menu1()
        {
            InitialMenu("Descrição do Menu 1");
            var result = reader.ReadCsvPatientModel();
            var properties = reader.GetPropertiesPatient();
            var restFilter = result.ToList<dynamic>();
            PrintResult(restFilter, properties);
        }

        private static void Menu2()
        {
            InitialMenu("Descrição do Menu 2");
            var result = reader.ReadCsvPatientModel();
            var properties = reader.GetPropertiesPatient();
            var restFilter = result.ToList<dynamic>();
            PrintResult(restFilter, properties);
        }

        private static void InitialMenu(string title)
        {
            Console.Clear();
            Console.WriteLine(title);
        }

        private static void PrintHeader(List<PropertyInfo> properties)
        {
            var header = " | ";
            properties.ForEach(delegate (PropertyInfo property)
            {
                header += property.Name + " | ";
            });
            Console.WriteLine(header);
        }

        private static void PrintResult(List<dynamic> lines, List<PropertyInfo> properties)
        {
            PrintHeader(properties);
            lines.ForEach(delegate (dynamic line)
            {
                var dataLine = " | ";
                properties.ForEach(delegate (PropertyInfo property)
                {
                    dataLine += property.GetValue(line) + " | ";
                });
                Console.WriteLine(dataLine);
            });
            Console.WriteLine($"\r\nTotal de registros: {lines.Count()}");
            Console.WriteLine("\r\nPrecione [Enter] para retornar ao menu principal");
            Console.ReadLine();
        }
    }
}
