using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace gestaodeclientes
{
    internal class Program
    {
        [System.Serializable]
        struct Cliente
        {
            public string nome;
            public string email;
            public string cpf;

        }

        enum Menu
        {
            Listar = 1,
            Adicionar = 2,
            Remover = 3,
            Sair = 4
        }

        static List<Cliente> clientes = new List<Cliente>();

        public static void Main(string[] args)
        {
            Carregar();
            bool sair = false;
            while (!sair)
            {
                Console.WriteLine("---SISTEMA DE GESTÃO DE CLIENTES---");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Digite Uma Opção:");
                Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-sair");
                int opcao = int.Parse(Console.ReadLine());
                Menu opcoes = (Menu)opcao;

                switch (opcoes)
                {
                    case Menu.Listar:
                        Listar();
                        break;
                    case Menu.Adicionar:
                        Adicionar();
                        break;
                    case Menu.Remover:
                        Remover();
                        break;
                    case Menu.Sair:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida.");
                        break;
                }

                Console.Clear();


            }




        }

        static void Adicionar()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Adicionar Clientes: ");
            Console.WriteLine("--------------------");
            Console.Write("Nome: ");
            cliente.nome = Console.ReadLine();
            Console.Write("Cpf: ");
            cliente.cpf = Console.ReadLine();
            Console.Write("Email: ");
            cliente.email = Console.ReadLine();

            clientes.Add(cliente);
            Salvar();
            Console.WriteLine("\n\n Cadastro Concluido Com Sucesso....");
            Console.WriteLine("Aperte Enter Para Sair....");
            Console.ReadLine();
        }



        static void Remover()
        {
            Listar();
            Console.WriteLine("Digite o Id do Cliente Quer Você quer remover");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < clientes.Count)
            {
                clientes.RemoveAt(id);
                Salvar();
            }
        }

        static void Listar()
            {


                if (clientes.Count > 0)
                {
                    Console.WriteLine("LISTA DE CLIENTES");
                    Console.WriteLine("-----------------");
                    int i = 0;
                    foreach (Cliente cliente in clientes)
                    {
                        Console.WriteLine($"ID: {i}");
                        Console.WriteLine($"Nome: {cliente.nome}");
                        Console.WriteLine($"Email:{cliente.email}");
                        Console.WriteLine($"Cpf: {cliente.cpf}");
                        Console.WriteLine("#####################");
                        i++;
                    }
    
   
                }
                else
                {
                    Console.WriteLine("Nenhum Cliente Cadastrado.....");

                }

                Console.WriteLine("Aperte Enter Para Sair....");
                Console.ReadLine();
            }


            static void Salvar()
            {
                FileStream stream = new FileStream("Clientes.dat", FileMode.OpenOrCreate);
                BinaryFormatter encoder = new BinaryFormatter();
                encoder.Serialize(stream, clientes);
                stream.Close();

            }

            static void Carregar()
            {
                FileStream stream = new FileStream("Clientes.dat", FileMode.OpenOrCreate);
                try
                {
                    BinaryFormatter encoder = new BinaryFormatter();
                    clientes = (List<Cliente>)encoder.Deserialize(stream);
                    if (clientes == null)
                    {
                        clientes = new List<Cliente>();
                    }


                }
                catch (Exception e)
                {
                    clientes = new List<Cliente>();
                }


                stream.Close();
            }
        }
    }


        
            


    

    
