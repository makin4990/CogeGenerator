﻿using System.Collections.Generic;
using WpfApp1.Models;

namespace WpfApp1.Generator
{


    public class ApplicationGenerator : Generator
    {
        private readonly List<ClassModel> _classList;

        public ApplicationGenerator(List<ClassModel> classList)
        {
            _classList = classList;
        }

        public override void Generate()
        {
            // Generate and define the behavior for ProjectB
        }
    }

}