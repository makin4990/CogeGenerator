﻿using System.Collections.Generic;
using WpfApp1.Models;

namespace WpfApp1.Generator
{
    public class InfrastructureGenerator : Generator
    {
        private readonly List<ClassModel> _classList;

        public InfrastructureGenerator(List<ClassModel> classList)
        {
            _classList = classList;
        }

        public override void Generate()
        {
            // Generate and define the behavior for ProjectB
        }
    }

}