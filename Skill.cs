using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWPF
{
    public class Skill
    {
        private string m_name;
        private int m_damage;
        private int m_accuracy;
        private int m_critChance;

        public Skill(string name, int damage, int accuracy, int critChance)
        {
            m_name = name;
            m_damage = damage;
            m_accuracy = accuracy;
            m_critChance = critChance;
        }

        public string Name
        {
            get { return m_name; }
        }
    }
}
