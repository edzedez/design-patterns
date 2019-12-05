﻿namespace DesignPatterns.FactoryPattern
{
    namespace DoFactory.GangOfFour.Factory.RealWorld
    {
        class Resume : Document

        {
            // Factory Method implementation

            public override void CreatePages()
            {
                Pages.Add(new SkillsPage());
                Pages.Add(new EducationPage());
                Pages.Add(new ExperiencePage());
            }
        }
    }





}
