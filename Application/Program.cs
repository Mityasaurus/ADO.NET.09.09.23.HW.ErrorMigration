﻿using Spanish_Football_Championship;

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ChampionshipContext())
            {
                Console.WriteLine(context);

                var list = context.Teams.ToList();
            }
        }
    }
}