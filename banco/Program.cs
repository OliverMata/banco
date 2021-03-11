using System;

namespace banco
{
    class Cliente
    {
        //Crear un programa que simule un banco que tiene 3 clientes que pueden hacer depósitos y retiros. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositado.
        private string nombre;
        private int monto;

        public Cliente(string n)
        {
        nombre = n;
        monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Retirar(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Mostrar()
        {
            Console.WriteLine(nombre+" tiene depositado la suma de "+monto);
        }
    }

    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        public Banco() 
        {
            cliente1=new Cliente("Oliver");
            cliente2=new Cliente("Luis");
            cliente3=new Cliente("Mercedes"); 
        }

        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(200);
            cliente3.Depositar(300);
        }

        public void Depositos()
        {
            int t = cliente1.RetornarMonto () + 
            cliente2.RetornarMonto () + 
            cliente3.RetornarMonto ();
            Console.WriteLine ("El total de dinero en el banco es:" + t);
            cliente1.Mostrar();
            cliente2.Mostrar();
            cliente3.Mostrar();
        }

        static void Main(string[] args)
        {
            Banco obj = new Banco();
            obj.Operar();
            obj.Depositos();
            Console.ReadKey();
        }
    }
}
