﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilding
{
    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Form { get; set; } = string.Empty;
        public string Type1 { get; set; } = string.Empty;
        public string Type2 { get; set; } = string.Empty;
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }

        public Pokemon() { }

        public Pokemon(int id, int dexNumber, string name, string form, string type1, string type2, int total, int hP, int attack, int defense, int specialAttack, int specialDefense, int speed, int generation)
        {
            Id = id;
            DexNumber = dexNumber;
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            HP = hP;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
            Generation = generation;

        }

        public override string ToString()
        {
            string msg = "";
            msg += $"Dex Number: {DexNumber}";
            msg += $"Name: {Name}";
            msg += $"Form: {Form}";
            msg += $"Type: {Type1}/{Type2}";
            return msg;

        }
    }
}
