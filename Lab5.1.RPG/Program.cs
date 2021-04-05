using System;
using System.Collections.Generic;

namespace Lab5._1.RPG
{
    class GameCharacter
    {
        private string GamersName;
        private int GamersStrenght;
        private int GamersIntelligence;

        public GameCharacter(string name, int strenght, int intelligence)
        {
            GamersName = name;
            GamersStrenght = strenght;
            GamersIntelligence = intelligence;
        }
        public void setGamersName(string name)
        {
            GamersName = name;
        }
        public string getGamersName()
        {
            return GamersName;
        }
        public void setGamersStrenght(int strenght)
        {
            GamersStrenght = strenght;
        }
        public int getGamersStrenght()
        {
            return GamersStrenght;
        }
        public void setGamersIntelligence(int intelligence)
        {
            GamersIntelligence = intelligence;
        }
        public int getGamersIntelligence()
        {
            return GamersIntelligence;
        }


        public virtual string Play()
        {
            return $"Name: {GamersName} Intelligent Level: {GamersIntelligence} Strenght Level: {GamersStrenght})";
        }
    }

        class MagicUsingCharacter : GameCharacter
        {
            public int MagicalEnergy;
            public MagicUsingCharacter(string name, int strenght, int intelligence, int energy) : base(name, strenght, intelligence)
            {
                MagicalEnergy = energy;
            }
            
            public override string Play()
            {
                return $"Name: {getGamersName()} Strenght: {getGamersStrenght()} Intelligent: {getGamersIntelligence()} Magic {MagicalEnergy} ";
            }
           
        }
        class Warrior : GameCharacter
        {
            public string WeaponType;
            public Warrior(string name, int strength, int intelligence, string weapon) : base(name, strength, intelligence)
            {
                WeaponType = weapon;
            }
            
            public override string Play()
            {
                return $"{getGamersName()} (Intelligence: {getGamersIntelligence()} Strength: {getGamersStrenght()}) Weapon: {WeaponType}";
            }
        }
        class Wizard : MagicUsingCharacter
        {
            public int SpellNumber;
            public Wizard(string name, int strength, int intelligence, int energy, int spells) : base(name, strength, intelligence, energy)
            {
                SpellNumber = spells;
            }
            
            public override string Play()
            {
                return $"{getGamersName()}: (Intelligence: {getGamersIntelligence()}, Strength: {getGamersStrenght()}) Magic: {MagicalEnergy} Spells: {SpellNumber}";
            }
        }



    

    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(new Warrior("Troy", 15, 20, "Spear"));
            characters.Add(new Warrior("Robinhood", 8, 18, "arrow"));
            characters.Add(new Wizard("Ozi", 13, 17, 97, 8));
            characters.Add(new Wizard("Charmander", 10, 22, 55, 6));
            characters.Add(new Wizard("Lucus", 13, 19, 76, 4));




            Console.WriteLine("Welcome to World of Dev.BuildCraft!");



            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i].Play());
            }
        }
    }
}
