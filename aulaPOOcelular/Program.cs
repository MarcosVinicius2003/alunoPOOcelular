﻿using System;
using aulaPOOcelular.classes;

namespace aulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
           celular celular1 = new celular();
            string escolha; 
                do
                {
                    Console.WriteLine("O Celular está ligado?");
                    escolha = Console.ReadLine();

                    if(escolha.ToLower() == "s" ){
                    celular1.ligado = true;

                    Console.WriteLine("Digite a cor do celular: ");
                    celular1.cor = Console.ReadLine();

                    Console.WriteLine("Digite o modelo do celular: ");
                    celular1.modelo = Console.ReadLine();

                    Console.WriteLine("Digite o tamanho do celular: ");
                    celular1.tamanho = Console.ReadLine();

                    Console.Write("Quer enviar alguma mensagem?");
                    string resposta = Console.ReadLine();
                    
                    if(resposta.ToLower() == "s"){
                       celular1.mensagens = true;
                        celular1.Mensagem(celular1.mensagens);
                    }else{
                          celular1.mensagens = false;
                          celular1.Mensagem(celular1.mensagens);
                    }

                    Console.Write("Quer fazer alguma ligação? ");
                    string resposta2 = Console.ReadLine();
                     if(resposta2.ToLower() == "s"){
                        celular1.ligacoes = true;
                        celular1.FazerLigacao(celular1.ligacoes);
                    }else{
                          celular1.ligacoes = false;
                          celular1.FazerLigacao(celular1.ligacoes);
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Informaçoes do aparelho");
                    Console.ResetColor();
                    Console.WriteLine("Cor do aparelho : " + celular1.cor);
                    Console.WriteLine("Moedelo do aparelho: " + celular1.modelo);
                    Console.WriteLine("Tamanho do aparelho :" + celular1.tamanho);
                    break;

                    
                    }else {

                    Console.WriteLine("Fim");
                    }

                    }while (escolha.ToLower() == "s");
            }
        }
    }