using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CONTROL_DE_ARREGLOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables a declarar;
            string condicionWhile;
            string nombre;
            string medicamento;
            int botiquin = 0, curitas = 0, inyecciones = 0, oxigeno = 0, pastillas = 0, vendas = 0;

            //Este codigo sirve para modificar el tamaño de la consola
            Console.WindowHeight = 600;
            //Este codigo sirve para modificar el tamaño de la consola
            Console.WindowWidth = 600;

            //Este codigo sirve para cambiar el color de fondo de la consola
            Console.BackgroundColor = ConsoleColor.Red;
            //Este codigo sirve para cambiar la letra de la consola
            Console.ForegroundColor = ConsoleColor.Black;
            //Este codigo sirve para limpiar la consola
            Console.Clear();

            //Este codigo sirve para mostrar en pantalla un mensaje al usuario
            Console.WriteLine("Ingrese su nombre");
            //En esta variable se guardara el nombre del usuario
            nombre = Console.ReadLine();
            //Este codigo virve para mostrar un mensaje en pantalla al usuario
            Console.WriteLine("Bienvenido al Menu de Emergencias Enfermero {0}", nombre);
            //Este codigo sirve para que la consolla realize una pausa
            Thread.Sleep(2000);

            //Este codigo sirve para mostrar en pantalla un mensaje al usuario
            Console.WriteLine("Ingrese el material que desea llevar");
            //Este codigo sirve para que la consolla realize una pausa
            Thread.Sleep(1000);

            //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
            Console.WriteLine("Escribalos tal y como se muestra en pantalla");

            //En este codigo se mostrara en pantalla los materiales a elegir
            Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
            //En esta variable se guardara la opcion que el usuario eligio
            medicamento = Console.ReadLine().Trim();

            //En este if se guarda la rspuesta
            if (medicamento == "Botiquin")
            {
                //En esta variable se suman los resultados
                botiquin++;
            }
            //En este else if se guarda la rspuesta
            else if (medicamento == "Curitas")
            {
                //En esta variable se suman los resultados
                curitas++;
            }
            //En este else if se guarda la rspuesta
            else if (medicamento == "Inyecciones")
            {
                //En esta variable se suman los resultados
                inyecciones++;
            }
            //En este else if se guarda la rspuesta
            else if (medicamento == "Oxigeno")
            {
                //En esta variable se suman los resultados
                oxigeno++;
            }
            //En este else if se guarda la rspuesta
            else if (medicamento == "Pastillas")
            {
                //En esta variable se suman los resultados
                pastillas++;
            }
            //En este else if se guarda la rspuesta
            else if (medicamento == "Vendas")
            {
                //En esta variable se suman los resultados
                vendas++;
            }
            //Este codigo sirve para mostrarle al usuario un mensaje en pantalla
            Console.WriteLine("Desea agregar mas elementos? SI o NO");
            //En esta variable se guarda la respuesta del usuario
            condicionWhile = Console.ReadLine();

            //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
            while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
            {
                //Este codigo sirve para mostrarle un mensaje en consola al usuario
                Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                //En este codigo se mostrara en pantalla los materiales a elegir
                Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                //En esta variable se guardara la opcion que el usuario eligio
                medicamento = Console.ReadLine();

                //En este if se guarda la rspuesta
                if (medicamento == "Botiquin")
                {
                    botiquin++;
                }
                //En este else if se guarda la rspuesta
                else if (medicamento == "Curitas")
                {
                    curitas++;
                }
                //En este else if se guarda la rspuesta
                else if (medicamento == "Inyecciones")
                {
                    inyecciones++;
                }
                //En este else if se guarda la rspuesta
                else if (medicamento == "Oxigeno")
                {
                    oxigeno++;
                }
                //En este else if se guarda la rspuesta
                else if (medicamento == "Pastillas")
                {
                    pastillas++;
                }
                //En este else if se guarda la rspuesta
                else if (medicamento == "Vendas")
                {
                    vendas++;
                }
                //Este codigo sirve para mostrarle al usuario un mensaje en consola
                Console.WriteLine("Desea agregar mas elementos? SI o NO");
                //En este codigo se guarda la respuesta del usuario
                condicionWhile = Console.ReadLine();

                //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                {
                    //Este codigo sirve para mostrarle un mensaje en consola al usuario
                    Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                    //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                    Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                    //En este codigo se mostrara en pantalla los materiales a elegir
                    Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                    //En esta variable se guardara la opcion que el usuario eligio
                    medicamento = Console.ReadLine();
                    //Este codigo sirve para mostrarle al usuario un mensaje en consola
                    Console.WriteLine("Desea agregar mas elementos? SI o NO");
                    //En este codigo se guarda la respuesta del usuario
                    condicionWhile = Console.ReadLine();
                    //En este if se guarda la rspuesta
                    if (medicamento == "Botiquin")
                    {
                        botiquin++;
                    }
                    //En este else if se guarda la rspuesta
                    else if (medicamento == "Curitas")
                    {
                        curitas++;
                    }
                    //En este else if se guarda la rspuesta
                    else if (medicamento == "Inyecciones")
                    {
                        inyecciones++;
                    }
                    //En este else if se guarda la rspuesta
                    else if (medicamento == "Oxigeno")
                    {
                        oxigeno++;
                    }
                    //En este else if se guarda la rspuesta
                    else if (medicamento == "Pastillas")
                    {
                        pastillas++;
                    }
                    //En este else if se guarda la rspuesta
                    else if (medicamento == "Vendas")
                    {
                        vendas++;
                    }
                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }                    //En este while se checa la forma en la cual el usuario escribio su repuesta para darle un True
                    while (condicionWhile == "SI" || condicionWhile == "Si" || condicionWhile == "si")
                    {
                        //Este codigo sirve para mostrarle un mensaje en consola al usuario
                        Console.WriteLine("Se le mostrara de nuevo la lista de materiales");

                        //Este codigo sirve para darle una indicacion al usuario que se le mostrara en pantalla
                        Console.WriteLine("Escribalos tal y como se muestra en pantalla");
                        //En este codigo se mostrara en pantalla los materiales a elegir
                        Console.WriteLine("Botiquin  \t Curitas  \t Inyecciones  \t Oxigeno  \t Pastillas  \t Vendas ");
                        //En esta variable se guardara la opcion que el usuario eligio
                        medicamento = Console.ReadLine();

                        //En este if se guarda la rspuesta
                        if (medicamento == "Botiquin")
                        {
                            botiquin++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Curitas")
                        {
                            curitas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Inyecciones")
                        {
                            inyecciones++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Oxigeno")
                        {
                            oxigeno++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Pastillas")
                        {
                            pastillas++;
                        }
                        //En este else if se guarda la rspuesta
                        else if (medicamento == "Vendas")
                        {
                            vendas++;
                        }
                        //Este codigo sirve para mostrarle al usuario un mensaje en consola
                        Console.WriteLine("Desea agregar mas elementos? SI o NO");
                        //En este codigo se guarda la respuesta del usuario
                        condicionWhile = Console.ReadLine();
                    }
                }


            }

            //Este codigo sirve para mostrarle la cantidad de botiquines eligio para llevar
            Console.WriteLine("Usted lleva {0} Botiquin(es)", botiquin);
            //Este codigo sirve para mostrarle la cantidad de curitas eligio para llevar
            Console.WriteLine("Usted lleva {0} Curita(s)", curitas);
            //Este codigo sirve para mostrarle la cantidad de inyecciones eligio para llevar
            Console.WriteLine("Usted lleva {0} Inyeccion(es)", inyecciones);
            //Este codigo sirve para mostrarle la cantidad de tanques de oxigeno eligio para llevar
            Console.WriteLine("Usted lleva {0} Tanque(es) de oxigeno", oxigeno);
            //Este codigo sirve para mostrarle la cantidad de pastillas eligio para llevar
            Console.WriteLine("Usted lleva {0} Pastilla(s)", pastillas);
            //Este codigo sirve para mostrarle la cantidad de vendas eligio para llevar
            Console.WriteLine("Usted lleva {0} Venda(s)", vendas);

            //Este codigo sirve para que la consolla realize una pausa
            Thread.Sleep(5000);

            //Este codigo sirve para mostrarle al usuario que esta saliendo del sistema
            Console.WriteLine("Saliendo del sistema...");
            //Este codigo sirve para que la consola realize una pausa
            Thread.Sleep(2000);
            //Este codigo sirve para mostrarle al usuario que esta saliendo del sistema
            Console.WriteLine("Saliendo del sistema....");
            //Este codigo sirve para que la consola realize una pausa
            Thread.Sleep(2000);
            //Este codigo sirve para mostrarle al usuario que esta saliendo del sistema
            Console.WriteLine("Saliendo del sistema.....");
            //Este codigo sirve para que la consola realize una pausa
            Thread.Sleep(2000);
            //Este codigo sirve para mostrarle al usuario que esta saliendo del sistema
            Console.WriteLine("Saiendo del sistema......");
            //Este codigo sirve para que la consola realize una pausa
            Thread.Sleep(2000);

        }
    }
}
