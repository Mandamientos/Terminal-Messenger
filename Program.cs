using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class TerminalMessenger {
    public static void Main(string[] args){

        Console.Clear();
        Int32 targetPort = 0;

        while (targetPort == 0 ){

            Console.Write("Ingrese el puerto con el cual se quiere comunicar > ");

            string targetPortStr = Console.ReadLine();

            try {
                targetPort = Int32.Parse(targetPortStr);
                if (49152 > targetPort || targetPort > 65535){
                    Console.WriteLine("El puerto debe estar en el rango de 49152-65535.");
                    targetPort = 0;
                    continue;
                }
            } catch (Exception ex) {
                Console.WriteLine("¡Eso no es un puerto!");
            }


        }



    }
}