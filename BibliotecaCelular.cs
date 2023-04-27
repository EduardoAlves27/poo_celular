using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPOO_Celular
{
    public class BibliotecaCelular
    {
        public string cor;

        public string modelo;

        public int tamanho;

        public bool ligado;

        public bool desligado;

        public int numero;

        public int mensagem;

        public bool loop = true;


        public bool Ligar()
        {
            Console.WriteLine("Ligando celular...");
            return ligado = true;
        }

        public bool Desligar()
        {
            Console.WriteLine("Desligando celular...");
            loop = false;
            return ligado = false;
           
            
        }

        public void FazerLigacao(string numero) {
        if (!ligado) {
            Console.WriteLine("O celular precisa estar ligado para fazer ligações.");
            return;
        }

        Console.WriteLine($"Fazendo ligação para o número {numero}...");
    }

    public void EnviarMensagem(string numero, string mensagem) {
        if (!ligado) {
            Console.WriteLine("O celular precisa estar ligado para enviar mensagens.");
            return;
        }

        Console.WriteLine($"Enviando mensagem para o número {numero}: {mensagem}");
    }

    }
}