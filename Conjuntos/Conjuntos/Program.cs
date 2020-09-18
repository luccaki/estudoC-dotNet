/*
Em um portal de cursos online, cada usuário possui um código único, representado por
um número inteiro.
Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não
é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
alunos repetidos em mais de um curso.
O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
quantidade total de alunos.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using Conjuntos.Entities;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Aluno> alunos = new HashSet<Aluno>();
            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for(int i = 0; i < a; i++)
            {
                int id = int.Parse(Console.ReadLine());
                alunos.Add(new Aluno(id, 'A'));
            }
            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++)
            {
                int id = int.Parse(Console.ReadLine());
                alunos.Add(new Aluno(id, 'B'));
            }
            Console.Write("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                int id = int.Parse(Console.ReadLine());
                alunos.Add(new Aluno(id, 'C'));
            }
            Console.Write("Total students: ");
            Console.WriteLine(alunos.Count());
        }
    }
}
