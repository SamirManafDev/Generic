using System;
using System.Collections.Generic;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {

            Bot<Point>gamer= new Bot<Point>();

        }
        
    
    }
    //Task 1
    class GamePlayer<T>
    {
        public List<T> GamePlayers;

        public void AddPlayer(T game)
        {
            GamePlayers.Add(game);
        }
    }


    //Task 2
    interface ICharacter<T>
    {
        void Attacking<T>(T gamer);
        void TakingDamage<T>(T enemy);
        void Healing<T>(T gamer);

    }

    //Task 3
    class Player<T>
    {
        public List<T> Consol { get; set; }

        public void Add(T item)
        {
            Consol.Add(item);
        }
        public void Remove(T item)
        {
            Consol.Remove(item);
        }
        public void Sort()
        {
            Consol.Sort();
        }
    }
    //Task 5
    class Bot<T>
    {
        public List<T> Player { get; set; }
        public void Add(T item)
        {
            Player.Add(item);
        }
        public void Remove(T item)
        {
            Player.Remove(item);
        }
        public void Sort()
        {
            Player.Sort();
        }
    }

    class Point
    {

    }

    //Task 6
    public class GameObject
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }

        public void Names(string name)
        {
            Name = name;
        }
        public void LevelS(int level)
        {
            Level = level;
        }
        public void ScoreS(int score)
        {
            Score = score;
        }
    }
}

