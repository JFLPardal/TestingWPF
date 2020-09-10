using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestingWPF
{
    public class Skill
    {
        private string m_name;
        private int m_damage;
        private int m_accuracy;
        private int m_critChance;
        private string m_abbreviation;

        public Skill(string name, string abbreviation, int damage, int accuracy, int critChance)
        {
            m_name = name;
            m_abbreviation = abbreviation;
            m_damage = damage;
            m_accuracy = accuracy;
            m_critChance = critChance;
        }

        public override string ToString()
        {
            return Name;
        }

        public string Name { get { return m_name; } }
        public int Damage { get { return m_damage; } }
        public int Accuracy { get { return m_accuracy; } }
        public int Crit { get { return m_critChance; } }
        public string Abbreviation { get { return m_abbreviation; } }

       
    }
}
