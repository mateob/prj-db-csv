using System;
using System.Linq;
using prj_db_csv.service;

namespace prj_db_csv
{
    class Program
    {
        private const string path = @"./DB/CustomerList.csv"; // Aqui vai o nome do arquivo CSV
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
            Console.WriteLine("Aqui vai as opçẽos");
            Console.WriteLine("[1] Consultar média de idade dos pacientes");
            Console.WriteLine("[2] Consultar internações por ano");
            Console.WriteLine("[3] Consultar hospitais");
            Console.WriteLine("[4] Calcular tempo de internação");
            Console.WriteLine("[5] Determinar tempos de espera na fila");
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
                case "3":
                    Menu3();
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
            var restFilter = result.ToList<dynamic>();
        }

        private static void Menu2()
        {
            InitialMenu("Descrição do Menu 2");
            Console.WriteLine("Informe o município desejado: ");
            var valor = Console.ReadLine();
            var result = reader.ReadCsvPatientModel();
            if (result.Where(m => m.Monicipio).ToList().Count())
            {
                Console.WriteLine($"\r\nO Município inforamdo não foi localizado! Município informado: {valor} ");
            }
            else
            {
                var total2018 = result.Where(m => m.Municipio == valor && m.data_extracao.Year == 2018).ToList().Count();
                var total2019 = result.Where(m => m.Municipio == valor && m.data_extracao.Year == 2019).ToList().Count();
                var total2020 = result.Where(m => m.Municipio == valor && m.data_extracao.Year == 2020).ToList().Count();
                var total2021 = result.Where(m => m.Municipio == valor && m.data_extracao.Year == 2021).ToList().Count();
                Console.WriteLine($" | 2018: {total2018}");
                Console.WriteLine($" | 2019: {total2019}");
                Console.WriteLine($" | 2020: {total2020}");
                Console.WriteLine($" | 2021: {total2021}");
            }
        }

        /*
            Este menu deve fazer tal coisa
        */
        private static void Menu3()
        {
            InitialMenu("Deve mostrar os dados filtrados conforme entrada de valors\r\nDados de entrada esperados");
            Console.WriteLine("Informe o município desejado: ");
            var valor = Console.ReadLine();
            var result = reader.ReadCsvPatientModel();
            var restFilter = result.Where(m => m.Name == valor).ToList<dynamic>();
            // Aqui vai a logica para filstrar o dado. 

            var totalOfMunicipality = result.Where(m => m.Name == valor).ToList().Count();
            var totalPatientsM = result.Where(m => m.Name == valor && m.Genero == "M").ToList();
            var totalPatientsF = result.Where(m => m.Name == valor && m.Genero == "F").ToList();
            // Pegar a media por genero 
            // Pegar a media total

            Console.WriteLine($" | Numero de pacientes do Município: {totalOfMunicipality}");
            Console.WriteLine($" | Média de idade dos pacientes por gênero: {1}");
            Console.WriteLine($" | Média de idade de todos os pacientes: {2}");
        }

        private static void InitialMenu(string title)
        {
            Console.Clear();
            Console.WriteLine(title);
        }
    }
}
