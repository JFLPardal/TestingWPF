using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TestingWPF
{
    public partial class App : Application
    {
        public ObservableCollection<Skill> SkillsList { get; set; } = new ObservableCollection<Skill>();

        private void InitApp(object sender, StartupEventArgs args)
        {
            LoadSkills();
        }

        private void LoadSkills()
        {
            // Occultist's skills
            var SacrificialStab = new Skill("Sacrificial Stab", 4, 80, 10);
            var AbyssalArtillery = new Skill("Abyssal Artillery", 5, 80, 5);
            var WeakningCurse = new Skill("Weakning Curse", 2, 90, 5);
            var DaemonsPull = new Skill("Daemon's Pull", 3, 80, 17);

            // add them to SkillsList
            SkillsList.Add(SacrificialStab);
            SkillsList.Add(AbyssalArtillery);
            SkillsList.Add(WeakningCurse);
            SkillsList.Add(DaemonsPull);
        }
    }
}
