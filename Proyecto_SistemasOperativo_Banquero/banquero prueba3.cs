using System;

class Program
{
    static int[,] Maximum, Allocation, Need;
    static int[] Available;
    static int clients, resources;

    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de clientes:");
        clients = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de tipos de recursos:");
        resources = int.Parse(Console.ReadLine());

        Available = new int[resources];
        Console.WriteLine("Ingrese la cantidad de instancias disponibles para cada recurso:");
        for (int i = 0; i < resources; i++)
        {
            Console.Write($"Recurso {i + 1}: ");
            Available[i] = int.Parse(Console.ReadLine());
        }

        Maximum = new int[clients, resources];
        Allocation = new int[clients, resources];
        Need = new int[clients, resources];

        Console.WriteLine("\nIngrese la cantidad máxima que puede solicitar cada cliente para cada recurso:");
        for (int i = 0; i < clients; i++)
        {
            Console.WriteLine($"Cliente {i + 1}:");
            for (int j = 0; j < resources; j++)
            {
                Console.Write($"Recurso {j + 1}: ");
                Maximum[i, j] = int.Parse(Console.ReadLine());
                Need[i, j] = Maximum[i, j]; // Inicialmente Need = Maximum
            }
        }

        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Solicitar recursos");
            Console.WriteLine("2. Liberar recursos");
            Console.WriteLine("3. Mostrar estructuras de datos");
            Console.WriteLine("4. Salir");

            Console.Write("\nSeleccione una opción: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RequestResources();
                    break;
                case 2:
                    ReleaseResources();
                    break;
                case 3:
                    ShowDataStructures();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    static void RequestResources()
    {
        Console.WriteLine("\nIngrese el ID del cliente:");
        int client = int.Parse(Console.ReadLine());

        int[] request = new int[resources];
        Console.WriteLine("Ingrese la cantidad de recursos solicitados:");
        for (int i = 0; i < resources; i++)
        {
            Console.Write($"Recurso {i + 1}: ");
            request[i] = int.Parse(Console.ReadLine());
        }

        if (IsRequestValid(client, request))
        {
            AllocateResources(client, request);
            if (IsSafeState())
            {
                Console.WriteLine("Solicitud concedida.");
            }
            else
            {
                DeallocateResources(client, request);
                Console.WriteLine("Solicitud rechazada: no se cumple el estado seguro.");
            }
        }
        else
        {
            Console.WriteLine("Solicitud rechazada: no es válida.");
        }
    }

    static void ReleaseResources()
    {
        Console.WriteLine("\nIngrese el ID del cliente:");
        int client = int.Parse(Console.ReadLine());

        int[] release = new int[resources];
        Console.WriteLine("Ingrese la cantidad de recursos a liberar:");
        for (int i = 0; i < resources; i++)
        {
            Console.Write($"Recurso {i + 1}: ");
            release[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < resources; i++)
        {
            Allocation[client, i] -= release[i];
            Need[client, i] += release[i];
            Available[i] += release[i];
        }

        Console.WriteLine("Recursos liberados.");
    }

    static void ShowDataStructures()
    {
        Console.WriteLine("\nDisponibles:");
        Console.WriteLine(string.Join(" ", Available));

        Console.WriteLine("\nAsignaciones:");
        PrintMatrix(Allocation);

        Console.WriteLine("\nNecesidades:");
        PrintMatrix(Need);

        Console.WriteLine("\nMáximos:");
        PrintMatrix(Maximum);
    }

    static bool IsRequestValid(int client, int[] request)
    {
        for (int i = 0; i < resources; i++)
        {
            if (request[i] > Need[client, i] || request[i] > Available[i])
                return false;
        }
        return true;
    }

    static void AllocateResources(int client, int[] request)
    {
        for (int i = 0; i < resources; i++)
        {
            Available[i] -= request[i];
            Allocation[client, i] += request[i];
            Need[client, i] -= request[i];
        }
    }

    static void DeallocateResources(int client, int[] request)
    {
        for (int i = 0; i < resources; i++)
        {
            Available[i] += request[i];
            Allocation[client, i] -= request[i];
            Need[client, i] += request[i];
        }
    }

    static bool IsSafeState()
    {
        int[] work = (int[])Available.Clone();
        bool[] finish = new bool[clients];
        int count = 0;

        while (count < clients)
        {
            bool found = false;

            for (int i = 0; i < clients; i++)
            {
                if (!finish[i])
                {
                    bool canFinish = true;
                    for (int j = 0; j < resources; j++)
                    {
                        if (Need[i, j] > work[j])
                        {
                            canFinish = false;
                            break;
                        }
                    }

                    if (canFinish)
                    {
                        for (int j = 0; j < resources; j++)
                            work[j] += Allocation[i, j];

                        finish[i] = true;
                        found = true;
                        count++;
                    }
                }
            }

            if (!found)
                return false;
        }

        return true;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
